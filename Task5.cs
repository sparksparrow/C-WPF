using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2._0_WF_Zaur
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            output.AutoSize = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {         
            if (Digits.Text == "")
                return;

            output.Controls.Clear();
            output.RowCount = 0;
            output.ColumnCount = 0;
            

            List<String> digitsSTRING = new List<String>(Digits.Text.Split(' '));
            List<Int32> digits = new List<Int32>();
            for (int i = 0; i < digitsSTRING.Count; i++)
            {
                digits.Add(int.Parse(digitsSTRING[i]));
                if (digits[digits.Count - 1] < 100 || digits[digits.Count - 1] > 1000)
                    digits.RemoveAt(digits.Count - 1);
            }
           
            for (int i = 0; i < digits.Count; i++)
            {
                if (digits[i] % 7 != 0)
                    continue;
                int sumofdigit = 0;
                for (int j = 0; j < 3; j++)
                    sumofdigit += digits[i] % 10;
                if (sumofdigit % 7 != 0)
                    continue;
                output.RowCount++;
                Label label = new Label();
                label.Text = $"{digits[i]} ";
                if (i % 20 == 0)
                {
                    output.ColumnCount++;
                    output.RowCount = 0;
                }
                    output.Controls.Add(label, i/20, output.RowCount-1);                                
            }            
        }       

        private void Output_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawFocusRectangle(e.Graphics, e.ClipRectangle);
        }
    }
}

