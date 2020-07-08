namespace CopyDirectory
{
    partial class Main
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
            this.btmOpenSrc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnTarget = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblProcentage = new System.Windows.Forms.Label();
            this.cbxFile = new System.Windows.Forms.CheckBox();
            this.cbxFolder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmOpenSrc
            // 
            this.btmOpenSrc.Location = new System.Drawing.Point(400, 17);
            this.btmOpenSrc.Name = "btmOpenSrc";
            this.btmOpenSrc.Size = new System.Drawing.Size(30, 23);
            this.btmOpenSrc.TabIndex = 0;
            this.btmOpenSrc.Text = "...";
            this.btmOpenSrc.UseVisualStyleBackColor = true;
            this.btmOpenSrc.Click += new System.EventHandler(this.btmOpenSrc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(77, 19);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(317, 20);
            this.txtSource.TabIndex = 3;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(77, 56);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(317, 20);
            this.txtTarget.TabIndex = 4;
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(400, 54);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(30, 23);
            this.btnTarget.TabIndex = 5;
            this.btnTarget.Text = "...";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblProcentage
            // 
            this.lblProcentage.AutoSize = true;
            this.lblProcentage.Location = new System.Drawing.Point(74, 91);
            this.lblProcentage.Name = "lblProcentage";
            this.lblProcentage.Size = new System.Drawing.Size(38, 13);
            this.lblProcentage.TabIndex = 8;
            this.lblProcentage.Text = "Ready";
            // 
            // cbxFile
            // 
            this.cbxFile.AutoSize = true;
            this.cbxFile.Checked = true;
            this.cbxFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFile.Location = new System.Drawing.Point(218, 115);
            this.cbxFile.Name = "cbxFile";
            this.cbxFile.Size = new System.Drawing.Size(42, 17);
            this.cbxFile.TabIndex = 9;
            this.cbxFile.Text = "File";
            this.cbxFile.UseVisualStyleBackColor = true;
            this.cbxFile.CheckedChanged += new System.EventHandler(this.cbxFile_CheckedChanged);
            // 
            // cbxFolder
            // 
            this.cbxFolder.AutoSize = true;
            this.cbxFolder.Location = new System.Drawing.Point(266, 115);
            this.cbxFolder.Name = "cbxFolder";
            this.cbxFolder.Size = new System.Drawing.Size(55, 17);
            this.cbxFolder.TabIndex = 10;
            this.cbxFolder.Text = "Folder";
            this.cbxFolder.UseVisualStyleBackColor = true;
            this.cbxFolder.CheckedChanged += new System.EventHandler(this.cbxFolder_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Copy options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 175);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxFolder);
            this.Controls.Add(this.cbxFile);
            this.Controls.Add(this.lblProcentage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmOpenSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyDirectory";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmOpenSrc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblProcentage;
        private System.Windows.Forms.CheckBox cbxFile;
        private System.Windows.Forms.CheckBox cbxFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

