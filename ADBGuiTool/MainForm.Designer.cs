namespace ADBGuiTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deviceGridView = new System.Windows.Forms.DataGridView();
            this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectDevice = new System.Windows.Forms.Button();
            this.textSelectedModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSelectedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSelectedID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckDevice = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectAPKDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonClearAPK = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonInstallAPK = new System.Windows.Forms.Button();
            this.buttonBrowseAPK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(403, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Connection";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deviceGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.btnCheckDevice);
            this.splitContainer1.Size = new System.Drawing.Size(397, 222);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            // 
            // deviceGridView
            // 
            this.deviceGridView.AllowUserToAddRows = false;
            this.deviceGridView.AllowUserToDeleteRows = false;
            this.deviceGridView.AllowUserToOrderColumns = true;
            this.deviceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceID,
            this.DeviceName,
            this.DeviceModel});
            this.deviceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceGridView.Location = new System.Drawing.Point(0, 0);
            this.deviceGridView.MultiSelect = false;
            this.deviceGridView.Name = "deviceGridView";
            this.deviceGridView.ReadOnly = true;
            this.deviceGridView.RowHeadersVisible = false;
            this.deviceGridView.RowTemplate.Height = 25;
            this.deviceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.deviceGridView.ShowCellErrors = false;
            this.deviceGridView.ShowCellToolTips = false;
            this.deviceGridView.ShowEditingIcon = false;
            this.deviceGridView.ShowRowErrors = false;
            this.deviceGridView.Size = new System.Drawing.Size(280, 222);
            this.deviceGridView.TabIndex = 0;
            this.deviceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeviceGridCellClicked);
            // 
            // DeviceID
            // 
            this.DeviceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceID.HeaderText = "Device ID";
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.ReadOnly = true;
            this.DeviceID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceName.HeaderText = "Device Name";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            this.DeviceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DeviceModel
            // 
            this.DeviceModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeviceModel.HeaderText = "Device Model";
            this.DeviceModel.Name = "DeviceModel";
            this.DeviceModel.ReadOnly = true;
            this.DeviceModel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btnSelectDevice);
            this.groupBox2.Controls.Add(this.textSelectedModel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textSelectedName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textSelectedID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(113, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Device";
            // 
            // btnSelectDevice
            // 
            this.btnSelectDevice.AutoSize = true;
            this.btnSelectDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelectDevice.Location = new System.Drawing.Point(0, 145);
            this.btnSelectDevice.Name = "btnSelectDevice";
            this.btnSelectDevice.Size = new System.Drawing.Size(113, 25);
            this.btnSelectDevice.TabIndex = 9;
            this.btnSelectDevice.Text = "Select Device";
            this.btnSelectDevice.UseVisualStyleBackColor = true;
            this.btnSelectDevice.Click += new System.EventHandler(this.SelectDeviceClicked);
            // 
            // textSelectedModel
            // 
            this.textSelectedModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSelectedModel.Location = new System.Drawing.Point(0, 122);
            this.textSelectedModel.Name = "textSelectedModel";
            this.textSelectedModel.Size = new System.Drawing.Size(113, 23);
            this.textSelectedModel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 102);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Device Name";
            // 
            // textSelectedName
            // 
            this.textSelectedName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSelectedName.Location = new System.Drawing.Point(0, 79);
            this.textSelectedName.Name = "textSelectedName";
            this.textSelectedName.Size = new System.Drawing.Size(113, 23);
            this.textSelectedName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Device Name";
            // 
            // textSelectedID
            // 
            this.textSelectedID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textSelectedID.Location = new System.Drawing.Point(0, 36);
            this.textSelectedID.Name = "textSelectedID";
            this.textSelectedID.Size = new System.Drawing.Size(113, 23);
            this.textSelectedID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device ID";
            // 
            // btnCheckDevice
            // 
            this.btnCheckDevice.AutoSize = true;
            this.btnCheckDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckDevice.Location = new System.Drawing.Point(0, 0);
            this.btnCheckDevice.Margin = new System.Windows.Forms.Padding(10);
            this.btnCheckDevice.Name = "btnCheckDevice";
            this.btnCheckDevice.Size = new System.Drawing.Size(113, 25);
            this.btnCheckDevice.TabIndex = 0;
            this.btnCheckDevice.Text = "Check Devices";
            this.btnCheckDevice.UseVisualStyleBackColor = true;
            this.btnCheckDevice.Click += new System.EventHandler(this.CheckDevice_Clicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 248);
            this.panel2.TabIndex = 4;
            // 
            // selectAPKDialog
            // 
            this.selectAPKDialog.Filter = "Application Package (.apk, .xapk)|*.apk;*.xapk;*.APK;*.XAPK";
            this.selectAPKDialog.Multiselect = true;
            this.selectAPKDialog.ShowHelp = true;
            this.selectAPKDialog.Title = "Select APK Files";
            this.selectAPKDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SelectAPK_OK);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonClearAPK);
            this.groupBox4.Controls.Add(this.fileListBox);
            this.groupBox4.Controls.Add(this.buttonInstallAPK);
            this.groupBox4.Controls.Add(this.buttonBrowseAPK);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(436, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 168);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Install APK";
            // 
            // buttonClearAPK
            // 
            this.buttonClearAPK.Location = new System.Drawing.Point(112, 17);
            this.buttonClearAPK.Name = "buttonClearAPK";
            this.buttonClearAPK.Size = new System.Drawing.Size(103, 33);
            this.buttonClearAPK.TabIndex = 5;
            this.buttonClearAPK.Text = "Clear Files";
            this.buttonClearAPK.UseVisualStyleBackColor = true;
            this.buttonClearAPK.Click += new System.EventHandler(this.ClearAPK_Clicked);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(6, 71);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(324, 94);
            this.fileListBox.TabIndex = 4;
            // 
            // buttonInstallAPK
            // 
            this.buttonInstallAPK.Location = new System.Drawing.Point(221, 17);
            this.buttonInstallAPK.Name = "buttonInstallAPK";
            this.buttonInstallAPK.Size = new System.Drawing.Size(109, 32);
            this.buttonInstallAPK.TabIndex = 3;
            this.buttonInstallAPK.Text = "Install";
            this.buttonInstallAPK.UseVisualStyleBackColor = true;
            this.buttonInstallAPK.Click += new System.EventHandler(this.InstallAPK_Clicked);
            // 
            // buttonBrowseAPK
            // 
            this.buttonBrowseAPK.Location = new System.Drawing.Point(6, 17);
            this.buttonBrowseAPK.Name = "buttonBrowseAPK";
            this.buttonBrowseAPK.Size = new System.Drawing.Size(100, 33);
            this.buttonBrowseAPK.TabIndex = 2;
            this.buttonBrowseAPK.Text = "Select Files";
            this.buttonBrowseAPK.UseVisualStyleBackColor = true;
            this.buttonBrowseAPK.Click += new System.EventHandler(this.SelectAPK_Clicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Applications to Install";
            // 
            // selectFileDialog
            // 
            this.selectFileDialog.Filter = "All Files|*.*";
            this.selectFileDialog.Multiselect = true;
            this.selectFileDialog.Title = "Select Files";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "ADB GUI Tools";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private DataGridView deviceGridView;
        private Button btnCheckDevice;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textSelectedName;
        private Label label2;
        private TextBox textSelectedID;
        private Button btnSelectDevice;
        private TextBox textSelectedModel;
        private Label label3;
        private DataGridViewTextBoxColumn DeviceID;
        private DataGridViewTextBoxColumn DeviceName;
        private DataGridViewTextBoxColumn DeviceModel;
        private Panel panel2;
        private OpenFileDialog selectAPKDialog;
        private GroupBox groupBox4;
        private OpenFileDialog selectFileDialog;
        private Label label4;
        private Button buttonInstallAPK;
        private Button buttonBrowseAPK;
        private CheckedListBox fileListBox;
        private Button buttonClearAPK;
    }
}