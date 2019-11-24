namespace Laba_2._0_WF_Zaur
{
    partial class Task11
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.Work = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.js = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoSize = true;
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1043, 8);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(75, 15, 75, 15);
            this.Exit.Size = new System.Drawing.Size(209, 57);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(1, 71);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1251, 530);
            this.webBrowser.TabIndex = 8;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_UrlLoaded);
            // 
            // Work
            // 
            this.Work.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Work.AutoSize = true;
            this.Work.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Work.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Work.Location = new System.Drawing.Point(1000, 608);
            this.Work.Name = "Work";
            this.Work.Padding = new System.Windows.Forms.Padding(75, 15, 75, 15);
            this.Work.Size = new System.Drawing.Size(252, 65);
            this.Work.TabIndex = 9;
            this.Work.Text = "История";
            this.Work.UseVisualStyleBackColor = true;
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.back.AutoSize = true;
            this.back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(12, 608);
            this.back.Name = "back";
            this.back.Padding = new System.Windows.Forms.Padding(75, 15, 75, 15);
            this.back.Size = new System.Drawing.Size(228, 65);
            this.back.TabIndex = 10;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // forward
            // 
            this.forward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.forward.AutoSize = true;
            this.forward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forward.Location = new System.Drawing.Point(246, 608);
            this.forward.Name = "forward";
            this.forward.Padding = new System.Windows.Forms.Padding(75, 15, 75, 15);
            this.forward.Size = new System.Drawing.Size(240, 65);
            this.forward.TabIndex = 11;
            this.forward.Text = "Вперед";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // js
            // 
            this.js.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.js.AutoSize = true;
            this.js.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.js.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.js.Location = new System.Drawing.Point(733, 608);
            this.js.Name = "js";
            this.js.Padding = new System.Windows.Forms.Padding(75, 15, 75, 15);
            this.js.Size = new System.Drawing.Size(261, 65);
            this.js.TabIndex = 12;
            this.js.Text = "java-script";
            this.js.UseVisualStyleBackColor = true;
            this.js.Click += new System.EventHandler(this.Js_Click);
            // 
            // Task11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.js);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Work);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.Exit);
            this.Name = "Task11";
            this.Text = "Task11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button Work;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button js;
    }
}