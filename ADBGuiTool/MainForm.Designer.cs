namespace ADBGuiTool
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.groupDevices = new System.Windows.Forms.GroupBox();
            this.splitContainerDevice = new System.Windows.Forms.SplitContainer();
            this.gridViewDevice = new System.Windows.Forms.DataGridView();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSelectedModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSelectedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSelectedID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectDevice = new System.Windows.Forms.Button();
            this.buttonCheckDevice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxAPK = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInstallAPK = new System.Windows.Forms.Button();
            this.buttonClearAPK = new System.Windows.Forms.Button();
            this.buttonBrowseAPK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxFile = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPushAPK = new System.Windows.Forms.Button();
            this.buttonClearFile = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.dialogSelectAPK = new System.Windows.Forms.OpenFileDialog();
            this.dialogSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.toolTipPush = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDevice)).BeginInit();
            this.splitContainerDevice.Panel1.SuspendLayout();
            this.splitContainerDevice.Panel2.SuspendLayout();
            this.splitContainerDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevice)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(10, 10);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.groupDevices);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox3);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerMain.Size = new System.Drawing.Size(764, 569);
            this.splitContainerMain.SplitterDistance = 408;
            this.splitContainerMain.TabIndex = 5;
            // 
            // groupDevices
            // 
            this.groupDevices.Controls.Add(this.splitContainerDevice);
            this.groupDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDevices.Location = new System.Drawing.Point(0, 0);
            this.groupDevices.Name = "groupDevices";
            this.groupDevices.Size = new System.Drawing.Size(408, 249);
            this.groupDevices.TabIndex = 2;
            this.groupDevices.TabStop = false;
            this.groupDevices.Text = "Device Connection";
            // 
            // splitContainerDevice
            // 
            this.splitContainerDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDevice.Location = new System.Drawing.Point(3, 16);
            this.splitContainerDevice.Name = "splitContainerDevice";
            // 
            // splitContainerDevice.Panel1
            // 
            this.splitContainerDevice.Panel1.Controls.Add(this.gridViewDevice);
            // 
            // splitContainerDevice.Panel2
            // 
            this.splitContainerDevice.Panel2.Controls.Add(this.panel1);
            this.splitContainerDevice.Panel2.Controls.Add(this.buttonSelectDevice);
            this.splitContainerDevice.Panel2.Controls.Add(this.buttonCheckDevice);
            this.splitContainerDevice.Size = new System.Drawing.Size(402, 230);
            this.splitContainerDevice.SplitterDistance = 264;
            this.splitContainerDevice.TabIndex = 0;
            // 
            // gridViewDevice
            // 
            this.gridViewDevice.AllowUserToAddRows = false;
            this.gridViewDevice.AllowUserToDeleteRows = false;
            this.gridViewDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceID,
            this.DeviceName,
            this.DeviceModel});
            this.gridViewDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewDevice.Location = new System.Drawing.Point(0, 0);
            this.gridViewDevice.MultiSelect = false;
            this.gridViewDevice.Name = "gridViewDevice";
            this.gridViewDevice.ReadOnly = true;
            this.gridViewDevice.RowHeadersVisible = false;
            this.gridViewDevice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridViewDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDevice.Size = new System.Drawing.Size(264, 230);
            this.gridViewDevice.TabIndex = 0;
            this.gridViewDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDeviceGridCell_Clicked);
            // 
            // DeviceID
            // 
            this.DeviceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceID.HeaderText = "Device ID";
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.ReadOnly = true;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceName.HeaderText = "Device";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // DeviceModel
            // 
            this.DeviceModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceModel.HeaderText = "Model";
            this.DeviceModel.Name = "DeviceModel";
            this.DeviceModel.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textSelectedModel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textSelectedName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textSelectedID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel1.Size = new System.Drawing.Size(134, 170);
            this.panel1.TabIndex = 2;
            // 
            // textSelectedModel
            // 
            this.textSelectedModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSelectedModel.Location = new System.Drawing.Point(3, 114);
            this.textSelectedModel.Name = "textSelectedModel";
            this.textSelectedModel.Size = new System.Drawing.Size(128, 20);
            this.textSelectedModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // textSelectedName
            // 
            this.textSelectedName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSelectedName.Location = new System.Drawing.Point(3, 71);
            this.textSelectedName.Name = "textSelectedName";
            this.textSelectedName.Size = new System.Drawing.Size(128, 20);
            this.textSelectedName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // textSelectedID
            // 
            this.textSelectedID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSelectedID.Location = new System.Drawing.Point(3, 28);
            this.textSelectedID.Name = "textSelectedID";
            this.textSelectedID.Size = new System.Drawing.Size(128, 20);
            this.textSelectedID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Device ID";
            // 
            // buttonSelectDevice
            // 
            this.buttonSelectDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectDevice.Location = new System.Drawing.Point(0, 30);
            this.buttonSelectDevice.Name = "buttonSelectDevice";
            this.buttonSelectDevice.Size = new System.Drawing.Size(134, 30);
            this.buttonSelectDevice.TabIndex = 1;
            this.buttonSelectDevice.Text = "Select Device";
            this.buttonSelectDevice.UseVisualStyleBackColor = true;
            this.buttonSelectDevice.Click += new System.EventHandler(this.OnSelectDevice_Clicked);
            // 
            // buttonCheckDevice
            // 
            this.buttonCheckDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckDevice.Location = new System.Drawing.Point(0, 0);
            this.buttonCheckDevice.Name = "buttonCheckDevice";
            this.buttonCheckDevice.Size = new System.Drawing.Size(134, 30);
            this.buttonCheckDevice.TabIndex = 0;
            this.buttonCheckDevice.Text = "Check Device";
            this.buttonCheckDevice.UseVisualStyleBackColor = true;
            this.buttonCheckDevice.Click += new System.EventHandler(this.OnCheckDevice_Clicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxAPK);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonInstallAPK);
            this.groupBox3.Controls.Add(this.buttonClearAPK);
            this.groupBox3.Controls.Add(this.buttonBrowseAPK);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(408, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Install APK(s)";
            // 
            // listBoxAPK
            // 
            this.listBoxAPK.CausesValidation = false;
            this.listBoxAPK.CheckOnClick = true;
            this.listBoxAPK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxAPK.FormattingEnabled = true;
            this.listBoxAPK.Location = new System.Drawing.Point(5, 61);
            this.listBoxAPK.Name = "listBoxAPK";
            this.listBoxAPK.Size = new System.Drawing.Size(398, 94);
            this.listBoxAPK.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "APK(s) List";
            // 
            // buttonInstallAPK
            // 
            this.buttonInstallAPK.Location = new System.Drawing.Point(218, 19);
            this.buttonInstallAPK.Name = "buttonInstallAPK";
            this.buttonInstallAPK.Size = new System.Drawing.Size(100, 25);
            this.buttonInstallAPK.TabIndex = 2;
            this.buttonInstallAPK.Text = "Install";
            this.buttonInstallAPK.UseVisualStyleBackColor = true;
            this.buttonInstallAPK.Click += new System.EventHandler(this.OnInstallAPK_Clicked);
            // 
            // buttonClearAPK
            // 
            this.buttonClearAPK.Location = new System.Drawing.Point(112, 19);
            this.buttonClearAPK.Name = "buttonClearAPK";
            this.buttonClearAPK.Size = new System.Drawing.Size(100, 25);
            this.buttonClearAPK.TabIndex = 1;
            this.buttonClearAPK.Text = "Clear List";
            this.buttonClearAPK.UseVisualStyleBackColor = true;
            this.buttonClearAPK.Click += new System.EventHandler(this.OnClearAPK_Clicked);
            // 
            // buttonBrowseAPK
            // 
            this.buttonBrowseAPK.Location = new System.Drawing.Point(6, 19);
            this.buttonBrowseAPK.Name = "buttonBrowseAPK";
            this.buttonBrowseAPK.Size = new System.Drawing.Size(100, 25);
            this.buttonBrowseAPK.TabIndex = 0;
            this.buttonBrowseAPK.Text = "Select APK(s)";
            this.buttonBrowseAPK.UseVisualStyleBackColor = true;
            this.buttonBrowseAPK.Click += new System.EventHandler(this.OnSelectAPK_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonPushAPK);
            this.groupBox1.Controls.Add(this.buttonClearFile);
            this.groupBox1.Controls.Add(this.buttonBrowseFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Push To Device";
            // 
            // listBoxFile
            // 
            this.listBoxFile.CausesValidation = false;
            this.listBoxFile.CheckOnClick = true;
            this.listBoxFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFile.FormattingEnabled = true;
            this.listBoxFile.Location = new System.Drawing.Point(3, 63);
            this.listBoxFile.Name = "listBoxFile";
            this.listBoxFile.Size = new System.Drawing.Size(402, 94);
            this.listBoxFile.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "File(s) List";
            // 
            // buttonPushAPK
            // 
            this.buttonPushAPK.Location = new System.Drawing.Point(218, 19);
            this.buttonPushAPK.Name = "buttonPushAPK";
            this.buttonPushAPK.Size = new System.Drawing.Size(100, 25);
            this.buttonPushAPK.TabIndex = 7;
            this.buttonPushAPK.Text = "Push";
            this.toolTipPush.SetToolTip(this.buttonPushAPK, "/storage/emulated/0/Download/");
            this.buttonPushAPK.UseVisualStyleBackColor = true;
            this.buttonPushAPK.Click += new System.EventHandler(this.OnPushFile_Clicked);
            // 
            // buttonClearFile
            // 
            this.buttonClearFile.Location = new System.Drawing.Point(112, 19);
            this.buttonClearFile.Name = "buttonClearFile";
            this.buttonClearFile.Size = new System.Drawing.Size(100, 25);
            this.buttonClearFile.TabIndex = 6;
            this.buttonClearFile.Text = "Clear List";
            this.buttonClearFile.UseVisualStyleBackColor = true;
            this.buttonClearFile.Click += new System.EventHandler(this.OnClearFile_Clicked);
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(6, 19);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(100, 25);
            this.buttonBrowseFile.TabIndex = 5;
            this.buttonBrowseFile.Text = "Select File(s)";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.OnSelectFile_Clicked);
            // 
            // dialogSelectAPK
            // 
            this.dialogSelectAPK.DefaultExt = "apk";
            this.dialogSelectAPK.Filter = "Application Package (.apk, .xapk)|*.apk;*.xapk;*.APK;*.XAPK";
            this.dialogSelectAPK.Multiselect = true;
            this.dialogSelectAPK.ShowReadOnly = true;
            this.dialogSelectAPK.Title = "Select APK(s)";
            this.dialogSelectAPK.FileOk += new System.ComponentModel.CancelEventHandler(this.OnSelectAPK_OK);
            // 
            // dialogSelectFile
            // 
            this.dialogSelectFile.Filter = "All Files|*.*";
            this.dialogSelectFile.Multiselect = true;
            this.dialogSelectFile.ShowReadOnly = true;
            this.dialogSelectFile.Title = "Select File(s)";
            this.dialogSelectFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OnSelectFile_OK);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelProgress});
            this.statusStrip1.Location = new System.Drawing.Point(10, 579);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabelProgress
            // 
            this.toolStripLabelProgress.Name = "toolStripLabelProgress";
            this.toolStripLabelProgress.Size = new System.Drawing.Size(165, 17);
            this.toolStripLabelProgress.Text = "Waiting for ADB Client To Run";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB GUI Tool";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.groupDevices.ResumeLayout(false);
            this.splitContainerDevice.Panel1.ResumeLayout(false);
            this.splitContainerDevice.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDevice)).EndInit();
            this.splitContainerDevice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDevice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox groupDevices;
        private System.Windows.Forms.SplitContainer splitContainerDevice;
        private System.Windows.Forms.DataGridView gridViewDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceModel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textSelectedModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSelectedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSelectedID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectDevice;
        private System.Windows.Forms.Button buttonCheckDevice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInstallAPK;
        private System.Windows.Forms.Button buttonClearAPK;
        private System.Windows.Forms.Button buttonBrowseAPK;
        private System.Windows.Forms.CheckedListBox listBoxAPK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox listBoxFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPushAPK;
        private System.Windows.Forms.Button buttonClearFile;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.OpenFileDialog dialogSelectAPK;
        private System.Windows.Forms.OpenFileDialog dialogSelectFile;
        private System.Windows.Forms.ToolTip toolTipPush;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelProgress;
    }
}

