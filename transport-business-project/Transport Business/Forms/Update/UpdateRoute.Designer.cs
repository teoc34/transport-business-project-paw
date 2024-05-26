namespace transport_business_project.Transport_Business.Forms.Update
{
    partial class UpdateRoute
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxRoutes;
        private Label lblStartLocation;
        private TextBox txtStartLocation;
        private Label lblEndLocation;
        private TextBox txtEndLocation;
        private Label lblDistance;
        private TextBox txtDistance;
        private Label lblEstimatedTime;
        private TextBox txtEstimatedTime;
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
            comboBoxRoutes = new ComboBox();
            lblStartLocation = new Label();
            txtStartLocation = new TextBox();
            lblEndLocation = new Label();
            txtEndLocation = new TextBox();
            lblDistance = new Label();
            txtDistance = new TextBox();
            lblEstimatedTime = new Label();
            txtEstimatedTime = new TextBox();
            btnSave = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // comboBoxRoutes
            // 
            comboBoxRoutes.FormattingEnabled = true;
            comboBoxRoutes.Location = new Point(14, 14);
            comboBoxRoutes.Margin = new Padding(4, 3, 4, 3);
            comboBoxRoutes.Name = "comboBoxRoutes";
            comboBoxRoutes.Size = new Size(303, 23);
            comboBoxRoutes.TabIndex = 0;
            comboBoxRoutes.SelectedIndexChanged += comboBoxRoutes_SelectedIndexChanged;
            // 
            // lblStartLocation
            // 
            lblStartLocation.AutoSize = true;
            lblStartLocation.Location = new Point(14, 53);
            lblStartLocation.Margin = new Padding(4, 0, 4, 0);
            lblStartLocation.Name = "lblStartLocation";
            lblStartLocation.Size = new Size(83, 15);
            lblStartLocation.TabIndex = 1;
            lblStartLocation.Text = "Start Location:";
            // 
            // txtStartLocation
            // 
            txtStartLocation.Location = new Point(14, 72);
            txtStartLocation.Margin = new Padding(4, 3, 4, 3);
            txtStartLocation.Name = "txtStartLocation";
            txtStartLocation.Size = new Size(303, 23);
            txtStartLocation.TabIndex = 2;
            txtStartLocation.Validating += txtStartLocation_Validating;
            // 
            // lblEndLocation
            // 
            lblEndLocation.AutoSize = true;
            lblEndLocation.Location = new Point(14, 110);
            lblEndLocation.Margin = new Padding(4, 0, 4, 0);
            lblEndLocation.Name = "lblEndLocation";
            lblEndLocation.Size = new Size(79, 15);
            lblEndLocation.TabIndex = 3;
            lblEndLocation.Text = "End Location:";
            // 
            // txtEndLocation
            // 
            txtEndLocation.Location = new Point(14, 128);
            txtEndLocation.Margin = new Padding(4, 3, 4, 3);
            txtEndLocation.Name = "txtEndLocation";
            txtEndLocation.Size = new Size(303, 23);
            txtEndLocation.TabIndex = 4;
            txtEndLocation.Validating += txtEndLocation_Validating;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(14, 166);
            lblDistance.Margin = new Padding(4, 0, 4, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(55, 15);
            lblDistance.TabIndex = 5;
            lblDistance.Text = "Distance:";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(14, 185);
            txtDistance.Margin = new Padding(4, 3, 4, 3);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(303, 23);
            txtDistance.TabIndex = 6;
            txtDistance.Validating += txtDistance_Validating;
            // 
            // lblEstimatedTime
            // 
            lblEstimatedTime.AutoSize = true;
            lblEstimatedTime.Location = new Point(14, 223);
            lblEstimatedTime.Margin = new Padding(4, 0, 4, 0);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(91, 15);
            lblEstimatedTime.TabIndex = 7;
            lblEstimatedTime.Text = "Estimated Time:";
            // 
            // txtEstimatedTime
            // 
            txtEstimatedTime.Location = new Point(14, 241);
            txtEstimatedTime.Margin = new Padding(4, 3, 4, 3);
            txtEstimatedTime.Name = "txtEstimatedTime";
            txtEstimatedTime.Size = new Size(303, 23);
            txtEstimatedTime.TabIndex = 8;
            txtEstimatedTime.Validating += txtEstimatedTime_Validating;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(230, 271);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // UpdateRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 312);
            Controls.Add(btnSave);
            Controls.Add(txtEstimatedTime);
            Controls.Add(lblEstimatedTime);
            Controls.Add(txtDistance);
            Controls.Add(lblDistance);
            Controls.Add(txtEndLocation);
            Controls.Add(lblEndLocation);
            Controls.Add(txtStartLocation);
            Controls.Add(lblStartLocation);
            Controls.Add(comboBoxRoutes);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateRoute";
            Text = "Update Route";
            Load += UpdateRoute_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

