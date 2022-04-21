using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ADBGuiTool.Utilities;
using PlatformToolsLib;

namespace ADBGuiTool
{
    public partial class MainForm : Form
    {
        #region Variable Declarations
        readonly ADBClient client = new ADBClient(Utility.ADBTool);
        //readonly BindingList<string> apkBindingList = new BindingList<string>();//= new IList<string>()
        //readonly BindingList<string> fileBindingList = new BindingList<string>();//= new IList<string>();
        List<Device> deviceList = new List<Device>();

        string selectedID, selectedName, selectedModel;
        DataGridViewRow selectedRow;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }
        #region Functions
        void ClearDeviceData()
        {
            if (deviceList.Count > 0)
                deviceList.Clear();
        }

        void PopulateListBox(FileType type)
        {
            if (type == FileType.Apk)
            {
                foreach (string files in dialogSelectAPK.FileNames)
                {
                    //apkBindingList.Add(files);
                    listBoxAPK.Items.Add(files);
                }
            }
            else
            {
                foreach (string files in dialogSelectFile.FileNames)
                {
                    //fileBindingList.Add(files);
                    listBoxFile.Items.Add(files);
                }
            }

            ShowData(type);
        }

        void ShowData(FileType type)
        {
            if (type == FileType.Apk)
            {
                //((ListBox)listBoxAPK).DataSource = apkBindingList;
                for (int i = 0; i < listBoxAPK.Items.Count; i++)
                {
                    listBoxAPK.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                //((ListBox)listBoxFile).DataSource = fileBindingList;
                for (int i = 0; i < listBoxFile.Items.Count; i++)
                {
                    listBoxFile.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        void ClearFilesList(FileType type)
        {
            switch (type)
            {
                case FileType.Apk:
                    //apkBindingList.Clear();
                    listBoxAPK.Items.Clear();
                    break;
                case FileType.Normal:
                    //fileBindingList.Clear();
                    listBoxFile.Items.Clear();
                    break;
            }
        }

        async void Push()
        {
            if (listBoxFile.Items.Count != 0 || !string.IsNullOrEmpty(selectedID))
                foreach (string item in listBoxFile.CheckedItems)
                {
                    await client.Push(selectedID, item,OnADBStart, OnADBFinished);
                }
        }
        async void Install()
        {
            if (listBoxAPK.Items.Count != 0 || !string.IsNullOrEmpty(selectedID))
                foreach (string item in listBoxAPK.CheckedItems)
                {
                    await client.Install(selectedID, item, OnADBStart, OnADBFinished);
                }
                   
        }

        private void OnADBStart(string obj)
        {
            toolStripLabelProgress.Text = obj;
        }

        private void OnADBFinished(string obj)
        {
            toolStripLabelProgress.Text = obj;
        }
        #endregion

        #region Devices
        private void OnDeviceGridCell_Clicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
            selectedRow = gridViewDevice.Rows[e.RowIndex];
        }

        private void OnCheckDevice_Clicked(object sender, EventArgs e)
        {
            ClearDeviceData();
            client.GetDevicesList(OnADBStart, OnDeviceScanned, OnADBFinished);
        }

        private void OnSelectDevice_Clicked(object sender, EventArgs e)
        {
            if (selectedRow is null) return;
            selectedID = selectedRow.Cells[0].Value.ToString();
            selectedName = selectedRow.Cells[1].Value.ToString();
            selectedModel = selectedRow.Cells[2].Value.ToString();

            textSelectedID.Text = selectedID;
            textSelectedName.Text = selectedName;
            textSelectedModel.Text = selectedModel;
        }

        #region Callbacks
        private void OnDeviceScanned(List<Device> deviceList)
        {
            this.deviceList = deviceList;

            gridViewDevice.Columns["DeviceID"].DataPropertyName = "ID";
            gridViewDevice.Columns["DeviceName"].DataPropertyName = "Name";
            gridViewDevice.Columns["DeviceModel"].DataPropertyName = "Model";

            gridViewDevice.DataSource = deviceList;

            if (deviceList.Count > 0 || this.deviceList.Count > 0)
                selectedRow = gridViewDevice.Rows[0];
        }
        #endregion
        #endregion

        #region Install APK
        private void OnSelectAPK_Clicked(object sender, EventArgs e)
        {
            dialogSelectAPK.ShowDialog();
        }

        private void OnClearAPK_Clicked(object sender, EventArgs e)
        {
            ClearFilesList(FileType.Apk);
        }

        private void OnInstallAPK_Clicked(object sender, EventArgs e)
        {
            Install();
        }

        private void OnSelectAPK_OK(object sender, CancelEventArgs e)
        {
            var type = FileType.Apk;
            PopulateListBox(type);
        }
        #endregion

        #region Push
        private void OnSelectFile_Clicked(object sender, EventArgs e)
        {
            dialogSelectFile.ShowDialog();
        }

        private void OnClearFile_Clicked(object sender, EventArgs e)
        {
            ClearFilesList(FileType.Normal);
        }

        private void OnPushFile_Clicked(object sender, EventArgs e)
        {
            Push();
        }

        private void OnSelectFile_OK(object sender, CancelEventArgs e)
        {
            var type = FileType.Normal;
            PopulateListBox(type);
        }
        #endregion
    }
}

public enum FileType { Apk, Normal}