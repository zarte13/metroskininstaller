﻿namespace Metro_Skin_Installer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlebar = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.line3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.page1 = new System.Windows.Forms.Panel();
            this.PatchedNextButton = new System.Windows.Forms.Button();
            this.OfficialInstallbutton = new System.Windows.Forms.Button();
            this.page2patched = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.title3 = new System.Windows.Forms.Label();
            this.PatchInstallButton = new System.Windows.Forms.Button();
            this.extrasListBox = new System.Windows.Forms.CheckedListBox();
            this.InstallerPage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CurrentWorker = new System.Windows.Forms.Label();
            this.installLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.installingTitle = new System.Windows.Forms.Label();
            this.installProgress = new System.Windows.Forms.ProgressBar();
            this.DownloadPatchWorker = new System.ComponentModel.BackgroundWorker();
            this.DownloadWorker = new System.ComponentModel.BackgroundWorker();
            this.titlebar.SuspendLayout();
            this.page1.SuspendLayout();
            this.page2patched.SuspendLayout();
            this.InstallerPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.Controls.Add(this.line1);
            this.titlebar.Controls.Add(this.ExitButton);
            this.titlebar.Controls.Add(this.label1);
            this.titlebar.Location = new System.Drawing.Point(0, 2);
            this.titlebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(718, 128);
            this.titlebar.TabIndex = 1;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.titlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // line1
            // 
            this.line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line1.ForeColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(0, 103);
            this.line1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(718, 3);
            this.line1.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(644, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 34);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metro For Steam™";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(27, 14);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(244, 45);
            this.title1.TabIndex = 3;
            this.title1.Text = "Patched version";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text1.ForeColor = System.Drawing.Color.White;
            this.text1.Location = new System.Drawing.Point(36, 80);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(399, 56);
            this.text1.TabIndex = 4;
            this.text1.Text = "The Metro Skin with community\r\nmade features, bug fixes and enchancements";
            // 
            // line2
            // 
            this.line2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line2.ForeColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(0, 62);
            this.line2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(292, 3);
            this.line2.TabIndex = 5;
            // 
            // line3
            // 
            this.line3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line3.ForeColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(0, 226);
            this.line3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(292, 3);
            this.line3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 84);
            this.label5.TabIndex = 8;
            this.label5.Text = "The original Metro Skin \r\n(Not completely compatible with \r\nthe latest Steam)";
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.White;
            this.title2.Location = new System.Drawing.Point(34, 180);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(230, 45);
            this.title2.TabIndex = 7;
            this.title2.Text = "Official version";
            // 
            // page1
            // 
            this.page1.Controls.Add(this.title1);
            this.page1.Controls.Add(this.line3);
            this.page1.Controls.Add(this.PatchedNextButton);
            this.page1.Controls.Add(this.label5);
            this.page1.Controls.Add(this.text1);
            this.page1.Controls.Add(this.title2);
            this.page1.Controls.Add(this.line2);
            this.page1.Controls.Add(this.OfficialInstallbutton);
            this.page1.Location = new System.Drawing.Point(0, 138);
            this.page1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(718, 494);
            this.page1.TabIndex = 10;
            // 
            // PatchedNextButton
            // 
            this.PatchedNextButton.BackColor = System.Drawing.Color.Transparent;
            this.PatchedNextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PatchedNextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PatchedNextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.PatchedNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatchedNextButton.Font = new System.Drawing.Font("Segoe UI", 13.6F);
            this.PatchedNextButton.ForeColor = System.Drawing.Color.White;
            this.PatchedNextButton.Image = ((System.Drawing.Image)(resources.GetObject("PatchedNextButton.Image")));
            this.PatchedNextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatchedNextButton.Location = new System.Drawing.Point(496, 80);
            this.PatchedNextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatchedNextButton.Name = "PatchedNextButton";
            this.PatchedNextButton.Size = new System.Drawing.Size(206, 57);
            this.PatchedNextButton.TabIndex = 2;
            this.PatchedNextButton.Text = "Next";
            this.PatchedNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatchedNextButton.UseVisualStyleBackColor = false;
            this.PatchedNextButton.Click += new System.EventHandler(this.PatchedNextButton_Click);
            // 
            // OfficialInstallbutton
            // 
            this.OfficialInstallbutton.BackColor = System.Drawing.Color.Transparent;
            this.OfficialInstallbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.OfficialInstallbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OfficialInstallbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.OfficialInstallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfficialInstallbutton.Font = new System.Drawing.Font("Segoe UI", 13.6F);
            this.OfficialInstallbutton.ForeColor = System.Drawing.Color.White;
            this.OfficialInstallbutton.Image = ((System.Drawing.Image)(resources.GetObject("OfficialInstallbutton.Image")));
            this.OfficialInstallbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OfficialInstallbutton.Location = new System.Drawing.Point(496, 245);
            this.OfficialInstallbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OfficialInstallbutton.Name = "OfficialInstallbutton";
            this.OfficialInstallbutton.Size = new System.Drawing.Size(206, 57);
            this.OfficialInstallbutton.TabIndex = 6;
            this.OfficialInstallbutton.Text = "Install now";
            this.OfficialInstallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OfficialInstallbutton.UseVisualStyleBackColor = false;
            this.OfficialInstallbutton.Click += new System.EventHandler(this.OfficialInstallbutton_Click);
            // 
            // page2patched
            // 
            this.page2patched.Controls.Add(this.progressBar1);
            this.page2patched.Controls.Add(this.label4);
            this.page2patched.Controls.Add(this.text3);
            this.page2patched.Controls.Add(this.title3);
            this.page2patched.Controls.Add(this.PatchInstallButton);
            this.page2patched.Controls.Add(this.extrasListBox);
            this.page2patched.Location = new System.Drawing.Point(0, 138);
            this.page2patched.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.page2patched.Name = "page2patched";
            this.page2patched.Size = new System.Drawing.Size(718, 855);
            this.page2patched.TabIndex = 11;
            this.page2patched.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(270, 223);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 17);
            this.progressBar1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 3);
            this.label4.TabIndex = 12;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text3.ForeColor = System.Drawing.Color.White;
            this.text3.Location = new System.Drawing.Point(28, 80);
            this.text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(378, 28);
            this.text3.TabIndex = 9;
            this.text3.Text = "The patched version has optional features:";
            // 
            // title3
            // 
            this.title3.AutoSize = true;
            this.title3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title3.ForeColor = System.Drawing.Color.White;
            this.title3.Location = new System.Drawing.Point(27, 14);
            this.title3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title3.Name = "title3";
            this.title3.Size = new System.Drawing.Size(244, 45);
            this.title3.TabIndex = 8;
            this.title3.Text = "Patched version";
            // 
            // PatchInstallButton
            // 
            this.PatchInstallButton.BackColor = System.Drawing.Color.Transparent;
            this.PatchInstallButton.Enabled = false;
            this.PatchInstallButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PatchInstallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PatchInstallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.PatchInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatchInstallButton.Font = new System.Drawing.Font("Segoe UI", 13.6F);
            this.PatchInstallButton.ForeColor = System.Drawing.Color.DimGray;
            this.PatchInstallButton.Image = global::Metro_Skin_Installer.Properties.Resources.right_arrow_grey;
            this.PatchInstallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatchInstallButton.Location = new System.Drawing.Point(402, 388);
            this.PatchInstallButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatchInstallButton.Name = "PatchInstallButton";
            this.PatchInstallButton.Size = new System.Drawing.Size(206, 57);
            this.PatchInstallButton.TabIndex = 7;
            this.PatchInstallButton.Text = "Install now";
            this.PatchInstallButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatchInstallButton.UseVisualStyleBackColor = false;
            this.PatchInstallButton.Click += new System.EventHandler(this.PatchInstallButton_Click);
            // 
            // extrasListBox
            // 
            this.extrasListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.extrasListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extrasListBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.extrasListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.Location = new System.Drawing.Point(78, 125);
            this.extrasListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.Size = new System.Drawing.Size(528, 191);
            this.extrasListBox.TabIndex = 0;
            // 
            // InstallerPage
            // 
            this.InstallerPage.Controls.Add(this.button1);
            this.InstallerPage.Controls.Add(this.CurrentWorker);
            this.InstallerPage.Controls.Add(this.installLabel);
            this.InstallerPage.Controls.Add(this.label2);
            this.InstallerPage.Controls.Add(this.installingTitle);
            this.InstallerPage.Controls.Add(this.installProgress);
            this.InstallerPage.Location = new System.Drawing.Point(0, 138);
            this.InstallerPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InstallerPage.Name = "InstallerPage";
            this.InstallerPage.Size = new System.Drawing.Size(718, 494);
            this.InstallerPage.TabIndex = 12;
            this.InstallerPage.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.6F);
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(408, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 57);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrentWorker
            // 
            this.CurrentWorker.AutoSize = true;
            this.CurrentWorker.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CurrentWorker.ForeColor = System.Drawing.Color.White;
            this.CurrentWorker.Location = new System.Drawing.Point(195, 186);
            this.CurrentWorker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentWorker.Name = "CurrentWorker";
            this.CurrentWorker.Size = new System.Drawing.Size(49, 30);
            this.CurrentWorker.TabIndex = 16;
            this.CurrentWorker.Text = "Idle";
            // 
            // installLabel
            // 
            this.installLabel.AutoSize = true;
            this.installLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.installLabel.ForeColor = System.Drawing.Color.White;
            this.installLabel.Location = new System.Drawing.Point(78, 186);
            this.installLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(103, 30);
            this.installLabel.TabIndex = 15;
            this.installLabel.Text = "Installing:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 3);
            this.label2.TabIndex = 14;
            // 
            // installingTitle
            // 
            this.installingTitle.AutoSize = true;
            this.installingTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installingTitle.ForeColor = System.Drawing.Color.White;
            this.installingTitle.Location = new System.Drawing.Point(27, 14);
            this.installingTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installingTitle.Name = "installingTitle";
            this.installingTitle.Size = new System.Drawing.Size(149, 45);
            this.installingTitle.TabIndex = 13;
            this.installingTitle.Text = "Installing";
            // 
            // installProgress
            // 
            this.installProgress.Location = new System.Drawing.Point(84, 245);
            this.installProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.installProgress.Name = "installProgress";
            this.installProgress.Size = new System.Drawing.Size(530, 35);
            this.installProgress.TabIndex = 0;
            // 
            // DownloadPatchWorker
            // 
            this.DownloadPatchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadPatch_DoWork);
            // 
            // DownloadWorker
            // 
            this.DownloadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadWorker_DoWork_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(722, 635);
            this.Controls.Add(this.InstallerPage);
            this.Controls.Add(this.page2patched);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.page2patched.ResumeLayout(false);
            this.page2patched.PerformLayout();
            this.InstallerPage.ResumeLayout(false);
            this.InstallerPage.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Button PatchedNextButton;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.Label line3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button OfficialInstallbutton;
        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Panel page2patched;
        private System.Windows.Forms.CheckedListBox extrasListBox;
        private System.Windows.Forms.Button PatchInstallButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Panel InstallerPage;
        private System.Windows.Forms.Label CurrentWorker;
        private System.Windows.Forms.Label installLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label installingTitle;
        private System.Windows.Forms.ProgressBar installProgress;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker DownloadPatchWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker DownloadWorker;
    }
}
