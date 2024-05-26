namespace transport_business_project.Transport_Business.Forms.Add
{
    partial class AddRoute
    {
        private System.ComponentModel.IContainer components = null;
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
            // lblStartLocation
            // 
            lblStartLocation.AutoSize = true;
            lblStartLocation.Location = new Point(14, 17);
            lblStartLocation.Margin = new Padding(4, 0, 4, 0);
            lblStartLocation.Name = "lblStartLocation";
            lblStartLocation.Size = new Size(83, 15);
            lblStartLocation.TabIndex = 0;
            lblStartLocation.Text = "Start Location:";
            // 
            // txtStartLocation
            // 
            txtStartLocation.Location = new Point(18, 36);
            txtStartLocation.Margin = new Padding(4, 3, 4, 3);
            txtStartLocation.Name = "txtStartLocation";
            txtStartLocation.Size = new Size(299, 23);
            txtStartLocation.TabIndex = 1;
            txtStartLocation.Validating += txtStartLocation_Validating;
            // 
            // lblEndLocation
            // 
            lblEndLocation.AutoSize = true;
            lblEndLocation.Location = new Point(14, 74);
            lblEndLocation.Margin = new Padding(4, 0, 4, 0);
            lblEndLocation.Name = "lblEndLocation";
            lblEndLocation.Size = new Size(79, 15);
            lblEndLocation.TabIndex = 2;
            lblEndLocation.Text = "End Location:";
            // 
            // txtEndLocation
            // 
            txtEndLocation.Location = new Point(18, 92);
            txtEndLocation.Margin = new Padding(4, 3, 4, 3);
            txtEndLocation.Name = "txtEndLocation";
            txtEndLocation.Size = new Size(299, 23);
            txtEndLocation.TabIndex = 3;
            txtEndLocation.Validating += txtEndLocation_Validating;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(14, 130);
            lblDistance.Margin = new Padding(4, 0, 4, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(55, 15);
            lblDistance.TabIndex = 4;
            lblDistance.Text = "Distance:";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(18, 149);
            txtDistance.Margin = new Padding(4, 3, 4, 3);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(299, 23);
            txtDistance.TabIndex = 5;
            txtDistance.Validating += txtDistance_Validating;
            // 
            // lblEstimatedTime
            // 
            lblEstimatedTime.AutoSize = true;
            lblEstimatedTime.Location = new Point(14, 187);
            lblEstimatedTime.Margin = new Padding(4, 0, 4, 0);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(91, 15);
            lblEstimatedTime.TabIndex = 6;
            lblEstimatedTime.Text = "Estimated Time:";
            // 
            // txtEstimatedTime
            // 
            txtEstimatedTime.Location = new Point(18, 205);
            txtEstimatedTime.Margin = new Padding(4, 3, 4, 3);
            txtEstimatedTime.Name = "txtEstimatedTime";
            txtEstimatedTime.Size = new Size(299, 23);
            txtEstimatedTime.TabIndex = 7;
            txtEstimatedTime.Validating += txtEstimatedTime_Validating;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(230, 247);
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
            // AddRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 287);
            Controls.Add(btnSave);
            Controls.Add(txtEstimatedTime);
            Controls.Add(lblEstimatedTime);
            Controls.Add(txtDistance);
            Controls.Add(lblDistance);
            Controls.Add(txtEndLocation);
            Controls.Add(lblEndLocation);
            Controls.Add(txtStartLocation);
            Controls.Add(lblStartLocation);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddRoute";
            Text = "Add Route";
            Load += AddRoute_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
