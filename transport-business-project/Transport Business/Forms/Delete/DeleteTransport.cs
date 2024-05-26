using System;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    public partial class DeleteTransport : Form
    {
        private TransportContext context;
        private Transport selectedTransport;

        public DeleteTransport()
        {
            InitializeComponent();
            context = new TransportContext();
        }

        private void DeleteTransport_Load(object sender, EventArgs e)
        {
            LoadTransports();
        }

        private void LoadTransports()
        {
            var transports = context.Transports.ToList();
            comboBoxTransports.DataSource = transports;
            comboBoxTransports.DisplayMember = "LicensePlate";
            comboBoxTransports.ValueMember = "TransportID";
        }

        private void comboBoxTransports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTransports.SelectedItem != null)
            {
                selectedTransport = (Transport)comboBoxTransports.SelectedItem;
                txtTransportID.Text = selectedTransport.TransportID.ToString();
                txtMake.Text = selectedTransport.Make;
                dtpMaintenanceDate.Value = selectedTransport.MaintenanceDate;
                txtLicensePlate.Text = selectedTransport.LicensePlate;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTransport != null)
            {
                context.Transports.Remove(selectedTransport);
                context.SaveChanges();

                MessageBox.Show("Transport deleted successfully!");
                LoadTransports();
                ClearFields();
            }
        }

        private void ClearFields()
        {
            txtTransportID.Text = string.Empty;
            txtMake.Text = string.Empty;
            dtpMaintenanceDate.Value = DateTime.Now;
            txtLicensePlate.Text = string.Empty;
        }
    }
}
