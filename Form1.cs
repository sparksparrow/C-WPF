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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.MaximizeBox = false;
            task1.MinimizeBox = false;
            task1.ShowDialog();
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.MaximizeBox = false;
            task2.MinimizeBox = false;
            task2.ShowDialog();
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.MaximizeBox = false;
            task3.MinimizeBox = false;
            task3.ShowDialog();
        }

        private void Task4_Click(object sender, EventArgs e)
        {
            Task4 task4 = new Task4();
            task4.MaximizeBox = false;
            task4.MinimizeBox = false;
            task4.ShowDialog();
        }

        private void Task5_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            task5.MaximizeBox = false;
            task5.MinimizeBox = false;
            task5.ShowDialog();
        }

        private void Task6_Click(object sender, EventArgs e)
        {
            Task6 task6 = new Task6();
            task6.MaximizeBox = false;
            task6.MinimizeBox = false;
            task6.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Task7_Click(object sender, EventArgs e)
        {
            Task7 task7 = new Task7();
            task7.MaximizeBox = false;
            task7.MinimizeBox = false;
            task7.ShowDialog();
        }

        private void Task8_Click(object sender, EventArgs e)
        {
            Task8 task8 = new Task8();
            task8.ShowDialog();
        }

        private void Task9_Click(object sender, EventArgs e)
        {
            Task9 task9 = new Task9();
            task9.ShowDialog();
        }

        private void Task10_Click(object sender, EventArgs e)
        {
            Task10 task10 = new Task10();
            task10.ShowDialog();
        }

        private void Task11_Click(object sender, EventArgs e)
        {
            Task11 task11 = new Task11();
            task11.ShowDialog();
        }

        private void Task12_Click(object sender, EventArgs e)
        {
            Task12 task12 = new Task12();
            task12.ShowDialog();
        }
    }
}
