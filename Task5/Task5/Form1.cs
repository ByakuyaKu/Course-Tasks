using java.awt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Task5
{
    public partial class Form1 : Form
    {
        private string dirrectoryPath;
        private string filePath;
        private FolderBrowserDialog browserDialog;
        private OpenFileDialog fileDialog;

        public Form1()
        {
            InitializeComponent();
            browserDialog = new FolderBrowserDialog();
            fileDialog = new OpenFileDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                dirrectoryPath = browserDialog.SelectedPath;
                LogFile.CreateLog(dirrectoryPath);
                Watch(dirrectoryPath);
            }

            else
                MessageBox.Show("Error");
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Текстовые файлы(*.txt)| *.txt";
            fileDialog.InitialDirectory = dirrectoryPath;

            if (fileDialog.ShowDialog() == DialogResult.OK)
                filePath = fileDialog.FileName;

            comboBox1.Items.AddRange(WorkWithJson.SelectVersion(filePath));
        }
        private void Watch(string path)
        {
            string[] subFolders = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            List<FileSystemWatcher> watcher = new List<FileSystemWatcher>();

            watcher.Add(new FileSystemWatcher(path));

            foreach (var item in subFolders)
            {
                watcher.Add(new FileSystemWatcher(item));
            }

            foreach (var item in watcher)
            {
                item.NotifyFilter = NotifyFilters.LastWrite;
                item.Filter = "*.txt";
                item.Changed += new FileSystemEventHandler(OnChanged);
                item.EnableRaisingEvents = true;
            }
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            BackUp.SaveChangesToLogFile(new Version(e.FullPath));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WorkWithJson.GoBackToVersion(filePath, comboBox1.SelectedItem.ToString());
        }
    }
}
