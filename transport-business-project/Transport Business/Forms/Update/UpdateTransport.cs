using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using transport_business_project.Classes;

namespace transport_business_project.Transport_Business.Forms.Update
{
    public partial class UpdateTransport : Form
    {
        public UpdateTransport()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Update logic here
                int transportID = int.Parse(txtTransportID.Text);
                string make = txtMake.Text;
                DateTime maintenanceDate = dtpMaintenanceDate.Value;
                string licensePlate = txtLicensePlate.Text;
                List<string> types = new List<string>(txtTypes.Text.Split(','));

                Transport updatedTransport = new Transport(transportID, make, maintenanceDate, licensePlate, types);
                // Update the transport in the database or collection

                MessageBox.Show("Transport updated successfully!");
                this.Close();
            }
        }

        private void txtTransportID_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtTransportID.Text, out int transportID) || transportID <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtTransportID, "Please enter a valid Transport ID.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTransportID, null);
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
