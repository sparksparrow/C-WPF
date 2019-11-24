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
   
    public partial class Task7 : Form
    {
        private bool b = true;                  //чтобы случайно не записать в файл пустые строчки
        public Task7()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;            
            output.AutoSize = true;
            Autofill();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Confirm_exit confirm_Exit = new Confirm_exit();
            confirm_Exit.MaximizeBox = false;
            confirm_Exit.MinimizeBox = false;
            confirm_Exit.ShowDialog();
            if (confirm_Exit.status_exit)
                Close();
        }

        private void Readfile_Click(object sender, EventArgs e)
        {

            Autofill();
            string file_name = "Students.txt";          
            int end = 0;
            using (StreamReader sr = new StreamReader(file_name))
            {
                while (sr.ReadLine() != null)
                    end++;
            }            
            using (StreamReader sr = new StreamReader(file_name))
            {
                
                int column = 0;
                int row = 0;
               for(int i = 0; i<end;i++)
                {                        
                    TextBox textbox = new TextBox();                    
                    textbox.Font = new Font( "",12, FontStyle.Regular);                    
                    if (column % 5 == 0)
                    {
                        row++;
                        textbox.Width = 300;
                    }
                        textbox.Text = $"{sr.ReadLine()} ";                    
                    output.Controls.Add(textbox, column%5,row);                    
                    column++;                    
                }
            }
            b = false;
        }
        public void Autofill()
        {
            output.Controls.Clear();
            output.RowCount = 1;
            output.ColumnCount = 5;
            Label label1 = new Label();
            label1.Text = "ФИО";
            output.Controls.Add(label1, 0, 0);
            Label label2 = new Label();
            label2.Text = "Возраст";
            output.Controls.Add(label2, 1, 0);
            Label label3 = new Label();
            label3.Text = "Пол";
            output.Controls.Add(label3, 2, 0);
            Label label4 = new Label();
            label4.Text = "Специальность";
            output.Controls.Add(label4, 3, 0);
            Label label5 = new Label();
            label5.Text = "Курc";
            output.Controls.Add(label5, 4, 0);

        }
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Writefile_Click(object sender, EventArgs e)
        {
            if (b)
                return;
            string file_name = "Students.txt";                    
            using (StreamWriter sr = new StreamWriter(file_name))
            {
                for (int i = 5; i<output.Controls.Count;++i)
                {
                    sr.WriteLine(output.Controls[i].Text);
                }

            }
        }
    }
}
