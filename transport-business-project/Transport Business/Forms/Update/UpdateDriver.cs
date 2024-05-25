using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;
using transport_business_project.Classes;

namespace transport_business_project.Transport_Business.Forms.Update
{
    public partial class UpdateDriver : Form
    {
        public UpdateDriver()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Update logic here
                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                string licenseNumber = txtLicenseNumber.Text;
                int yearsOfExperience = int.Parse(txtYearsOfExperience.Text);
                string make = txtMake.Text;
                string plateNumber = txtPlateNumber.Text;

                Driver updatedDriver = new Driver(id, name, make, licenseNumber, yearsOfExperience, plateNumber);
                // Update the driver in the database or collection

                MessageBox.Show("Driver updated successfully!");
                this.Close();
            }
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id) || id <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtId, "Please enter a valid Id.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtId, null);
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
