using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Add
{
    public partial class AddTransport : Form
    {
        private TransportContext context;

        public AddTransport()
        {
            InitializeComponent();
            context = new TransportContext();
        }

        private void AddTransport_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var newTransport = new Transport
                {
                    Make = txtMake.Text,
                    MaintenanceDate = dtpMaintenanceDate.Value,
                    LicensePlate = txtLicensePlate.Text,
                };

                context.Transports.Add(newTransport);
                context.SaveChanges();

                MessageBox.Show("Transport added successfully!");
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
