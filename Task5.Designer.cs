namespace Laba_2._0_WF_Zaur
{
    partial class Task5
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
            this.Digits = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // Digits
            // 
            this.Digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Digits.Location = new System.Drawing.Point(443, 310);
            this.Digits.Name = "Digits";
            this.Digits.Size = new System.Drawing.Size(743, 32);
            this.Digits.TabIndex = 0;
            this.Digits.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.Location = new System.Drawing.Point(659, 417);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(312, 81);
            this.find.TabIndex = 2;
            this.find.Text = "Find";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.Find_Click);
            // 
            // output
            // 
            this.output.ColumnCount = 1;
            this.output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.output.Dock = System.Windows.Forms.DockStyle.Left;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(0, 0);
            this.output.Name = "output";
            this.output.RowCount = 1;
            this.output.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.output.Size = new System.Drawing.Size(369, 681);
            this.output.TabIndex = 6;
            this.output.Paint += new System.Windows.Forms.PaintEventHandler(this.Output_Paint);
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.output);
            this.Controls.Add(this.find);
            this.Controls.Add(this.Digits);
            this.Name = "Task5";
            this.Text = "Task5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Digits;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TableLayoutPanel output;
    }
}