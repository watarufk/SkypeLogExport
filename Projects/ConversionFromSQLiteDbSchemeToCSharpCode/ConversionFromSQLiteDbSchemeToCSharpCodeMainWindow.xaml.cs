namespace ConversionFromSQLiteDbSchemeToCSharpCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    public partial class ConversionFromSQLiteDbSchemeToCSharpCodeMainWindow : Window
    {
        ConversionFromSQLiteDbSchemeToCSharpCodeModel Model { get; set; }

        public ConversionFromSQLiteDbSchemeToCSharpCodeMainWindow()
        {
            InitializeComponent();

            Model = new ConversionFromSQLiteDbSchemeToCSharpCodeModel();
            this.DataContext = Model;

            SelectDbFileButton.Click += delegate
            {
                var ofd = new Microsoft.Win32.OpenFileDialog();
                ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Filter = "SQLite DB File|*.db";
                ofd.DefaultExt = ".db";
                if (ofd.ShowDialog() != true) { return; }
                Model.DataBaseFilePath = ofd.FileName;
            };

            SaveCodeButton.Click += delegate
            {
                var sfd = new Microsoft.Win32.SaveFileDialog();
                sfd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.Filter = "CSharp Source File|*.cs";
                sfd.DefaultExt = ".cs";
                sfd.FileName = Model.DataSetClassName + ".cs";
                if (sfd.ShowDialog() != true) { return; }
                System.IO.File.WriteAllText(sfd.FileName, Model.ConversionResult);
            };
        }
    }
}
