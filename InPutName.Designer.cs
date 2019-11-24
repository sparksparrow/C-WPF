namespace Laba_2._0_WF_Zaur
{
    partial class InPutName
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
            this.next = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(489, 255);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(203, 54);
            this.next.TabIndex = 0;
            this.next.Text = "Продолжить";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.Next_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 255);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(203, 54);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(100, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(513, 38);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // InPutName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.next);
            this.Name = "InPutName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InPutName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox name;
    }
}