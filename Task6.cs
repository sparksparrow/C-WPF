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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Input.Text == "")
                return;
            foreach (char one in Input.Text)
                if ((int)one < 48 || (int)one > 57)
                    return;
            int digit = int.Parse(Input.Text);
            List<int> digits = new List<int>();
            while (digit != 0)
            {
                digits.Add(digit % 10);
                digit /= 10;
            }
            for (int i = 0; i < digits.Count; i++)
            
                if (digits[i]!= digits[digits.Count - i - 1])
            {
                MessageBox.Show("Не является палиндромом!");
                return;
            }
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = ".txt";
            savefile.Filter = "(.txt)|*.txt";
            if (savefile.ShowDialog() == DialogResult.OK)
                File.WriteAllText(savefile.FileName, $"{Input.Text} является палиндромом!");
        }
                
    }
}
