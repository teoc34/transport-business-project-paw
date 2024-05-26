using System;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    public partial class DeleteDriver : Form
    {
        private TransportContext _context;

        public DeleteDriver()
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedDriverId = (int)comboBoxDrivers.SelectedValue;
            var driver = _context.Drivers.FirstOrDefault(d => d.Id == selectedDriverId);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
                _context.SaveChanges();
                MessageBox.Show("Driver deleted successfully.");
                this.Close();
            }
        }

        private void DeleteDriver_Load(object sender, EventArgs e)
        {

        }
    }
}
