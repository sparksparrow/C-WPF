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
    public partial class Task9 : Form
    {
        List<String> files;
        readonly List<string> TypeOfImage = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG"};
        int count;
        bool exist;
        public Task9()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {           
            exist = false;
            count = 0;

            FolderBrowserDialog folder = new FolderBrowserDialog();            
            if (folder.ShowDialog() == DialogResult.OK)
            {
                try
                {                    
                    files = Directory.GetFiles(folder.SelectedPath).ToList();
                    for(int i = 0; i<files.Count;++i)
                    {
                        if (TypeOfImage.Contains(Path.GetExtension(files[i]).ToUpperInvariant()))
                        {
                            exist = true;   
                            next.Enabled = true;
                        }
                        else
                        {
                            files.RemoveAt(i);
                        }                        
                    }                     
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }

            }
            if(exist)
            {
                nubmer.Text = (count + 1).ToString();
                picture.Image = new Bitmap(files[0]);
                count++;
            }
            else
                MessageBox.Show("Картинок нет");
        }

        private void Next_Click(object sender, EventArgs e)
        {            
            if(count<files.Count)
            {
                nubmer.Text = (count + 1).ToString();
                picture.Image.Dispose();
                picture.Image = new Bitmap(files[count]);
                count++;
            }
            else
            {
                count = 0;
                nubmer.Text = (count+1).ToString();
                picture.Image.Dispose();
                picture.Image = new Bitmap(files[count]);
                count++;
            }
        }
    }
}
