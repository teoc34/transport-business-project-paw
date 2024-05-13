namespace transport_business_project.Transport_Business.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCancel = new Button();
            BtnLogin = new Button();
            BtnSignup = new Button();
            label6 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(405, 290);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(89, 25);
            BtnCancel.TabIndex = 21;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(130, 193);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(89, 25);
            BtnLogin.TabIndex = 20;
            BtnLogin.Text = "Log In";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnSignup
            // 
            BtnSignup.Location = new Point(349, 358);
            BtnSignup.Name = "BtnSignup";
            BtnSignup.Size = new Size(75, 25);
            BtnSignup.TabIndex = 17;
            BtnSignup.Text = "Sign Up";
            BtnSignup.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 176);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 16;
            label6.Text = "Actions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(193, 70);
            label1.Name = "label1";
            label1.Size = new Size(399, 40);
            label1.TabIndex = 12;
            label1.Text = "Employee Dashboard";
            label1.Click += label1_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCancel);
            Controls.Add(BtnLogin);
            Controls.Add(BtnSignup);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnLogin;
        private Button BtnSignup;
        private Label label6;
        private Label label1;
    }
}