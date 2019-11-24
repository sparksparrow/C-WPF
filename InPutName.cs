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
    public partial class InPutName : Form
    {
        public bool status_exit { get; private set; }
        public string deletename;
        public InPutName()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            deletename = name.Text;
            status_exit = true;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            status_exit = false;
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
