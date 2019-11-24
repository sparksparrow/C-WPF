using System.Drawing;

namespace Laba_2._0_WF_Zaur
{
    partial class Task12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Exit = new System.Windows.Forms.Button();
            this.predict = new System.Windows.Forms.Button();
            this.earthquake = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.readfile = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.earthquake)).BeginInit();
            this.SuspendLayout();
            MinimumSize = new Size(1000, 500);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1061, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 53);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // predict
            // 
            this.predict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.predict.AutoSize = true;
            this.predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predict.Location = new System.Drawing.Point(984, 602);
            this.predict.Name = "predict";
            this.predict.Size = new System.Drawing.Size(268, 67);
            this.predict.TabIndex = 8;
            this.predict.Text = "Предсказать";
            this.predict.UseVisualStyleBackColor = true;
            this.predict.Click += new System.EventHandler(this.Predict_Click);
            // 
            // earthquake
            // 
            this.earthquake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.earthquake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.earthquake.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.Title = "Месяцы";
            chartArea1.AxisX2.Title = "Магнитуда";
            chartArea1.Name = "ChartArea1";
            this.earthquake.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.earthquake.Legends.Add(legend1);
            this.earthquake.Location = new System.Drawing.Point(12, 12);
            this.earthquake.Name = "earthquake";
            this.earthquake.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.earthquake.Series.Add(series1);
            this.earthquake.Size = new System.Drawing.Size(1043, 584);
            this.earthquake.TabIndex = 9;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            title1.Name = "Title1";
            title1.Text = "Землятрясение";
            this.earthquake.Titles.Add(title1);
            earthquake.ChartAreas[0].CursorX.IsUserEnabled = true;
            earthquake.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            earthquake.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            earthquake.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            earthquake.ChartAreas[0].AxisX.Title = "Месяцы";
            earthquake.ChartAreas[0].AxisY.Title = "Магнитуда";
            earthquake.ChartAreas[0].AxisX.Interval = 12;
            earthquake.ChartAreas[0].AxisY.Interval = 0.5;
            earthquake.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            earthquake.Series[0].Color = Color.Red;
            earthquake.Series[0].LegendText = "Магнитуда землетрясения";
            earthquake.ChartAreas[0].AxisX.Minimum = 0;
            earthquake.ChartAreas[0].AxisY.Maximum = 9.5;
            earthquake.ChartAreas[0].AxisY.Minimum = 0;
            // 
            // readfile
            // 
            this.readfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readfile.AutoSize = true;
            this.readfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readfile.Location = new System.Drawing.Point(12, 602);
            this.readfile.Name = "readfile";
            this.readfile.Size = new System.Drawing.Size(268, 67);
            this.readfile.TabIndex = 10;
            this.readfile.Text = "Считать файл";
            this.readfile.UseVisualStyleBackColor = true;
            this.readfile.Click += new System.EventHandler(this.readfile_Click);
            // 
            // Task12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.readfile);
            this.Controls.Add(this.earthquake);
            this.Controls.Add(this.predict);
            this.Controls.Add(this.Exit);
            this.Name = "Task12";
            this.Text = "Task12";
            ((System.ComponentModel.ISupportInitialize)(this.earthquake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button predict;
        private System.Windows.Forms.DataVisualization.Charting.Chart earthquake;
        private System.Windows.Forms.Button readfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}