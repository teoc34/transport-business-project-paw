using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using transport_business_project.Classes;
using transport_business_project.Utilities;

namespace transport_business_project.Transport_Business.Forms
{
    public partial class ChartForm : Form
    {
        private const string DriverFilePath = "drivers.xml";
        private const string RouteFilePath = "routes.xml";
        private const string TransportFilePath = "transports.xml";

        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int driverCount = 0;
            int routeCount = 0;
            int transportCount = 0;

            if (File.Exists(DriverFilePath))
            {
                List<Driver> drivers = SerializationUtility.DeserializeFromFile<List<Driver>>(DriverFilePath);
                driverCount = drivers.Count;
            }

            if (File.Exists(RouteFilePath))
            {
                List<Route> routes = SerializationUtility.DeserializeFromFile<List<Route>>(RouteFilePath);
                routeCount = routes.Count;
            }

            if (File.Exists(TransportFilePath))
            {
                List<Transport> transports = SerializationUtility.DeserializeFromFile<List<Transport>>(TransportFilePath);
                transportCount = transports.Count;
            }

            Console.WriteLine($"Driver Count: {driverCount}, Route Count: {routeCount}, Transport Count: {transportCount}");

            int barWidth = 50;
            int barSpacing = 20;
            int chartHeight = 300;
            int maxCount = Math.Max(driverCount, Math.Max(routeCount, transportCount));
            int startX = 100;
            int startY = 50;

            if (maxCount == 0)
            {
                maxCount = 1;
            }

            g.FillRectangle(Brushes.White, startX, startY, 3 * (barWidth + barSpacing), chartHeight);
            g.DrawRectangle(Pens.Black, startX, startY, 3 * (barWidth + barSpacing), chartHeight);

            int driverBarHeight = (int)((double)driverCount / maxCount * chartHeight);
            g.FillRectangle(Brushes.Blue, startX, startY + (chartHeight - driverBarHeight), barWidth, driverBarHeight);
            g.DrawRectangle(Pens.Black, startX, startY + (chartHeight - driverBarHeight), barWidth, driverBarHeight);

            int routeBarHeight = (int)((double)routeCount / maxCount * chartHeight);
            g.FillRectangle(Brushes.Green, startX + (barWidth + barSpacing), startY + (chartHeight - routeBarHeight), barWidth, routeBarHeight);
            g.DrawRectangle(Pens.Black, startX + (barWidth + barSpacing), startY + (chartHeight - routeBarHeight), barWidth, routeBarHeight);

            int transportBarHeight = (int)((double)transportCount / maxCount * chartHeight);
            g.FillRectangle(Brushes.Red, startX + 2 * (barWidth + barSpacing), startY + (chartHeight - transportBarHeight), barWidth, transportBarHeight);
            g.DrawRectangle(Pens.Black, startX + 2 * (barWidth + barSpacing), startY + (chartHeight - transportBarHeight), barWidth, transportBarHeight);

            g.DrawString("Drivers", new Font("Arial", 10), Brushes.Black, startX, startY + chartHeight + 10);
            g.DrawString("Routes", new Font("Arial", 10), Brushes.Black, startX + (barWidth + barSpacing), startY + chartHeight + 10);
            g.DrawString("Transports", new Font("Arial", 10), Brushes.Black, startX + 2 * (barWidth + barSpacing), startY + chartHeight + 10);
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
        }
    }
}
