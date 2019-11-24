namespace Laba_2._0_WF_Zaur
{
    partial class Task6
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Define = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(266, 341);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(683, 32);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Define
            // 
            this.Define.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Define.Location = new System.Drawing.Point(426, 449);
            this.Define.Name = "Define";
            this.Define.Size = new System.Drawing.Size(377, 109);
            this.Define.TabIndex = 1;
            this.Define.Text = "Define";
            this.Define.UseVisualStyleBackColor = true;
            this.Define.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Define);
            this.Controls.Add(this.Input);
            this.Name = "Task6";
            this.Text = "Task6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Define;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}