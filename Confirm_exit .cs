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
    public partial class Confirm_exit : Form
    {
        public bool status_exit { get; private set; }
        public Confirm_exit()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            status_exit = true;
            Close();
        }
    }
}
