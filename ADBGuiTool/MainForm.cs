using ADBGuiTool.Data;
using ADBGuiTool.Utilities;
using System.ComponentModel;
using System.Diagnostics;

namespace ADBGuiTool
{
    public partial class MainForm : Form
    {
        AdbClient client = new AdbClient();
        List<Device> devices = new List<Device>();
        BindingList<string> filesBinding = new BindingList<string>();


        string selectedID, selectedName, selectedModel;
        DataGridViewRow selectedRow;
        bool isEmpty = true;

        public MainForm()
        {
            InitializeComponent();
            filesBinding.AllowRemove = true;
        }

        void ClearDeviceData()
        {
            if (devices.Count > 0)
            devices.Clear();
        }

        void ClearFileData()
        {
            filesBinding.Clear();
            ShowData();
        }

        void PopulateDataListBox()
        {

            foreach (string files in selectAPKDialog.FileNames)
            {
                filesBinding.Add(files);
            }
            ShowData();
        }

        void ShowData()
        {
            fileListBox.DataSource = filesBinding;
        }

        async void Install()
        {
            var command = "";
            if (filesBinding.Count != 0 || !string.IsNullOrEmpty(selectedID))
            foreach (var item in fileListBox.CheckedItems)
            {
                Debug.WriteLine(command);
                await client.Install(selectedID, item.ToString());
            }
        }

        private void OnGetDevice(List<Device> obj)
        {
            devices = obj;

            deviceGridView.Columns["DeviceID"].DataPropertyName = "DeviceID";
            deviceGridView.Columns["DeviceName"].DataPropertyName = "DeviceName";
            deviceGridView.Columns["DeviceModel"].DataPropertyName = "DeviceModel";

            deviceGridView.DataSource = devices;

            for (int i = 0; i < devices.Count; i++)
            {
                deviceGridView.Rows[i].Cells[0].Value = devices[i].DeviceID;
                deviceGridView.Rows[i].Cells[1].Value = devices[i].DeviceName;
                deviceGridView.Rows[i].Cells[2].Value = devices[i].DeviceModel;
            }
        }

        #region UI Handler
        #region Select Device
        private void CheckDevice_Clicked(object sender, EventArgs e)
        {
            ClearDeviceData();
            client.GetDevicesList(OnGetDevice);
        }

        private void SelectDeviceClicked(object sender, EventArgs e)
        {
            if (selectedRow is null) return;
            selectedID = selectedRow.Cells[0].Value.ToString();
            selectedName = selectedRow.Cells[1].Value.ToString();
            selectedModel = selectedRow.Cells[2].Value.ToString();

            textSelectedID.Text = selectedID;
            textSelectedName.Text = selectedName;
            textSelectedModel.Text = selectedModel;
        }

        private void DeviceGridCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
            selectedRow = deviceGridView.Rows[e.RowIndex];
        }
        #endregion

        #region APK Install
        private void SelectAPK_Clicked(object sender, EventArgs e)
        {
            selectAPKDialog.ShowDialog();
        }

        private void ClearAPK_Clicked(object sender, EventArgs e)
        {
            ClearFileData();
        }

        private void InstallAPK_Clicked(object sender, EventArgs e)
        {
            Install();
        }

        private void SelectAPK_OK(object sender, CancelEventArgs e)
        {
            PopulateDataListBox();
        }
        #endregion
        #endregion
    }
}