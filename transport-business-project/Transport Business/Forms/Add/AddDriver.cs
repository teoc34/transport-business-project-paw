using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Utilities;

namespace transport_business_project.Transport_Business.Forms.Add
{
    public partial class AddDriver : Form
    {
        private const string FilePath = "drivers.xml";

        public AddDriver()
        {
            InitializeComponent();
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Save logic here
                int driverId = new Random().Next(1000);
                string name = txtName.Text;
                string licenseNumber = txtLicenseNumber.Text;
                int yearsOfExperience = int.Parse(txtYearsOfExperience.Text);
                string make = txtMake.Text;
                string plateNumber = txtPlateNumber.Text;

                Driver newDriver = new Driver(driverId, name, make, licenseNumber, yearsOfExperience, plateNumber);
                List<Driver> drivers;

                if (File.Exists(FilePath))
                {
                    drivers = SerializationUtility.DeserializeFromFile<List<Driver>>(FilePath);
                }
                else
                {
                    drivers = new List<Driver>();
                }

                drivers.Add(newDriver);
                SerializationUtility.SerializeToFile(drivers, FilePath);

                MessageBox.Show("Driver added successfully!");
                this.Close();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Name cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtName, null);
            }
        }

        private void txtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLicenseNumber, "License number cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLicenseNumber, null);
            }
        }

        private void txtYearsOfExperience_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtYearsOfExperience.Text, out int years) || years < 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtYearsOfExperience, "Please enter a valid number of years.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtYearsOfExperience, null);
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

        private void txtPlateNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPlateNumber, "Plate number cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPlateNumber, null);
            }
        }
    }
}
