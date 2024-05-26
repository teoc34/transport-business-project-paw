namespace transport_business_project.Transport_Business.Forms.Delete
{
    partial class DeleteTransport
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxTransports;
        private System.Windows.Forms.Label lblTransportID;
        private System.Windows.Forms.TextBox txtTransportID;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private System.Windows.Forms.DateTimePicker dtpMaintenanceDate;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.TextBox txtTypes;
        private System.Windows.Forms.Button btnDelete;

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
            this.comboBoxTransports = new System.Windows.Forms.ComboBox();
            this.lblTransportID = new System.Windows.Forms.Label();
            this.txtTransportID = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMaintenanceDate = new System.Windows.Forms.Label();
            this.dtpMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.txtTypes = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTransports
            // 
            this.comboBoxTransports.FormattingEnabled = true;
            this.comboBoxTransports.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTransports.Name = "comboBoxTransports";
            this.comboBoxTransports.Size = new System.Drawing.Size(260, 21);
            this.comboBoxTransports.TabIndex = 0;
            this.comboBoxTransports.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransports_SelectedIndexChanged);
            // 
            // lblTransportID
            // 
            this.lblTransportID.AutoSize = true;
            this.lblTransportID.Location = new System.Drawing.Point(12, 46);
            this.lblTransportID.Name = "lblTransportID";
            this.lblTransportID.Size = new System.Drawing.Size(69, 13);
            this.lblTransportID.TabIndex = 1;
            this.lblTransportID.Text = "Transport ID:";
            // 
            // txtTransportID
            // 
            this.txtTransportID.Location = new System.Drawing.Point(12, 62);
            this.txtTransportID.Name = "txtTransportID";
            this.txtTransportID.ReadOnly = true;
            this.txtTransportID.Size = new System.Drawing.Size(260, 20);
            this.txtTransportID.TabIndex = 2;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(12, 95);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(12, 111);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(260, 20);
            this.txtMake.TabIndex = 4;
            // 
            // lblMaintenanceDate
            // 
            this.lblMaintenanceDate.AutoSize = true;
            this.lblMaintenanceDate.Location = new System.Drawing.Point(12, 144);
            this.lblMaintenanceDate.Name = "lblMaintenanceDate";
            this.lblMaintenanceDate.Size = new System.Drawing.Size(97, 13);
            this.lblMaintenanceDate.TabIndex = 5;
            this.lblMaintenanceDate.Text = "Maintenance Date:";
            // 
            // dtpMaintenanceDate
            // 
            this.dtpMaintenanceDate.Location = new System.Drawing.Point(12, 160);
            this.dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            this.dtpMaintenanceDate.Size = new System.Drawing.Size(260, 20);
            this.dtpMaintenanceDate.TabIndex = 6;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(12, 193);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(74, 13);
            this.lblLicensePlate.TabIndex = 7;
            this.lblLicensePlate.Text = "License Plate:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(12, 209);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.ReadOnly = true;
            this.txtLicensePlate.Size = new System.Drawing.Size(260, 20);
            this.txtLicensePlate.TabIndex = 8;
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(12, 242);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(39, 13);
            this.lblTypes.TabIndex = 9;
            this.lblTypes.Text = "Types:";
            // 
            // txtTypes
            // 
            this.txtTypes.Location = new System.Drawing.Point(12, 258);
            this.txtTypes.Name = "txtTypes";
            this.txtTypes.ReadOnly = true;
            this.txtTypes.Size = new System.Drawing.Size(260, 20);
            this.txtTypes.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(197, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeleteTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTypes);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.dtpMaintenanceDate);
            this.Controls.Add(this.lblMaintenanceDate);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.txtTransportID);
            this.Controls.Add(this.lblTransportID);
            this.Controls.Add(this.comboBoxTransports);
            this.Name = "DeleteTransport";
            this.Text = "Delete Transport";
            this.Load += new System.EventHandler(this.DeleteTransport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
