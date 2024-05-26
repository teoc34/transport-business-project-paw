namespace transport_business_project.Transport_Business.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuAdd;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem exportReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewChartMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.contextMenuUpdate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Transport Management System";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 60;
            this.Controls.Add(this.lblTitle);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 50);
            this.btnUpdate.Text = "&Update";  // Alt + U
            this.btnUpdate.BackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.Controls.Add(this.btnUpdate);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(212, 50);
            this.btnDelete.Text = "&Delete";  // Alt + D
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            this.Controls.Add(this.btnDelete);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 50);
            this.btnAdd.Text = "&Add";  // Alt + A
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.Controls.Add(this.btnAdd);
            // 
            // contextMenuUpdate
            // 
            this.contextMenuUpdate.Items.Add("Update Driver", null, UpdateDriver_Click);
            this.contextMenuUpdate.Items.Add("Update Transport", null, UpdateTransport_Click);
            this.contextMenuUpdate.Items.Add("Update Route", null, UpdateRoute_Click);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Items.Add("Delete Driver", null, DeleteDriver_Click);
            this.contextMenuDelete.Items.Add("Delete Transport", null, DeleteTransport_Click);
            this.contextMenuDelete.Items.Add("Delete Route", null, DeleteRoute_Click);
            // 
            // contextMenuAdd
            // 
            this.contextMenuAdd.Items.Add("Add Driver", null, AddDriver_Click);
            this.contextMenuAdd.Items.Add("Add Transport", null, AddTransport_Click);
            this.contextMenuAdd.Items.Add("Add Route", null, AddRoute_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                new System.Windows.Forms.ToolStripMenuItem("File", null, new System.Windows.Forms.ToolStripMenuItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("Exit", null, ExitMenuItem_Click)
                }),
                new System.Windows.Forms.ToolStripMenuItem("Edit", null, new System.Windows.Forms.ToolStripMenuItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("Add", null, BtnAdd_Click),
                    new System.Windows.Forms.ToolStripMenuItem("Update", null, BtnUpdate_Click),
                    new System.Windows.Forms.ToolStripMenuItem("Delete", null, BtnDelete_Click)
                }),
                new System.Windows.Forms.ToolStripMenuItem("Report", null, new System.Windows.Forms.ToolStripMenuItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("Export Report", null, ExportReportMenuItem_Click)
                }),
                new System.Windows.Forms.ToolStripMenuItem("View", null, new System.Windows.Forms.ToolStripMenuItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("View Chart", null, ViewChartMenuItem_Click)
                })
            });
            this.Controls.Add(this.menuStrip);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                new System.Windows.Forms.ToolStripButton("Add", null, BtnAdd_Click),
                new System.Windows.Forms.ToolStripButton("Update", null, BtnUpdate_Click),
                new System.Windows.Forms.ToolStripButton("Delete", null, BtnDelete_Click)
            });
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.Add(this.toolStripStatusLabel);
            this.Controls.Add(this.statusStrip);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Name = "MainForm";
            this.Text = "Transport Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
