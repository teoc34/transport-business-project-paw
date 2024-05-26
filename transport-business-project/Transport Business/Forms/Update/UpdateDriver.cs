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
        private Driver _selectedDriver;

        public UpdateDriver()
        {
            InitializeComponent();
            _context = new TransportContext();
            LoadDrivers();
        }

        private void LoadDrivers()
        {
            comboBoxDrivers.DataSource = _context.Drivers.ToList();
            comboBoxDrivers.DisplayMember = "Name";
            comboBoxDrivers.ValueMember = "Id";
        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedDriverId = (int)comboBoxDrivers.SelectedValue;
            _selectedDriver = _context.Drivers.FirstOrDefault(d => d.Id == selectedDriverId);

            if (_selectedDriver != null)
            {
                txtName.Text = _selectedDriver.Name;
                txtLicenseNumber.Text = _selectedDriver.LicenseNumber;
                txtYearsOfExperience.Text = _selectedDriver.YearsOfExperience.ToString();
                txtMake.Text = _selectedDriver.Make;
                txtPlateNumber.Text = _selectedDriver.PlateNumber;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedDriver != null)
            {
                _selectedDriver.Name = txtName.Text;
                _selectedDriver.LicenseNumber = txtLicenseNumber.Text;
                _selectedDriver.YearsOfExperience = int.Parse(txtYearsOfExperience.Text);
                _selectedDriver.Make = txtMake.Text;
                _selectedDriver.PlateNumber = txtPlateNumber.Text;

                _context.SaveChanges();
                MessageBox.Show("Driver updated successfully!");
                this.Close();
            }
        }

        private void UpdateDriver_Load(object sender, EventArgs e)
        {

        }
    }
}
