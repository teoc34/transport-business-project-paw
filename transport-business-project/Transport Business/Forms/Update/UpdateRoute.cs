using System;
using System.Linq;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms.Update
{
    public partial class UpdateRoute : Form
    {
        private TransportContext _context;
        private Route selectedRoute;

        public UpdateRoute()
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

        private void comboBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRouteId = (int)comboBoxRoutes.SelectedValue;
            selectedRoute = _context.Routes.FirstOrDefault(r => r.RouteID == selectedRouteId);
            if (selectedRoute != null)
            {
                txtStartLocation.Text = selectedRoute.StartLocation;
                txtEndLocation.Text = selectedRoute.EndLocation;
                txtDistance.Text = selectedRoute.Distance.ToString();
                txtEstimatedTime.Text = selectedRoute.EstimatedTime.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                selectedRoute.StartLocation = txtStartLocation.Text;
                selectedRoute.EndLocation = txtEndLocation.Text;
                selectedRoute.Distance = float.Parse(txtDistance.Text);
                selectedRoute.EstimatedTime = float.Parse(txtEstimatedTime.Text);

                _context.SaveChanges();
                MessageBox.Show("Route updated successfully.");
                this.Close();
            }
        }

        private void txtStartLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStartLocation.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtStartLocation, "Start Location is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtStartLocation, "");
            }
        }

        private void txtEndLocation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEndLocation.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEndLocation, "End Location is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEndLocation, "");
            }
        }

        private void txtDistance_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!float.TryParse(txtDistance.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDistance, "Invalid number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDistance, "");
            }
        }

        private void txtEstimatedTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!float.TryParse(txtEstimatedTime.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEstimatedTime, "Invalid number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEstimatedTime, "");
            }
        }
    }
}
