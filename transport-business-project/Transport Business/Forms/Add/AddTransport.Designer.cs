namespace transport_business_project.Transport_Business.Forms.Add
{
    partial class AddTransport
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMake;
        private TextBox txtMake;
        private Label lblMaintenanceDate;
        private DateTimePicker dtpMaintenanceDate;
        private Label lblLicensePlate;
        private TextBox txtLicensePlate;
        private Label lblTypes;
        private TextBox txtTypes;
        private Button btnSave;
        private ErrorProvider errorProvider;

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
            components = new System.ComponentModel.Container();
            lblMake = new Label();
            txtMake = new TextBox();
            lblMaintenanceDate = new Label();
            dtpMaintenanceDate = new DateTimePicker();
            lblLicensePlate = new Label();
            txtLicensePlate = new TextBox();
            btnSave = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(14, 17);
            lblMake.Margin = new Padding(4, 0, 4, 0);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(39, 15);
            lblMake.TabIndex = 0;
            lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(18, 36);
            txtMake.Margin = new Padding(4, 3, 4, 3);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(299, 23);
            txtMake.TabIndex = 1;
            txtMake.Validating += txtMake_Validating;
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.AutoSize = true;
            lblMaintenanceDate.Location = new Point(14, 74);
            lblMaintenanceDate.Margin = new Padding(4, 0, 4, 0);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(106, 15);
            lblMaintenanceDate.TabIndex = 2;
            lblMaintenanceDate.Text = "Maintenance Date:";
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Location = new Point(18, 92);
            dtpMaintenanceDate.Margin = new Padding(4, 3, 4, 3);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(299, 23);
            dtpMaintenanceDate.TabIndex = 3;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Location = new Point(14, 130);
            lblLicensePlate.Margin = new Padding(4, 0, 4, 0);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(78, 15);
            lblLicensePlate.TabIndex = 4;
            lblLicensePlate.Text = "License Plate:";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(18, 149);
            txtLicensePlate.Margin = new Padding(4, 3, 4, 3);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(299, 23);
            txtLicensePlate.TabIndex = 5;
            txtLicensePlate.Validating += txtLicensePlate_Validating;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(229, 195);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddTransport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 238);
            Controls.Add(btnSave);
            Controls.Add(txtLicensePlate);
            Controls.Add(lblLicensePlate);
            Controls.Add(dtpMaintenanceDate);
            Controls.Add(lblMaintenanceDate);
            Controls.Add(txtMake);
            Controls.Add(lblMake);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddTransport";
            Text = "Add Transport";
            Load += AddTransport_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
