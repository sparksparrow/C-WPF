using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2._0_WF_Zaur
{
    public partial class Task10 : Form
    {
        List<String> FilesInDirectory;
        List<String> Directories;
        
        void fill(string path, bool notfirst)
        {
            files.Clear();
            if (notfirst)
            {
                FilesInDirectory = Directory.GetDirectories(path).ToList();
                foreach (string f in FilesInDirectory)
                {
                    files.AppendText($"{f.Replace(path + "\\", "")} \r\n");
                }
                FilesInDirectory = Directory.GetFiles(path).ToList();
                foreach (string f in FilesInDirectory)
                {
                    files.AppendText($"{f.Replace(path + "\\", "")} \r\n");
                }
            }
            else
            {
                FilesInDirectory = Directory.GetDirectories(path).ToList();
                foreach (string f in FilesInDirectory)
                {
                    files.AppendText($"{f.Replace(path, "")} \r\n");
                }
                FilesInDirectory = Directory.GetFiles(path).ToList();
                foreach (string f in FilesInDirectory)
                {
                    files.AppendText($"{f.Replace(path, "")} \r\n");
                }
            }
        }
        public Task10()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {            
            FolderBrowserDialog reader = new FolderBrowserDialog();
            if (reader.ShowDialog() == DialogResult.OK)
            {                
                try
                {
                    directories.Text = reader.SelectedPath;                   
                    Directories = reader.SelectedPath.Split('\\').ToList();
                    fill(reader.SelectedPath, true);
                    previous.Enabled = true;
                    addDir.Enabled = true;
                    addFile.Enabled = true;
                    delete.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }
        private void Previous_Click(object sender, EventArgs e)
        {
                      
            Directories.RemoveAt(Directories.Count - 1);
            StringBuilder newpath = new StringBuilder();
            foreach (string dir in Directories)
                newpath.Append($"{dir}\\");
            directories.Text = newpath.ToString();
            try
            {
                fill(newpath.ToString(),false);
            }
            catch
            {
                MessageBox.Show("Ошибка. Достигнут лимит!");
                previous.Enabled = false;
                addDir.Enabled = false;
                addFile.Enabled = false;
                delete.Enabled = false;
            }
        }
        private void AddDir_Click(object sender, EventArgs e)
        {
            try
            {
                InPutName inPut = new InPutName();
                inPut.ShowDialog();
                if (inPut.status_exit)
                {
                    StringBuilder newpath = new StringBuilder();
                    foreach (string dir in Directories)
                        newpath.Append(dir + @"\");
                    newpath.Append(inPut.deletename);                    
                    DirectoryInfo newdir = new DirectoryInfo(newpath.ToString());
                    if (!newdir.Exists)
                        newdir.Create();
                    newpath.Replace(inPut.deletename, "");
                    inPut.deletename = null;
                    fill(newpath.ToString(), false);
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            try
            {
                InPutName inPut = new InPutName();
                inPut.ShowDialog();
                if (inPut.status_exit)
                {
                    StringBuilder newpath = new StringBuilder();
                    foreach (string dir in Directories)
                        newpath.Append(dir + @"\");
                    newpath.Append(inPut.deletename);
                    if (!File.Exists(newpath.ToString()))
                    {
                        var newfile = File.Create(newpath.ToString());
                        newfile.Close();
                    }                        
                    newpath.Replace(inPut.deletename, "");
                    inPut.deletename = null;
                    fill(newpath.ToString(), false);
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                InPutName inPut = new InPutName();
                inPut.ShowDialog();
                if (inPut.status_exit)
                {
                    StringBuilder newpath = new StringBuilder();
                    foreach (string dir in Directories)
                        newpath.Append(dir + @"\");
                    newpath.Append(inPut.deletename);
                    if (Directory.Exists(newpath.ToString()))
                        Directory.Delete(newpath.ToString(), false);
                    else
                        if (File.Exists(newpath.ToString()))
                        File.Delete(newpath.ToString());
                    else
                        MessageBox.Show("Данного объекта не существует!");
                    newpath.Replace(inPut.deletename, "");
                    inPut.deletename = null;
                    fill(newpath.ToString(), false);
                }
            else
                return;
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }                
    }
}
