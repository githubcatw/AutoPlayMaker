﻿namespace AutoplayCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.compile = new System.Windows.Forms.Button();
            this.openIcon = new System.Windows.Forms.OpenFileDialog();
            this.openExe = new System.Windows.Forms.OpenFileDialog();
            this.content = new System.Windows.Forms.TabPage();
            this.video = new System.Windows.Forms.RadioButton();
            this.music = new System.Windows.Forms.RadioButton();
            this.picture = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.compileContent = new System.Windows.Forms.CheckBox();
            this.diskname = new System.Windows.Forms.TabPage();
            this.pickExe = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.whitelist = new System.Windows.Forms.TabPage();
            this.valueToAddToList = new System.Windows.Forms.TextBox();
            this.wbList = new System.Windows.Forms.ListBox();
            this.compileList = new System.Windows.Forms.CheckBox();
            this.black = new System.Windows.Forms.RadioButton();
            this.white = new System.Windows.Forms.RadioButton();
            this.help = new System.Windows.Forms.TabPage();
            this.fork = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveAutorun = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.content.SuspendLayout();
            this.diskname.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.whitelist.SuspendLayout();
            this.help.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // compile
            // 
            this.compile.Location = new System.Drawing.Point(13, 422);
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(338, 23);
            this.compile.TabIndex = 0;
            this.compile.Text = "Compile";
            this.compile.UseVisualStyleBackColor = true;
            this.compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // openIcon
            // 
            this.openIcon.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenIcon_FileOk);
            // 
            // content
            // 
            this.content.Controls.Add(this.video);
            this.content.Controls.Add(this.music);
            this.content.Controls.Add(this.picture);
            this.content.Controls.Add(this.label1);
            this.content.Controls.Add(this.compileContent);
            this.content.Location = new System.Drawing.Point(4, 22);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(330, 378);
            this.content.TabIndex = 1;
            this.content.Text = "Content";
            this.content.UseVisualStyleBackColor = true;
            // 
            // video
            // 
            this.video.AutoSize = true;
            this.video.Enabled = false;
            this.video.Location = new System.Drawing.Point(10, 99);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(52, 17);
            this.video.TabIndex = 6;
            this.video.TabStop = true;
            this.video.Text = "Video";
            this.video.UseVisualStyleBackColor = true;
            // 
            // music
            // 
            this.music.AutoSize = true;
            this.music.Enabled = false;
            this.music.Location = new System.Drawing.Point(10, 76);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(53, 17);
            this.music.TabIndex = 5;
            this.music.TabStop = true;
            this.music.Text = "Music";
            this.music.UseVisualStyleBackColor = true;
            // 
            // picture
            // 
            this.picture.AutoSize = true;
            this.picture.Enabled = false;
            this.picture.Location = new System.Drawing.Point(10, 53);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(58, 17);
            this.picture.TabIndex = 4;
            this.picture.TabStop = true;
            this.picture.Text = "Picture";
            this.picture.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Content type:";
            // 
            // compileContent
            // 
            this.compileContent.AutoSize = true;
            this.compileContent.Location = new System.Drawing.Point(10, 10);
            this.compileContent.Name = "compileContent";
            this.compileContent.Size = new System.Drawing.Size(169, 17);
            this.compileContent.TabIndex = 1;
            this.compileContent.Text = "Compile content (Vista or later)";
            this.compileContent.UseVisualStyleBackColor = true;
            this.compileContent.CheckedChanged += new System.EventHandler(this.CompileContent_CheckedChanged);
            // 
            // diskname
            // 
            this.diskname.Controls.Add(this.pickExe);
            this.diskname.Controls.Add(this.iconBox);
            this.diskname.Controls.Add(this.name);
            this.diskname.Controls.Add(this.pictureBox1);
            this.diskname.Controls.Add(this.groupBox1);
            this.diskname.Location = new System.Drawing.Point(4, 22);
            this.diskname.Name = "diskname";
            this.diskname.Padding = new System.Windows.Forms.Padding(3);
            this.diskname.Size = new System.Drawing.Size(330, 378);
            this.diskname.TabIndex = 0;
            this.diskname.Text = "General";
            this.diskname.UseVisualStyleBackColor = true;
            // 
            // pickExe
            // 
            this.pickExe.Location = new System.Drawing.Point(7, 87);
            this.pickExe.Name = "pickExe";
            this.pickExe.Size = new System.Drawing.Size(320, 27);
            this.pickExe.TabIndex = 4;
            this.pickExe.Text = "Pick Executable (on the same drive)";
            this.pickExe.UseVisualStyleBackColor = true;
            this.pickExe.Click += new System.EventHandler(this.PickExe_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(68, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(249, 20);
            this.name.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.diskname);
            this.tabControl1.Controls.Add(this.content);
            this.tabControl1.Controls.Add(this.whitelist);
            this.tabControl1.Controls.Add(this.help);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 404);
            this.tabControl1.TabIndex = 1;
            // 
            // whitelist
            // 
            this.whitelist.Controls.Add(this.valueToAddToList);
            this.whitelist.Controls.Add(this.wbList);
            this.whitelist.Controls.Add(this.compileList);
            this.whitelist.Controls.Add(this.black);
            this.whitelist.Controls.Add(this.white);
            this.whitelist.Location = new System.Drawing.Point(4, 22);
            this.whitelist.Name = "whitelist";
            this.whitelist.Size = new System.Drawing.Size(330, 378);
            this.whitelist.TabIndex = 3;
            this.whitelist.Text = "Whitelist/Blacklist";
            this.whitelist.UseVisualStyleBackColor = true;
            // 
            // valueToAddToList
            // 
            this.valueToAddToList.Location = new System.Drawing.Point(10, 347);
            this.valueToAddToList.Name = "valueToAddToList";
            this.valueToAddToList.Size = new System.Drawing.Size(308, 20);
            this.valueToAddToList.TabIndex = 4;
            this.valueToAddToList.TextChanged += new System.EventHandler(this.valueToAddToList_TextChanged);
            this.valueToAddToList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valueToAddToList_KeyDown);
            // 
            // wbList
            // 
            this.wbList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wbList.FormattingEnabled = true;
            this.wbList.Location = new System.Drawing.Point(10, 66);
            this.wbList.Name = "wbList";
            this.wbList.Size = new System.Drawing.Size(308, 275);
            this.wbList.TabIndex = 3;
            // 
            // compileList
            // 
            this.compileList.AutoSize = true;
            this.compileList.Location = new System.Drawing.Point(10, 10);
            this.compileList.Name = "compileList";
            this.compileList.Size = new System.Drawing.Size(130, 17);
            this.compileList.TabIndex = 2;
            this.compileList.Text = "Compile (Vista or later)";
            this.compileList.UseVisualStyleBackColor = true;
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(194, 36);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(64, 17);
            this.black.TabIndex = 1;
            this.black.Text = "Blacklist";
            this.black.UseVisualStyleBackColor = true;
            // 
            // white
            // 
            this.white.AutoSize = true;
            this.white.Checked = true;
            this.white.Location = new System.Drawing.Point(47, 36);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(65, 17);
            this.white.TabIndex = 0;
            this.white.TabStop = true;
            this.white.Text = "Whitelist";
            this.white.UseVisualStyleBackColor = true;
            // 
            // help
            // 
            this.help.Controls.Add(this.fork);
            this.help.Controls.Add(this.label5);
            this.help.Controls.Add(this.versionLabel);
            this.help.Controls.Add(this.label2);
            this.help.Location = new System.Drawing.Point(4, 22);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(330, 378);
            this.help.TabIndex = 2;
            this.help.Text = "About";
            this.help.UseVisualStyleBackColor = true;
            // 
            // fork
            // 
            this.fork.AutoSize = true;
            this.fork.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fork.Location = new System.Drawing.Point(88, 119);
            this.fork.Name = "fork";
            this.fork.Size = new System.Drawing.Size(147, 21);
            this.fork.TabIndex = 4;
            this.fork.TabStop = true;
            this.fork.Text = "Fork me on GitHub!";
            this.fork.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Fork_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 100);
            this.label5.TabIndex = 3;
            this.label5.Text = "This is beta software.\r\nIt might be unstable.\r\nStuff may and will change in futur" +
    "e\r\nreleases.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(78, 84);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(165, 20);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "Version 0.2 (githubcatw)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "AutoPlay Maker";
            // 
            // saveAutorun
            // 
            this.saveAutorun.FileName = "autorun.inf";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appearance";
            // 
            // iconBox
            // 
            this.iconBox.Image = global::AutoplayCreator.Properties.Resources.noicon64;
            this.iconBox.Location = new System.Drawing.Point(13, 25);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(48, 49);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 2;
            this.iconBox.TabStop = false;
            this.iconBox.Click += new System.EventHandler(this.iconBox_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 457);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.compile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoPlay Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.diskname.ResumeLayout(false);
            this.diskname.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.whitelist.ResumeLayout(false);
            this.whitelist.PerformLayout();
            this.help.ResumeLayout(false);
            this.help.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.OpenFileDialog openIcon;
        private System.Windows.Forms.OpenFileDialog openExe;
        private System.Windows.Forms.TabPage content;
        private System.Windows.Forms.TabPage diskname;
        private System.Windows.Forms.Button pickExe;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SaveFileDialog saveAutorun;
        private System.Windows.Forms.TabPage help;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox compileContent;
        private System.Windows.Forms.LinkLabel fork;
        private System.Windows.Forms.RadioButton video;
        private System.Windows.Forms.RadioButton music;
        private System.Windows.Forms.RadioButton picture;
        private System.Windows.Forms.TabPage whitelist;
        private System.Windows.Forms.ListBox wbList;
        private System.Windows.Forms.CheckBox compileList;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.RadioButton white;
        private System.Windows.Forms.TextBox valueToAddToList;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

