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
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba_2._0_WF_Zaur
{
    public partial class Task12 : Form
    {
        int x;
        
        public Task12()
        {
            InitializeComponent();                     
            predict.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }       
        private void Predict_Click(object sender, EventArgs e)
        {
            earthquake.ChartAreas[0].AxisX.Maximum +=12;
            Random rand = new Random();
            double lastvalue = earthquake.Series[0].Points[earthquake.Series[0].Points.Count - 1].YValues[0];
            double newdigit = (double)rand.Next() % 9.5;
            double step = ((newdigit - lastvalue)) / 12;
            
            if (step < 0)
                for (int Ix = x; Ix < x + 12; ++Ix)
                {
                    lastvalue += step;
                    earthquake.Series[0].Points.AddXY(Ix, lastvalue);                   
                }
            else
                    if (step > 0)
                for (int Ix = x; Ix < x + 12; ++Ix)
                {
                    lastvalue += step;
                    earthquake.Series[0].Points.AddXY(Ix, lastvalue);                   
                }
            else
                for (int Ix = x; Ix < x + 12; ++Ix)
                {
                    earthquake.Series[0].Points.AddXY(Ix, lastvalue);
                }
            x += 12;
        }
        private void readfile_Click(object sender, EventArgs e)
        {
            earthquake.Series[0].Points.Clear();            

            x = 0;
            string file_name = "Earthquake results.txt";
            int end = 0;
            using (StreamReader sr = new StreamReader(file_name))
            {
                while (sr.ReadLine() != null)
                    end++;
            }
            
            earthquake.ChartAreas[0].AxisX.Maximum = (end-1)*12;            
            using (StreamReader sr = new StreamReader(file_name))
            {
                double first = double.Parse(sr.ReadLine());
                
                for (int i = 0; i < end-1; ++i)
                {   
                    double lastRead = double.Parse(sr.ReadLine());                    
                    double step = (lastRead - first) / 12;                  
                    double resultStep = first;
                    if(step<0)
                    for (int Ix = x; Ix < x + 12; ++Ix)
                    {
                        earthquake.Series[0].Points.AddXY(Ix, resultStep);
                            resultStep += step;
                        }
                    else
                    if(step>0)
                        for (int Ix = x; Ix < x + 12; ++Ix)
                        {
                            earthquake.Series[0].Points.AddXY(Ix, resultStep);
                            resultStep += step;
                        }
                    else
                        for (int Ix = x; Ix < x + 12; ++Ix)
                        {
                            earthquake.Series[0].Points.AddXY(Ix, resultStep);
                        }
                    x +=12;                    
                   first = lastRead;
                    if ((end - 1) - i == 1)
                    {
                        earthquake.Series[0].Points.AddXY(x, lastRead);
                        x++;
                    }
                    }
            }
            predict.Enabled = true;
        }
    }
}

