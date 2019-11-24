using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2._0_WF_Zaur
{
    public partial class Task8 : Form
    {        
        bool ans1;
        bool ans2;
        bool ans3;
        bool ans4;
        bool game;
        int count;
        bool wait;
        int CountOfTheQuastions;
        Random rand = new Random();
        int status_read;
        Thread start_game;
        
        public void createThreadgame()
        {
            start_game = new Thread(() =>
            {
                BeginInvoke((MethodInvoker)(() => Start.Visible = false));
                ans1 = false;
                ans2 = false;
                ans3 = false;
                ans4 = false;
                count = 0;
                game = true;
                status_read = 0;
                string file_name = "Question.txt";
                int end = 0;
                List<String> text = new List<string>();

                using (StreamReader sr = new StreamReader(file_name))
                {
                    while (sr.ReadLine() != null)
                        end++;
                }
                using (StreamReader sr = new StreamReader(file_name))
                {
                    for (int i = 0; i < end; ++i)
                        text.Add(sr.ReadLine());

                }
                CountOfTheQuastions = text.Count / 5;

                BeginInvoke((MethodInvoker)(() => answer1.Visible = true));
                BeginInvoke((MethodInvoker)(() => answer2.Visible = true));
                BeginInvoke((MethodInvoker)(() => answer3.Visible = true));
                BeginInvoke((MethodInvoker)(() => answer4.Visible = true));
                BeginInvoke((MethodInvoker)(() => quastions.Visible = true));
                while (game)
                {
                    wait = true;
                    int right_answer = rand.Next(1, 4);
                    switch (right_answer)
                    {
                        case 1:
                            BeginInvoke((MethodInvoker)(() => quastions.Text = text[status_read]));
                            BeginInvoke((MethodInvoker)(() => answer1.Text = text[status_read + 1]));
                            BeginInvoke((MethodInvoker)(() => answer2.Text = text[status_read + 2]));
                            BeginInvoke((MethodInvoker)(() => answer3.Text = text[status_read + 3]));
                            BeginInvoke((MethodInvoker)(() => answer4.Text = text[status_read + 4]));
                            ans1 = true;
                            while (wait) ;
                            break;
                        case 2:
                            BeginInvoke((MethodInvoker)(() => quastions.Text = text[status_read]));
                            BeginInvoke((MethodInvoker)(() => answer2.Text = text[status_read + 1]));
                            BeginInvoke((MethodInvoker)(() => answer1.Text = text[status_read + 2]));
                            BeginInvoke((MethodInvoker)(() => answer3.Text = text[status_read + 3]));
                            BeginInvoke((MethodInvoker)(() => answer4.Text = text[status_read + 4]));
                            ans2 = true;
                            while (wait) ;
                            break;
                        case 3:
                            BeginInvoke((MethodInvoker)(() => quastions.Text = text[status_read]));
                            BeginInvoke((MethodInvoker)(() => answer3.Text = text[status_read + 1]));
                            BeginInvoke((MethodInvoker)(() => answer1.Text = text[status_read + 2]));
                            BeginInvoke((MethodInvoker)(() => answer2.Text = text[status_read + 3]));
                            BeginInvoke((MethodInvoker)(() => answer4.Text = text[status_read + 4]));
                            ans3 = true;
                            while (wait) ;
                            break;

                        case 4:
                            BeginInvoke((MethodInvoker)(() => quastions.Text = text[status_read]));
                            BeginInvoke((MethodInvoker)(() => answer4.Text = text[status_read + 1]));
                            BeginInvoke((MethodInvoker)(() => answer1.Text = text[status_read + 2]));
                            BeginInvoke((MethodInvoker)(() => answer2.Text = text[status_read + 3]));
                            BeginInvoke((MethodInvoker)(() => answer3.Text = text[status_read + 4]));
                            ans4 = true;
                            while (wait) ;
                            break;
                        default:
                            return;
                    }
                }
                BeginInvoke((MethodInvoker)(() => answer1.Visible = false));
                BeginInvoke((MethodInvoker)(() => answer2.Visible = false));
                BeginInvoke((MethodInvoker)(() => answer3.Visible = false));
                BeginInvoke((MethodInvoker)(() => answer4.Visible = false));
                BeginInvoke((MethodInvoker)(() => quastions.Visible = false));
                BeginInvoke((MethodInvoker)(() => Start.Visible = true));
            });
        }
        public Task8()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;           
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            createThreadgame();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (start_game.IsAlive == true)
                start_game.Abort();
            Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            createThreadgame();          
            start_game.Start();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Answer1_Click(object sender, EventArgs e)
        {            
            if (ans1)
                count++;
            else
            {
                game = false;
                MessageBox.Show($"Ответ неверный! Количетсво правильных ответов: {count}.");                
            }
            ans1 = false;
            wait = false;
            status_read += 5;
            if (count == CountOfTheQuastions)
            {
                game = false;
                MessageBox.Show($"Вы ответили на все вопросы! Всего было {count} вопросов!");
            }
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            if (ans2)
                count++;
            else
            {
                game = false;
                MessageBox.Show($"Ответ неверный! Количетсво правильных ответов: {count}.");         
            }
            ans2 = false;
            wait = false;
            status_read += 5;
            if (count == CountOfTheQuastions)
            {
                game = false;
                MessageBox.Show($"Вы ответили на все вопросы! Всего было {count} вопросов!");
            }
        }
        private void Answer3_Click(object sender, EventArgs e)
        {
            if (ans3)
                count++;
            else
            {
                game = false;
                MessageBox.Show($"Ответ неверный! Количетсво правильных ответов: {count}.");       
            }
            ans3 = false;
            wait = false;
            status_read += 5;
            if (count == CountOfTheQuastions)
            {
                game = false;
                MessageBox.Show($"Вы ответили на все вопросы! Всего было {count} вопросов!");
            }
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            if (ans4)
                count++;
            else
            {
                game = false;
                MessageBox.Show($"Ответ неверный! Количетсво правильных ответов: {count}.");                
            }
            ans4 = false;
            wait = false;
            status_read += 5;
            if (count == CountOfTheQuastions)
            {
                game = false;
                MessageBox.Show($"Вы ответили на все вопросы! Всего было {count} вопросов!");
            }
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (start_game.IsAlive == true)
                start_game.Abort();
        }
    }
}
