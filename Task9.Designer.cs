namespace Laba_2._0_WF_Zaur
{
    partial class Task9
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
            this.Exit = new System.Windows.Forms.Button();
            this.OpenImage = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.nubmer = new System.Windows.Forms.Label();
            this.usuallyText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1381, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 53);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenImage.Location = new System.Drawing.Point(1234, 781);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(338, 68);
            this.OpenImage.TabIndex = 8;
            this.OpenImage.Text = "Выбрать папку";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1280, 720);
            this.picture.TabIndex = 9;
            this.picture.TabStop = false;
            // 
            // next
            // 
            this.next.Enabled = false;
            this.next.Location = new System.Drawing.Point(1348, 342);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(191, 53);
            this.next.TabIndex = 10;
            this.next.Text = "Следущая";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.Next_Click);
            // 
            // nubmer
            // 
            this.nubmer.AutoSize = true;
            this.nubmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nubmer.Location = new System.Drawing.Point(179, 735);
            this.nubmer.Name = "nubmer";
            this.nubmer.Size = new System.Drawing.Size(0, 31);
            this.nubmer.TabIndex = 11;
            // 
            // usuallyText
            // 
            this.usuallyText.AutoSize = true;
            this.usuallyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usuallyText.Location = new System.Drawing.Point(12, 735);
            this.usuallyText.Name = "usuallyText";
            this.usuallyText.Size = new System.Drawing.Size(167, 31);
            this.usuallyText.TabIndex = 12;
            this.usuallyText.Text = "Картинка №";
            // 
            // Task9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.usuallyText);
            this.Controls.Add(this.nubmer);
            this.Controls.Add(this.next);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.Exit);
            this.Name = "Task9";
            this.Text = "Task9";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label nubmer;
        private System.Windows.Forms.Label usuallyText;
    }
}