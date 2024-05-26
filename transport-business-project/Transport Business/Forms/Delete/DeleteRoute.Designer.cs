namespace transport_business_project.Transport_Business.Forms.Delete
{
    partial class DeleteRoute
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxRoutes;
        private Label lblRouteID;
        private TextBox txtRouteID;
        private Label lblStartLocation;
        private TextBox txtStartLocation;
        private Label lblEndLocation;
        private TextBox txtEndLocation;
        private Label lblDistance;
        private TextBox txtDistance;
        private Label lblEstimatedTime;
        private TextBox txtEstimatedTime;
        private Button btnDelete;

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
            comboBoxRoutes = new ComboBox();
            lblRouteID = new Label();
            txtRouteID = new TextBox();
            lblStartLocation = new Label();
            txtStartLocation = new TextBox();
            lblEndLocation = new Label();
            txtEndLocation = new TextBox();
            lblDistance = new Label();
            txtDistance = new TextBox();
            lblEstimatedTime = new Label();
            txtEstimatedTime = new TextBox();
            btnDelete = new Button();
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
            // 
            // lblRouteID
            // 
            lblRouteID.AutoSize = true;
            lblRouteID.Location = new Point(14, 53);
            lblRouteID.Margin = new Padding(4, 0, 4, 0);
            lblRouteID.Name = "lblRouteID";
            lblRouteID.Size = new Size(55, 15);
            lblRouteID.TabIndex = 1;
            lblRouteID.Text = "Route ID:";
            // 
            // txtRouteID
            // 
            txtRouteID.Location = new Point(14, 72);
            txtRouteID.Margin = new Padding(4, 3, 4, 3);
            txtRouteID.Name = "txtRouteID";
            txtRouteID.ReadOnly = true;
            txtRouteID.Size = new Size(303, 23);
            txtRouteID.TabIndex = 2;
            // 
            // lblStartLocation
            // 
            lblStartLocation.AutoSize = true;
            lblStartLocation.Location = new Point(14, 110);
            lblStartLocation.Margin = new Padding(4, 0, 4, 0);
            lblStartLocation.Name = "lblStartLocation";
            lblStartLocation.Size = new Size(83, 15);
            lblStartLocation.TabIndex = 3;
            lblStartLocation.Text = "Start Location:";
            // 
            // txtStartLocation
            // 
            txtStartLocation.Location = new Point(14, 128);
            txtStartLocation.Margin = new Padding(4, 3, 4, 3);
            txtStartLocation.Name = "txtStartLocation";
            txtStartLocation.ReadOnly = true;
            txtStartLocation.Size = new Size(303, 23);
            txtStartLocation.TabIndex = 4;
            // 
            // lblEndLocation
            // 
            lblEndLocation.AutoSize = true;
            lblEndLocation.Location = new Point(14, 166);
            lblEndLocation.Margin = new Padding(4, 0, 4, 0);
            lblEndLocation.Name = "lblEndLocation";
            lblEndLocation.Size = new Size(79, 15);
            lblEndLocation.TabIndex = 5;
            lblEndLocation.Text = "End Location:";
            // 
            // txtEndLocation
            // 
            txtEndLocation.Location = new Point(14, 185);
            txtEndLocation.Margin = new Padding(4, 3, 4, 3);
            txtEndLocation.Name = "txtEndLocation";
            txtEndLocation.ReadOnly = true;
            txtEndLocation.Size = new Size(303, 23);
            txtEndLocation.TabIndex = 6;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Location = new Point(14, 223);
            lblDistance.Margin = new Padding(4, 0, 4, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(55, 15);
            lblDistance.TabIndex = 7;
            lblDistance.Text = "Distance:";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(14, 241);
            txtDistance.Margin = new Padding(4, 3, 4, 3);
            txtDistance.Name = "txtDistance";
            txtDistance.ReadOnly = true;
            txtDistance.Size = new Size(303, 23);
            txtDistance.TabIndex = 8;
            // 
            // lblEstimatedTime
            // 
            lblEstimatedTime.AutoSize = true;
            lblEstimatedTime.Location = new Point(14, 279);
            lblEstimatedTime.Margin = new Padding(4, 0, 4, 0);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(91, 15);
            lblEstimatedTime.TabIndex = 9;
            lblEstimatedTime.Text = "Estimated Time:";
            // 
            // txtEstimatedTime
            // 
            txtEstimatedTime.Location = new Point(14, 298);
            txtEstimatedTime.Margin = new Padding(4, 3, 4, 3);
            txtEstimatedTime.Name = "txtEstimatedTime";
            txtEstimatedTime.ReadOnly = true;
            txtEstimatedTime.Size = new Size(303, 23);
            txtEstimatedTime.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(230, 328);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 368);
            Controls.Add(btnDelete);
            Controls.Add(txtEstimatedTime);
            Controls.Add(lblEstimatedTime);
            Controls.Add(txtDistance);
            Controls.Add(lblDistance);
            Controls.Add(txtEndLocation);
            Controls.Add(lblEndLocation);
            Controls.Add(txtStartLocation);
            Controls.Add(lblStartLocation);
            Controls.Add(txtRouteID);
            Controls.Add(lblRouteID);
            Controls.Add(comboBoxRoutes);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DeleteRoute";
            Text = "Delete Route";
            Load += DeleteRoute_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
