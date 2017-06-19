namespace SkypeLogExport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using sds = System.Data.SQLite;

    public class SkypeLogExportModel
    {
        public string SkypeDataFolderPath { get; set; }
        public string SkypeMainDbFilePath { get; set; }
        public bool TryUpdateSkypeMainDbPath()
        {
            SkypeDataFolderPath = "";
            SkypeMainDbFilePath = "";
            string newSkypeDataFolderPath = "";
            if (false)
                newSkypeDataFolderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Skype");
            else
                newSkypeDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (System.IO.Directory.Exists(newSkypeDataFolderPath) == false) { return false; }
            SkypeDataFolderPath = newSkypeDataFolderPath;
            var mainDbPaths = System.IO.Directory.GetFiles(SkypeDataFolderPath, "main.db", System.IO.SearchOption.AllDirectories);
            if (mainDbPaths.Length == 0) { return false; }
            SkypeMainDbFilePath = mainDbPaths.FirstOrDefault();

            UpdateJsonDataString(SkypeMainDbFilePath);

            return true;
        }

        public string JsonDataString { get; private set; }
        public void UpdateJsonDataString(string dataBaseFilePath)
        {
            JsonDataString = "";

            using (var conn = new sds.SQLiteConnection("Data Source=" + dataBaseFilePath))
            {
                conn.Open();
                using (var context = new System.Data.Linq.DataContext(conn))
                {
                    var conversations = context.GetTable<Conversations>();
                    var messages = context.GetTable<Messages>();
                }
                conn.Close();
            }
        }
    }
}
