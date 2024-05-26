using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Update
{
    public partial class UpdateTransport : Form
    {
        private TransportContext context;
        private Transport selectedTransport;

        public UpdateTransport()
        {
            InitializeComponent();
            context = new TransportContext();
        }

        private void UpdateTransport_Load(object sender, EventArgs e)
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
                txtMake.Text = selectedTransport.Make;
                dtpMaintenanceDate.Value = selectedTransport.MaintenanceDate;
                txtLicensePlate.Text = selectedTransport.LicensePlate;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren() && selectedTransport != null)
            {
                selectedTransport.Make = txtMake.Text;
                selectedTransport.MaintenanceDate = dtpMaintenanceDate.Value;
                selectedTransport.LicensePlate = txtLicensePlate.Text;

                context.SaveChanges();

                MessageBox.Show("Transport updated successfully!");
                this.Close();
            }
        }

        private void txtMake_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMake, "Make cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMake, null);
            }
        }

        private void txtLicensePlate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicensePlate.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLicensePlate, "License Plate cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLicensePlate, null);
            }
        }

        private void txtTypes_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTypes.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTypes, "Types cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTypes, null);
            }
        }
    }
}
