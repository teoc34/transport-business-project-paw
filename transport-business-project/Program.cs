using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using transport_business_project.Data;

namespace transport_business_project.Transport_Business.Forms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ensure database is created
            using (var context = new TransportContext())
            {
                context.Database.Migrate();
            }

            Application.Run(new MainForm());
        }
    }
}
