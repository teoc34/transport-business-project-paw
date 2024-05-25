using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using transport_business_project.Transport_Business.Forms.Add;
using transport_business_project.Transport_Business.Forms.Delete;
using transport_business_project.Transport_Business.Forms.Update;
using transport_business_project.Classes;
using transport_business_project.Utilities;

namespace transport_business_project.Transport_Business.Forms
{
    public partial class MainForm : Form
    {
        private const string DriverFilePath = "drivers.xml";
        private const string RouteFilePath = "routes.xml";
        private const string TransportFilePath = "transports.xml";

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            contextMenuUpdate.Show(btnUpdate, new Point(0, btnUpdate.Height));
            toolStripStatusLabel.Text = "Update button clicked.";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            contextMenuDelete.Show(btnDelete, new Point(0, btnDelete.Height));
            toolStripStatusLabel.Text = "Delete button clicked.";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            contextMenuAdd.Show(btnAdd, new Point(0, btnAdd.Height));
            toolStripStatusLabel.Text = "Add button clicked.";
        }

        private void UpdateDriver_Click(object sender, EventArgs e)
        {
            UpdateDriver form = new UpdateDriver();
            form.ShowDialog();
        }

        private void UpdateTransport_Click(object sender, EventArgs e)
        {
            UpdateTransport form = new UpdateTransport();
            form.ShowDialog();
        }

        private void UpdateRoute_Click(object sender, EventArgs e)
        {
            UpdateRoute form = new UpdateRoute();
            form.ShowDialog();
        }

        private void DeleteDriver_Click(object sender, EventArgs e)
        {
            DeleteDriver form = new DeleteDriver();
            form.ShowDialog();
        }

        private void DeleteTransport_Click(object sender, EventArgs e)
        {
            DeleteTransport form = new DeleteTransport();
            form.ShowDialog();
        }

        private void DeleteRoute_Click(object sender, EventArgs e)
        {
            DeleteRoute form = new DeleteRoute();
            form.ShowDialog();
        }

        private void AddDriver_Click(object sender, EventArgs e)
        {
            AddDriver form = new AddDriver();
            form.ShowDialog();
        }

        private void AddTransport_Click(object sender, EventArgs e)
        {
            AddTransport form = new AddTransport();
            form.ShowDialog();
        }

        private void AddRoute_Click(object sender, EventArgs e)
        {
            AddRoute form = new AddRoute();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load data if necessary
        }

        private void ExportReport()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text file (*.txt)|*.txt";
                    saveFileDialog.Title = "Export Report";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string reportFilePath = saveFileDialog.FileName;
                        using (StreamWriter writer = new StreamWriter(reportFilePath))
                        {
                            writer.WriteLine("Transport Management System Report");
                            writer.WriteLine("==================================");
                            writer.WriteLine();

                            // Export Drivers
                            if (File.Exists(DriverFilePath))
                            {
                                List<Driver> drivers = SerializationUtility.DeserializeFromFile<List<Driver>>(DriverFilePath);
                                writer.WriteLine("Drivers:");
                                writer.WriteLine("--------");
                                foreach (var driver in drivers)
                                {
                                    writer.WriteLine($"ID: {driver.Id}");
                                    writer.WriteLine($"Name: {driver.Name}");
                                    writer.WriteLine($"License Number: {driver.LicenseNumber}");
                                    writer.WriteLine($"Years of Experience: {driver.YearsOfExperience}");
                                    writer.WriteLine($"Make: {driver.Make}");
                                    writer.WriteLine($"Plate Number: {driver.PlateNumber}");
                                    writer.WriteLine();
                                }
                            }

                            // Export Routes
                            if (File.Exists(RouteFilePath))
                            {
                                List<Route> routes = SerializationUtility.DeserializeFromFile<List<Route>>(RouteFilePath);
                                writer.WriteLine("Routes:");
                                writer.WriteLine("--------");
                                foreach (var route in routes)
                                {
                                    writer.WriteLine($"Route ID: {route.RouteID}");
                                    writer.WriteLine($"Start Location: {route.StartLocation}");
                                    writer.WriteLine($"End Location: {route.EndLocation}");
                                    writer.WriteLine($"Distance: {route.Distance}");
                                    writer.WriteLine($"Estimated Time: {route.EstimatedTime}");
                                    writer.WriteLine();
                                }
                            }

                            // Export Transports
                            if (File.Exists(TransportFilePath))
                            {
                                List<Transport> transports = SerializationUtility.DeserializeFromFile<List<Transport>>(TransportFilePath);
                                writer.WriteLine("Transports:");
                                writer.WriteLine("-----------");
                                foreach (var transport in transports)
                                {
                                    writer.WriteLine($"Transport ID: {transport.TransportID}");
                                    writer.WriteLine($"Make: {transport.Make}");
                                    writer.WriteLine($"Maintenance Date: {transport.MaintenanceDate.ToShortDateString()}");
                                    writer.WriteLine($"License Plate: {transport.LicensePlate}");
                                    writer.WriteLine($"Types: {string.Join(", ", transport.Types)}");
                                    writer.WriteLine();
                                }
                            }
                        }

                        MessageBox.Show("Report exported successfully!", "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting the report: {ex.Message}", "Export Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewChart()
        {
            ChartForm chartForm = new ChartForm();
            chartForm.ShowDialog();
        }
    }
}
