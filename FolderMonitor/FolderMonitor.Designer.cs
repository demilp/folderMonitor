namespace FolderMonitor
{
    partial class FolderMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderMonitor));
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseSourceFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogOriginals = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogBat = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowseOriginalsFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOrginals = new System.Windows.Forms.TextBox();
            this.buttonBrowseDestinationFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonBrowseProcessFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProcess = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(52, 62);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(741, 20);
            this.textBoxSource.TabIndex = 0;
            this.textBoxSource.Text = "sourceFolder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Folder";
            // 
            // buttonBrowseSourceFolder
            // 
            this.buttonBrowseSourceFolder.Location = new System.Drawing.Point(808, 60);
            this.buttonBrowseSourceFolder.Name = "buttonBrowseSourceFolder";
            this.buttonBrowseSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSourceFolder.TabIndex = 2;
            this.buttonBrowseSourceFolder.Text = "Browse";
            this.buttonBrowseSourceFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseSourceFolder.Click += new System.EventHandler(this.buttonBrowseSourceFolder_Click);
            // 
            // openFileDialogBat
            // 
            this.openFileDialogBat.FileName = "openFileDialog1";
            // 
            // buttonBrowseOriginalsFolder
            // 
            this.buttonBrowseOriginalsFolder.Location = new System.Drawing.Point(808, 121);
            this.buttonBrowseOriginalsFolder.Name = "buttonBrowseOriginalsFolder";
            this.buttonBrowseOriginalsFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseOriginalsFolder.TabIndex = 5;
            this.buttonBrowseOriginalsFolder.Text = "Browse";
            this.buttonBrowseOriginalsFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseOriginalsFolder.Click += new System.EventHandler(this.buttonBrowseOriginalsFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Originals Backup Folder";
            // 
            // textBoxOrginals
            // 
            this.textBoxOrginals.Location = new System.Drawing.Point(52, 123);
            this.textBoxOrginals.Name = "textBoxOrginals";
            this.textBoxOrginals.Size = new System.Drawing.Size(741, 20);
            this.textBoxOrginals.TabIndex = 3;
            this.textBoxOrginals.Text = "originalsBackup";
            // 
            // buttonBrowseDestinationFolder
            // 
            this.buttonBrowseDestinationFolder.Location = new System.Drawing.Point(808, 188);
            this.buttonBrowseDestinationFolder.Name = "buttonBrowseDestinationFolder";
            this.buttonBrowseDestinationFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseDestinationFolder.TabIndex = 8;
            this.buttonBrowseDestinationFolder.Text = "Browse";
            this.buttonBrowseDestinationFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseDestinationFolder.Click += new System.EventHandler(this.buttonBrowseDestinationFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination Folder";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(52, 190);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(741, 20);
            this.textBoxDestination.TabIndex = 6;
            this.textBoxDestination.Text = "destination";
            // 
            // buttonBrowseProcessFile
            // 
            this.buttonBrowseProcessFile.Location = new System.Drawing.Point(808, 325);
            this.buttonBrowseProcessFile.Name = "buttonBrowseProcessFile";
            this.buttonBrowseProcessFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseProcessFile.TabIndex = 11;
            this.buttonBrowseProcessFile.Text = "Browse";
            this.buttonBrowseProcessFile.UseVisualStyleBackColor = true;
            this.buttonBrowseProcessFile.Click += new System.EventHandler(this.buttonBrowseProcessFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Process File";
            // 
            // textBoxProcess
            // 
            this.textBoxProcess.Location = new System.Drawing.Point(52, 327);
            this.textBoxProcess.Name = "textBoxProcess";
            this.textBoxProcess.Size = new System.Drawing.Size(741, 20);
            this.textBoxProcess.TabIndex = 9;
            this.textBoxProcess.Text = "process.bat";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(141, 229);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(47, 20);
            this.textBoxExtension.TabIndex = 12;
            this.textBoxExtension.Text = "*.jpg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Files Extension:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(49, 361);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 14;
            // 
            // FolderMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 397);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.buttonBrowseProcessFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProcess);
            this.Controls.Add(this.buttonBrowseDestinationFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.buttonBrowseOriginalsFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOrginals);
            this.Controls.Add(this.buttonBrowseSourceFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderMonitor";
            this.Text = "FolderMonitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FolderMonitor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FolderMonitor_FormClosed);
            this.Load += new System.EventHandler(this.FolderMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOriginals;
        private System.Windows.Forms.OpenFileDialog openFileDialogBat;
        private System.Windows.Forms.Button buttonBrowseOriginalsFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOrginals;
        private System.Windows.Forms.Button buttonBrowseDestinationFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonBrowseProcessFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProcess;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelError;
    }
}

