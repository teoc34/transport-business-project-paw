namespace transport_business_project.Transport_Business.Forms.Update
{
    partial class UpdateTransport
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxTransports;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private System.Windows.Forms.DateTimePicker dtpMaintenanceDate;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.TextBox txtTypes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;

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
            this.comboBoxTransports = new System.Windows.Forms.ComboBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMaintenanceDate = new System.Windows.Forms.Label();
            this.dtpMaintenanceDate = new System.Windows.Forms.DateTimePicker();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblTypes = new System.Windows.Forms.Label();
            this.txtTypes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(12, 46);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(12, 62);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(260, 20);
            this.txtMake.TabIndex = 2;
            this.txtMake.Validating += new System.ComponentModel.CancelEventHandler(this.txtMake_Validating);
            // 
            // lblMaintenanceDate
            // 
            this.lblMaintenanceDate.AutoSize = true;
            this.lblMaintenanceDate.Location = new System.Drawing.Point(12, 95);
            this.lblMaintenanceDate.Name = "lblMaintenanceDate";
            this.lblMaintenanceDate.Size = new System.Drawing.Size(97, 13);
            this.lblMaintenanceDate.TabIndex = 3;
            this.lblMaintenanceDate.Text = "Maintenance Date:";
            // 
            // dtpMaintenanceDate
            // 
            this.dtpMaintenanceDate.Location = new System.Drawing.Point(12, 111);
            this.dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            this.dtpMaintenanceDate.Size = new System.Drawing.Size(260, 20);
            this.dtpMaintenanceDate.TabIndex = 4;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(12, 144);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(74, 13);
            this.lblLicensePlate.TabIndex = 5;
            this.lblLicensePlate.Text = "License Plate:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(12, 160);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(260, 20);
            this.txtLicensePlate.TabIndex = 6;
            this.txtLicensePlate.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicensePlate_Validating);
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(12, 193);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(39, 13);
            this.lblTypes.TabIndex = 7;
            this.lblTypes.Text = "Types:";
            // 
            // txtTypes
            // 
            this.txtTypes.Location = new System.Drawing.Point(12, 209);
            this.txtTypes.Name = "txtTypes";
            this.txtTypes.Size = new System.Drawing.Size(260, 20);
            this.txtTypes.TabIndex = 8;
            this.txtTypes.Validating += new System.ComponentModel.CancelEventHandler(this.txtTypes_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UpdateTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTypes);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.dtpMaintenanceDate);
            this.Controls.Add(this.lblMaintenanceDate);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.comboBoxTransports);
            this.Name = "UpdateTransport";
            this.Text = "Update Transport";
            this.Load += new System.EventHandler(this.UpdateTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

