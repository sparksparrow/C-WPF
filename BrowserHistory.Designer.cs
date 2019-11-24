namespace Laba_2._0_WF_Zaur
{
    partial class BrowserHistory
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
            this.labelhistory = new System.Windows.Forms.Label();
            this.histories = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelhistory
            // 
            this.labelhistory.AutoSize = true;
            this.labelhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelhistory.Location = new System.Drawing.Point(12, 9);
            this.labelhistory.Name = "labelhistory";
            this.labelhistory.Size = new System.Drawing.Size(135, 31);
            this.labelhistory.TabIndex = 0;
            this.labelhistory.Text = "История: ";
            // 
            // histories
            // 
            this.histories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.histories.Location = new System.Drawing.Point(18, 43);
            this.histories.Multiline = true;
            this.histories.Name = "histories";
            this.histories.ReadOnly = true;
            this.histories.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.histories.Size = new System.Drawing.Size(1026, 626);
            this.histories.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1050, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(122, 50);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BrowserHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.histories);
            this.Controls.Add(this.labelhistory);
            this.Name = "BrowserHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowserHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelhistory;
        private System.Windows.Forms.TextBox histories;
        private System.Windows.Forms.Button exit;
    }
}