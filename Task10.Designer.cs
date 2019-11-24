namespace Laba_2._0_WF_Zaur
{
    partial class Task10
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
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.addFile = new System.Windows.Forms.Button();
            this.addDir = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.TextBox();
            this.directories = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(1062, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(190, 51);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(1025, 118);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(227, 62);
            this.delete.TabIndex = 1;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // addFile
            // 
            this.addFile.Enabled = false;
            this.addFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFile.Location = new System.Drawing.Point(764, 225);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(227, 62);
            this.addFile.TabIndex = 2;
            this.addFile.Text = "Добавить файл";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // addDir
            // 
            this.addDir.Enabled = false;
            this.addDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDir.Location = new System.Drawing.Point(764, 118);
            this.addDir.Name = "addDir";
            this.addDir.Size = new System.Drawing.Size(227, 62);
            this.addDir.TabIndex = 3;
            this.addDir.Text = "Добавить каталог";
            this.addDir.UseVisualStyleBackColor = true;
            this.addDir.Click += new System.EventHandler(this.AddDir_Click);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open.Location = new System.Drawing.Point(1025, 607);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(227, 62);
            this.open.TabIndex = 4;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // files
            // 
            this.files.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.files.Location = new System.Drawing.Point(31, 46);
            this.files.Multiline = true;
            this.files.Name = "files";
            this.files.ReadOnly = true;
            this.files.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.files.Size = new System.Drawing.Size(727, 623);
            this.files.TabIndex = 5;
            // 
            // directories
            // 
            this.directories.AutoSize = true;
            this.directories.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directories.Location = new System.Drawing.Point(81, 12);
            this.directories.Name = "directories";
            this.directories.Size = new System.Drawing.Size(0, 31);
            this.directories.TabIndex = 6;
            // 
            // previous
            // 
            this.previous.Enabled = false;
            this.previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previous.Location = new System.Drawing.Point(764, 478);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(227, 62);
            this.previous.TabIndex = 7;
            this.previous.Text = "Предыдущий каталог";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Task10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.directories);
            this.Controls.Add(this.files);
            this.Controls.Add(this.open);
            this.Controls.Add(this.addDir);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.exit);
            this.Name = "Task10";
            this.Text = "Task10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Button addDir;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox files;
        private System.Windows.Forms.Label directories;
        private System.Windows.Forms.Button previous;
    }
}