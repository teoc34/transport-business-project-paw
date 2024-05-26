using System;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    public partial class DeleteRoute : Form
    {
        private TransportContext _context;

        public DeleteRoute()
        {
            InitializeComponent();
            _context = new TransportContext();
            LoadRoutes();
        }

        private void LoadRoutes()
        {
            var routes = _context.Routes.ToList();
            comboBoxRoutes.DataSource = routes;
            comboBoxRoutes.DisplayMember = "StartLocation";
            comboBoxRoutes.ValueMember = "RouteID";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRouteId = (int)comboBoxRoutes.SelectedValue;
            var route = _context.Routes.FirstOrDefault(r => r.RouteID == selectedRouteId);
            if (route != null)
            {
                _context.Routes.Remove(route);
                _context.SaveChanges();
                MessageBox.Show("Route deleted successfully.");
                this.Close();
            }
        }

        private void DeleteRoute_Load(object sender, EventArgs e)
        {

        }
    }
}
