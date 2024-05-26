using System;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Add
{
    public partial class AddDriver : Form
    {
        private TransportContext _context;

        public AddDriver()
        {
            InitializeComponent();
            _context = new TransportContext();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var driver = new Driver
                {
                    Name = txtName.Text,
                    LicenseNumber = txtLicenseNumber.Text,
                    YearsOfExperience = int.Parse(txtYearsOfExperience.Text),
                    Make = txtMake.Text,
                    PlateNumber = txtPlateNumber.Text
                };

                _context.Drivers.Add(driver);
                _context.SaveChanges();
                MessageBox.Show("Driver added successfully.");
                this.Close();
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtName, "");
            }
        }

        private void txtLicenseNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLicenseNumber, "License Number is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLicenseNumber, "");
            }
        }

        private void txtYearsOfExperience_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(txtYearsOfExperience.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(txtYearsOfExperience, "Invalid number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtYearsOfExperience, "");
            }
        }

        private void txtMake_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtMake, "Make is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMake, "");
            }
        }

        private void txtPlateNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlateNumber.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPlateNumber, "Plate Number is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPlateNumber, "");
            }
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {

        }
    }
}
