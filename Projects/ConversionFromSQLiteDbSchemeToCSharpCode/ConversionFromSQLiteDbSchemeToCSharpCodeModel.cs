namespace ConversionFromSQLiteDbSchemeToCSharpCode
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;
    using System.ComponentModel;
    using sds = System.Data.SQLite;

    public class ConversionFromSQLiteDbSchemeToCSharpCodeModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var t = PropertyChanged;
            if (t != null) { t(this, new PropertyChangedEventArgs(propertyName)); }
        }

        string _DataBaseFilePath;
        public string DataBaseFilePath
        {
            get { return _DataBaseFilePath; }
            set
            {
                _DataBaseFilePath = value;
                OnPropertyChanged(nameof(DataBaseFilePath));
                if (System.IO.File.Exists(DataBaseFilePath) == false)
                {
                    ConversionResult = $"File not found.  Path: {DataBaseFilePath}";
                    return;
                }
                _NamespaceName = System.IO.Path.GetFileNameWithoutExtension(DataBaseFilePath);
                OnPropertyChanged(nameof(NamespaceName));
                _DataSetClassName = NamespaceName + "DataSet";
                OnPropertyChanged(nameof(DataSetClassName));

                if (UpdateTableInfoList() == false) { return; }
                UpdateCSharpCodeString();
            }
        }
        string _NamespaceName;
        public string NamespaceName
        {
            get { return _NamespaceName; }
            set
            {
                _NamespaceName = value;
                OnPropertyChanged(nameof(NamespaceName));
                UpdateCSharpCodeString();
            }
        }
        string _DataSetClassName;
        public string DataSetClassName
        {
            get { return _DataSetClassName; }
            set
            {
                _DataSetClassName = value;
                OnPropertyChanged(nameof(DataSetClassName));
                UpdateCSharpCodeString();
            }
        }
        string _ConversionResult;
        public string ConversionResult
        {
            get { return _ConversionResult; }
            private set { _ConversionResult = value; OnPropertyChanged(nameof(ConversionResult)); }
        }

        public ObservableCollection<SQLiteTableInfo> TableInfoList { get; private set; }

        bool UpdateTableInfoList()
        {
            try
            {
                var typeName_Count_DictForDebug = new Dictionary<string, int>();
                var tableName_SQLiteTableInfo_Dict = new Dictionary<string, SQLiteTableInfo>();

                using (var conn = new sds.SQLiteConnection("Data Source=" + DataBaseFilePath))
                {
                    conn.Open();
                    using (var getTableNamesCommand = conn.CreateCommand())
                    {
                        getTableNamesCommand.CommandText = "SELECT * FROM sqlite_master WHERE type='table'";
                        using (var getTableNamesReader = getTableNamesCommand.ExecuteReader())
                        {
                            while (getTableNamesReader.Read())
                            {
                                var tableName = getTableNamesReader["tbl_name"].ToString();
                                tableName_SQLiteTableInfo_Dict[tableName] = new SQLiteTableInfo() { SQLiteTableName = tableName };
                            }
                        }
                    }
                    foreach (var tableName in tableName_SQLiteTableInfo_Dict.Keys)
                    {
                        using (var getColumnInfoListCommand = conn.CreateCommand())
                        {
                            getColumnInfoListCommand.CommandText = "PRAGMA table_info('" + tableName + "')";
                            using (var getColumnInfoListReader = getColumnInfoListCommand.ExecuteReader())
                            {
                                while (getColumnInfoListReader.Read())
                                {
                                    SQLiteColumnInfo newItem = new SQLiteColumnInfo();
                                    newItem.cid = getColumnInfoListReader.GetInt64(0);
                                    newItem.name = getColumnInfoListReader.GetString(1);
                                    newItem.type = getColumnInfoListReader.GetString(2);
                                    newItem.notnull = getColumnInfoListReader.GetInt64(3);
                                    newItem.dflt_value = getColumnInfoListReader.GetValue(4);
                                    newItem.pk = getColumnInfoListReader.GetInt64(5);

                                    // use "NULL" as object
                                    if (newItem.type == null) { newItem.type = "NULL"; }
                                    if (typeName_Count_DictForDebug.ContainsKey(newItem.type) == false) typeName_Count_DictForDebug[newItem.type] = 0;
                                    typeName_Count_DictForDebug[newItem.type]++;

                                    tableName_SQLiteTableInfo_Dict[tableName].ColumnInfoList.Add(newItem);
                                }
                            }
                        }
                    }
                    conn.Close();
                }
                foreach (var item in typeName_Count_DictForDebug) { Debug.WriteLine($"{item.Key}: {item.Value}"); }
                TableInfoList = new ObservableCollection<SQLiteTableInfo>(tableName_SQLiteTableInfo_Dict.Values.ToList());
                OnPropertyChanged(nameof(TableInfoList));
                return true;
            }
            catch (Exception e)
            {
                ConversionResult = "Failed UpdateTableInfoList()." + Environment.NewLine + e.ToString();
                return false;
            }
        }

        bool UpdateCSharpCodeString()
        {
            try
            {
                var sb = new StringBuilder();
                var AppendLineToPocoCode = new Action<string, int>((str, tabsCount) =>
                {
                    for (int i = 0; i < tabsCount; i++) { sb.Append("    "); }
                    sb.AppendLine(str);
                });

                AppendLineToPocoCode($"namespace {NamespaceName}", 0);
                AppendLineToPocoCode("{", 0);
                AppendLineToPocoCode("using System;", 1);
                AppendLineToPocoCode("using System.Collections.Generic;", 1);
                // ToList()
                AppendLineToPocoCode("using System.Linq;", 1);
                // [Table], [Column] of SQLite
                AppendLineToPocoCode("using System.Data.Linq.Mapping;", 1);
                // [Required]
                AppendLineToPocoCode("using System.ComponentModel.DataAnnotations;", 1);
                // [DataContract], [DataMember]
                AppendLineToPocoCode("using System.Runtime.Serialization;", 1);

                foreach (var tableInfo in TableInfoList)
                {
                    AppendLineToPocoCode("", 0);
                    AppendLineToPocoCode($"[Table(Name = \"{tableInfo.SQLiteTableName}\")]", 1);
                    AppendLineToPocoCode("[DataContract]", 1);
                    AppendLineToPocoCode($"public class {tableInfo.ClrClassName}", 1);
                    AppendLineToPocoCode("{", 1);
                    foreach (var columnInfo in tableInfo.ColumnInfoList)
                    {
                        AppendLineToPocoCode(columnInfo.SQLiteAttributeAsString, 2);
                        AppendLineToPocoCode(columnInfo.ClrAttributeAsString, 2);
                        AppendLineToPocoCode(columnInfo.PropertyString, 2);
                    }
                    AppendLineToPocoCode("}", 1);
                }

                AppendLineToPocoCode("", 0);
                AppendLineToPocoCode("[DataContract]", 1);
                AppendLineToPocoCode($"public class {DataSetClassName}", 1);
                AppendLineToPocoCode("{", 1);

                foreach (var tableInfo in TableInfoList)
                {
                    AppendLineToPocoCode("[DataMember]", 2);
                    AppendLineToPocoCode($"public List<{tableInfo.ClrClassName}> {tableInfo.ClrListObjectName} {{ get; set; }}", 2);
                }

                AppendLineToPocoCode($@"
        public static {DataSetClassName} LoadDataFromFile(string dataBaseFilePath)
        {{
            var ret = new {DataSetClassName}();
            using (var conn = new System.Data.SQLite.SQLiteConnection(""Data Source="" + dataBaseFilePath))
            {{
                conn.Open();
                using (var reader = new System.Data.Linq.DataContext(conn))
                {{", 0);
                foreach (var tableInfo in TableInfoList)
                {
                    AppendLineToPocoCode($"ret.{tableInfo.ClrListObjectName} = reader.GetTable<{tableInfo.ClrClassName}>().ToList();", 5);
                }
                AppendLineToPocoCode($@"                }}
                conn.Close();
            }}
            return ret;
        }}", 0);

                AppendLineToPocoCode("}", 1);
                AppendLineToPocoCode("}", 0);

                ConversionResult = sb.ToString();
                return true;
            }
            catch (Exception e)
            {
                ConversionResult = "Failed UpdateCSharpCodeString()." + Environment.NewLine + e.ToString();
                return false;
            }
        }

        [Obsolete]
        void UpdateWithCodeDom()
        {
            var provider = System.CodeDom.Compiler.CodeDomProvider.CreateProvider("CSharp");
            var cp = new System.CodeDom.Compiler.CompilerParameters();
            var result = provider.CompileAssemblyFromSource(cp, ConversionResult);
        }
    }
}
