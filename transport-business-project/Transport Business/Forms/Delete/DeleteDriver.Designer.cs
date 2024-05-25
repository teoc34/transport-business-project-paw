using System;
using System.Windows.Forms;

namespace transport_business_project.Transport_Business.Forms.Delete
{
    partial class DeleteDriver
    {
        private Label lblId;
        private TextBox txtId;
        private Button btnDelete;
        private ErrorProvider errorProvider;

        private void InitializeComponent()
        {
            this.lblId = new Label();
            this.txtId = new TextBox();
            this.btnDelete = new Button();
            this.errorProvider = new ErrorProvider();

            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";

            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;

            // 
            // DeleteDriver
            // 
            this.ClientSize = new System.Drawing.Size(220, 80);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Name = "DeleteDriver";
            this.Text = "Delete Driver";
        }
    }
}
