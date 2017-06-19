namespace SkypeLogExport
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

    public partial class SkypeLogExportMainWindow : Window
    {
        SkypeLogExportModel Model { get; set; }

        public SkypeLogExportMainWindow()
        {
            InitializeComponent();

            Model = new SkypeLogExportModel();
            this.DataContext = Model;

            Model.TryUpdateSkypeMainDbPath();

            SelectDbFileButton.Click += delegate
            {
                var ofd = new Microsoft.Win32.OpenFileDialog();
                Model.TryUpdateSkypeMainDbPath();
                ofd.InitialDirectory = Model.SkypeDataFolderPath;
                ofd.FileName = System.IO.Path.GetFileName(Model.SkypeMainDbFilePath);
                ofd.Filter = "SQLite DB File|*.db";
                ofd.DefaultExt = ".db";
                if (ofd.ShowDialog() != true) { return; }
                ofd.InitialDirectory = Model.SkypeDataFolderPath;
                Model.SkypeMainDbFilePath = ofd.FileName;
            };
        }
    }
}
