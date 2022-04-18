using ADBGuiTool.Data;
using ADBGuiTool.Utilities;
using System.Diagnostics;

namespace ADBGuiTool
{
    public partial class MainForm : Form
    {
        AdbClient client = new AdbClient();
        List<Device> devices = new List<Device>();
        string selectedID, selectedName, selectedModel;
        DataGridViewRow selectedRow;

        public MainForm()
        {
            InitializeComponent();
        }

        void ClearData()
        {
            if (devices.Count > 0)
            devices.Clear();
        }

        private void CheckDevice_Clicked(object sender, EventArgs e)
        {
            ClearData();
            client.GetDevicesList(OnGetDevice);
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

        private void DeviceGridCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
            selectedRow = deviceGridView.Rows[e.RowIndex];
        }


        private void SelectDeviceClicked(object sender, EventArgs e)
        {
            if (selectedRow is null) return;
            selectedID =    selectedRow.Cells[0].Value.ToString();
            selectedName =  selectedRow.Cells[1].Value.ToString();
            selectedModel = selectedRow.Cells[2].Value.ToString();

            textSelectedID.Text = selectedID;
            textSelectedName.Text = selectedName;
            textSelectedModel.Text = selectedModel;
        }
    }
}