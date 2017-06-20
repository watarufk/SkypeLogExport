namespace ConversionFromSQLiteDbSchemeToCSharpCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    public static class CSharpNotation
    {
        public static readonly string[] CSharpKeywords = new string[]
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
            "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
            "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach",
            "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long",
            "namespace", "new", "null", "object", "operator", "out", "override", "params", "private",
            "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof",
            "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof",
            "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "using", "static", "void", "volatile", "while"
        };
        public static readonly string[] CSharpContextualKeywords = new string[]
        {
            "add", "alias", "ascending", "async", "await", "descending", "dynamic", "from", "get",
            "global", "group", "into", "join", "let", "orderby", "partial", "remove",
            "select", "set", "value", "var", "when", "where", "yield"
        };
    }

    public class SQLiteColumnInfo
    {
        public long cid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public long notnull { get; set; }
        public object dflt_value { get; set; }
        public long pk { get; set; }

        public string SQLiteAttributeAsString
        {
            get
            {
                var ret = $"[Column(Name = \"{name}\"";
                if (pk != 0) { ret += ", IsPrimaryKey = true"; }
                else if (notnull != 0) { ret += ", CanBeNull = false"; }
                ret += ")]";
                return ret;
            }
        }

        public bool IsRequired { get { return (pk != 0) || (notnull != 0); } }
        public string ClrAttributeAsString
        {
            get
            {
                var ret = "[DataMember";
                if (IsRequired) { ret += ", Required"; }
                ret += "]";
                return ret;
            }
        }
        public string ClrTypeAsString
        {
            get
            {
                switch (type)
                {
                    case "NULL": return "object";
                    case "INTEGER": return (IsRequired) ? "Int64" : "Int64?";
                    case "REAL": return (IsRequired) ? "double" : "double?";
                    case "TEXT": return "string";
                    case "BLOB": return "byte[]";
                    default: throw new NotImplementedException($"Invalid type.  The value: {type}");
                }
            }
        }
        public string ClrName
        {
            get
            {
                var ret = name;
                if (name.StartsWith("set_")) { ret = "Set_" + name.Substring(4); }
                if (name.StartsWith("get_")) { ret = "Get_" + name.Substring(4); }
                if (CSharpNotation.CSharpKeywords.Any(e => e == name)) { ret = "@" + name; }
                if (CSharpNotation.CSharpContextualKeywords.Any(e => e == name)) { ret = "@" + name; }
                return ret;
            }
        }
        public string PropertyString
        {
            get
            {
                var ret = $"public {ClrTypeAsString} {ClrName} {{ get; set; }}";
                return ret;
            }
        }
    }

    public class SQLiteTableInfo
    {
        public string SQLiteTableName { get; set; }
        public string ClrListObjectName
        {
            get
            {
                var ret = SQLiteTableName;
                if (CSharpNotation.CSharpKeywords.Any(e => e == SQLiteTableName)) { ret = "@" + SQLiteTableName; }
                if (CSharpNotation.CSharpContextualKeywords.Any(e => e == SQLiteTableName)) { ret = "@" + SQLiteTableName; }
                return ret;
            }
        }
        public string ClrClassName { get { return ClrListObjectName + "Record"; } }

        public List<SQLiteColumnInfo> ColumnInfoList { get; set; }

        public SQLiteTableInfo()
        {
            ColumnInfoList = new List<SQLiteColumnInfo>();
        }
    }
}
