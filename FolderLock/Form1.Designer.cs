namespace FolderLock
{
    partial class FolderLock
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
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FolderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.passtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FolderPath
            // 
            this.FolderPath.BackColor = System.Drawing.Color.Black;
            this.FolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderPath.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderPath.ForeColor = System.Drawing.Color.SpringGreen;
            this.FolderPath.Location = new System.Drawing.Point(12, 12);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(352, 26);
            this.FolderPath.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(370, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passtext
            // 
            this.passtext.BackColor = System.Drawing.Color.Black;
            this.passtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.ForeColor = System.Drawing.Color.SpringGreen;
            this.passtext.Location = new System.Drawing.Point(12, 83);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(271, 26);
            this.passtext.TabIndex = 2;
            this.passtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passtext.UseSystemPasswordChar = true;
            this.passtext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passtext_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(289, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(370, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "Unlock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recent Folders";
            // 
            // folderList
            // 
            this.folderList.BackColor = System.Drawing.Color.Indigo;
            this.folderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderList.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderList.ForeColor = System.Drawing.Color.OrangeRed;
            this.folderList.FormattingEnabled = true;
            this.folderList.ItemHeight = 24;
            this.folderList.Location = new System.Drawing.Point(12, 146);
            this.folderList.Name = "folderList";
            this.folderList.Size = new System.Drawing.Size(433, 170);
            this.folderList.TabIndex = 7;
            this.folderList.SelectedIndexChanged += new System.EventHandler(this.folderList_SelectedIndexChanged);
            // 
            // FolderLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(457, 323);
            this.Controls.Add(this.folderList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FolderPath);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FolderLock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FolderLock";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowseDialog;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox folderList;
    }
}

