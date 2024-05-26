using System;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Update
{
    public partial class UpdateDriver : Form
    {
        private TransportContext _context;
        private Driver selectedDriver;

        public UpdateDriver()
        {
            InitializeComponent();
            _context = new TransportContext();
            LoadDrivers();
        }

        private void LoadDrivers()
        {
            var drivers = _context.Drivers.ToList();
            comboBoxDrivers.DataSource = drivers;
            comboBoxDrivers.DisplayMember = "Name";
            comboBoxDrivers.ValueMember = "Id";
        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDriverId = (int)comboBoxDrivers.SelectedValue;
            selectedDriver = _context.Drivers.FirstOrDefault(d => d.Id == selectedDriverId);
            if (selectedDriver != null)
            {
                txtName.Text = selectedDriver.Name;
                txtLicenseNumber.Text = selectedDriver.LicenseNumber;
                txtYearsOfExperience.Text = selectedDriver.YearsOfExperience.ToString();
                txtMake.Text = selectedDriver.Make;
                txtPlateNumber.Text = selectedDriver.PlateNumber;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                selectedDriver.Name = txtName.Text;
                selectedDriver.LicenseNumber = txtLicenseNumber.Text;
                selectedDriver.YearsOfExperience = int.Parse(txtYearsOfExperience.Text);
                selectedDriver.Make = txtMake.Text;
                selectedDriver.PlateNumber = txtPlateNumber.Text;

                _context.SaveChanges();
                MessageBox.Show("Driver updated successfully.");
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
    }
}
