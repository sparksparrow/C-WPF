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
    public partial class BrowserHistory : Form
    {
        public BrowserHistory(List<string> History)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            MaximizeBox = false;
            foreach (string str in History)
                histories.AppendText($"{str}\r\n");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
