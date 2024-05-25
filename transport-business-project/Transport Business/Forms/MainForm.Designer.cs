using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms
{
    partial class MainForm
    {
        private Label lblTitle;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private ContextMenuStrip contextMenuUpdate;
        private ContextMenuStrip contextMenuDelete;
        private ContextMenuStrip contextMenuAdd;
        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem exportReportMenuItem;
        private ToolStripMenuItem viewChartMenuItem;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Name = "MainForm";
            this.Text = "Transport Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        private void InitializeCustomComponents()
        {
            // Title Label
            lblTitle = new Label();
            lblTitle.Text = "Transport Management System";
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 60;
            this.Controls.Add(lblTitle);

            // MenuStrip
            menuStrip = new MenuStrip();
            var fileMenu = new ToolStripMenuItem("File");
            var exitMenuItem = new ToolStripMenuItem("Exit", null, ExitMenuItem_Click);
            fileMenu.DropDownItems.Add(exitMenuItem);

            var editMenu = new ToolStripMenuItem("Edit");
            var addMenuItem = new ToolStripMenuItem("Add", null, BtnAdd_Click);
            var updateMenuItem = new ToolStripMenuItem("Update", null, BtnUpdate_Click);
            var deleteMenuItem = new ToolStripMenuItem("Delete", null, BtnDelete_Click);
            editMenu.DropDownItems.Add(addMenuItem);
            editMenu.DropDownItems.Add(updateMenuItem);
            editMenu.DropDownItems.Add(deleteMenuItem);
            var reportMenu = new ToolStripMenuItem("Report");
            exportReportMenuItem = new ToolStripMenuItem("Export Report", null, ExportReportMenuItem_Click);
            reportMenu.DropDownItems.Add(exportReportMenuItem);

            var viewMenu = new ToolStripMenuItem("View");
            viewChartMenuItem = new ToolStripMenuItem("View Chart", null, ViewChartMenuItem_Click);
            viewMenu.DropDownItems.Add(viewChartMenuItem);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(editMenu);
            menuStrip.Items.Add(reportMenu);
            menuStrip.Items.Add(viewMenu);
            this.Controls.Add(menuStrip);

            // ToolStrip
            toolStrip = new ToolStrip();
            var addButton = new ToolStripButton("Add", null, BtnAdd_Click);
            var updateButton = new ToolStripButton("Update", null, BtnUpdate_Click);
            var deleteButton = new ToolStripButton("Delete", null, BtnDelete_Click);
            toolStrip.Items.Add(addButton);
            toolStrip.Items.Add(updateButton);
            toolStrip.Items.Add(deleteButton);
            toolStrip.Dock = DockStyle.Top;
            this.Controls.Add(toolStrip);

            // StatusStrip
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            statusStrip.Items.Add(toolStripStatusLabel);
            this.Controls.Add(statusStrip);

            // Update Button
            btnUpdate = new Button();
            btnUpdate.Location = new Point(94, 150);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(212, 50);
            btnUpdate.Text = "&Update";  // Alt + U
            btnUpdate.BackColor = Color.LightGray;
            btnUpdate.Font = new Font("Arial", 12, FontStyle.Regular);
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            this.Controls.Add(btnUpdate);

            // Delete Button
            btnDelete = new Button();
            btnDelete.Location = new Point(94, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(212, 50);
            btnDelete.Text = "&Delete";  // Alt + D
            btnDelete.BackColor = Color.LightGray;
            btnDelete.Font = new Font("Arial", 12, FontStyle.Regular);
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);

            // Add Button
            btnAdd = new Button();
            btnAdd.Location = new Point(94, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(212, 50);
            btnAdd.Text = "&Add";  // Alt + A
            btnAdd.BackColor = Color.LightGray;
            btnAdd.Font = new Font("Arial", 12, FontStyle.Regular);
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            // ContextMenuStrip for Update
            contextMenuUpdate = new ContextMenuStrip();
            contextMenuUpdate.Items.Add("Update Driver", null, UpdateDriver_Click);
            contextMenuUpdate.Items.Add("Update Transport", null, UpdateTransport_Click);
            contextMenuUpdate.Items.Add("Update Route", null, UpdateRoute_Click);

            // ContextMenuStrip for Delete
            contextMenuDelete = new ContextMenuStrip();
            contextMenuDelete.Items.Add("Delete Driver", null, DeleteDriver_Click);
            contextMenuDelete.Items.Add("Delete Transport", null, DeleteTransport_Click);
            contextMenuDelete.Items.Add("Delete Route", null, DeleteRoute_Click);

            // ContextMenuStrip for Add
            contextMenuAdd = new ContextMenuStrip();
            contextMenuAdd.Items.Add("Add Driver", null, AddDriver_Click);
            contextMenuAdd.Items.Add("Add Transport", null, AddTransport_Click);
            contextMenuAdd.Items.Add("Add Route", null, AddRoute_Click);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExportReportMenuItem_Click(object sender, EventArgs e)
        {
            ExportReport();
        }

        private void ViewChartMenuItem_Click(object sender, EventArgs e)
        {
            ViewChart();
        }
    }
}

