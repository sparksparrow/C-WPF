namespace Laba_2._0_WF_Zaur
{
    partial class Task8
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
            this.Start = new System.Windows.Forms.Button();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.quastions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1061, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 53);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(436, 561);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(346, 94);
            this.Start.TabIndex = 8;
            this.Start.Text = "Начать игру";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // answer1
            // 
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1.Location = new System.Drawing.Point(167, 357);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(342, 65);
            this.answer1.TabIndex = 9;
            this.answer1.UseVisualStyleBackColor = true;
            this.answer1.Visible = false;
            this.answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // answer2
            // 
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2.Location = new System.Drawing.Point(167, 466);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(342, 65);
            this.answer2.TabIndex = 10;
            this.answer2.UseVisualStyleBackColor = true;
            this.answer2.Visible = false;
            this.answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // answer3
            // 
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer3.Location = new System.Drawing.Point(731, 357);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(342, 65);
            this.answer3.TabIndex = 11;
            this.answer3.UseVisualStyleBackColor = true;
            this.answer3.Visible = false;
            this.answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // answer4
            // 
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer4.Location = new System.Drawing.Point(731, 466);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(342, 65);
            this.answer4.TabIndex = 12;
            this.answer4.UseVisualStyleBackColor = true;
            this.answer4.Visible = false;
            this.answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // quastions
            // 
            this.quastions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quastions.Location = new System.Drawing.Point(167, 228);
            this.quastions.Name = "quastions";
            this.quastions.Size = new System.Drawing.Size(906, 98);
            this.quastions.TabIndex = 13;
            this.quastions.Text = "...";
            this.quastions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quastions.Visible = false;
            this.quastions.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Task8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.quastions);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Exit);
            this.Name = "Task8";
            this.Text = "Task8";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Label quastions;
    }
}