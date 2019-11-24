namespace Laba_2._0_WF_Zaur
{
    partial class Task7
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Exit = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TableLayoutPanel();
            this.readfile = new System.Windows.Forms.Button();
            this.writefile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1061, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 53);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // output
            // 
            this.output.AutoScroll = true;
            this.output.AutoSize = true;
            this.output.ColumnCount = 5;
            this.output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.RowCount = 1;
            this.output.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.output.Size = new System.Drawing.Size(1031, 575);
            this.output.TabIndex = 8;
            this.output.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // readfile
            // 
            this.readfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readfile.Location = new System.Drawing.Point(1061, 162);
            this.readfile.Name = "readfile";
            this.readfile.Size = new System.Drawing.Size(191, 53);
            this.readfile.TabIndex = 9;
            this.readfile.Text = "Считать файл";
            this.readfile.UseVisualStyleBackColor = true;
            this.readfile.Click += new System.EventHandler(this.Readfile_Click);
            // 
            // writefile
            // 
            this.writefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writefile.Location = new System.Drawing.Point(1061, 321);
            this.writefile.Name = "writefile";
            this.writefile.Size = new System.Drawing.Size(191, 73);
            this.writefile.TabIndex = 10;
            this.writefile.Text = "Записать в файл";
            this.writefile.UseVisualStyleBackColor = true;
            this.writefile.Click += new System.EventHandler(this.Writefile_Click);
            // 
            // Task7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.writefile);
            this.Controls.Add(this.readfile);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Exit);
            this.Name = "Task7";
            this.Text = "Task7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TableLayoutPanel output;
        private System.Windows.Forms.Button readfile;
        private System.Windows.Forms.Button writefile;
    }
}