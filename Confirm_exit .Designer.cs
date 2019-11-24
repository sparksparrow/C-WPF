namespace Laba_2._0_WF_Zaur
{
    partial class Confirm_exit
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
            this.cancel = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.text_confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(66, 78);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(147, 54);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(259, 78);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(147, 54);
            this.exit.TabIndex = 1;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // text_confirm
            // 
            this.text_confirm.AutoSize = true;
            this.text_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_confirm.Location = new System.Drawing.Point(146, 24);
            this.text_confirm.Name = "text_confirm";
            this.text_confirm.Size = new System.Drawing.Size(179, 26);
            this.text_confirm.TabIndex = 2;
            this.text_confirm.Text = "Уверены ли вы?";
            // 
            // Confirm_exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 181);
            this.Controls.Add(this.text_confirm);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.cancel);
            this.Name = "Confirm_exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm_exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label text_confirm;
    }
}