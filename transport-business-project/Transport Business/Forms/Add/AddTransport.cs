using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Utilities;

namespace transport_business_project.Transport_Business.Forms.Add
{
    public partial class AddTransport : Form
    {
        private const string FilePath = "transports.xml";

        public AddTransport()
        {
            InitializeComponent();
        }

        private void AddTransport_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Save logic here
                int transportID = new Random().Next(1000);
                string make = txtMake.Text;
                DateTime maintenanceDate = dtpMaintenanceDate.Value;
                string licensePlate = txtLicensePlate.Text;
                List<string> types = new List<string>(txtTypes.Text.Split(','));

                Transport newTransport = new Transport(transportID, make, maintenanceDate, licensePlate, types);
                List<Transport> transports;

                if (File.Exists(FilePath))
                {
                    transports = SerializationUtility.DeserializeFromFile<List<Transport>>(FilePath);
                }
                else
                {
                    transports = new List<Transport>();
                }

                transports.Add(newTransport);
                SerializationUtility.SerializeToFile(transports, FilePath);

                MessageBox.Show("Transport added successfully!");
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
