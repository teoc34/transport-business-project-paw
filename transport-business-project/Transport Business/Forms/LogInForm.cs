using System.Xml.Linq;
using transport_business_project.Transport_Business.Forms;

namespace transport_business_project
{
    public partial class LogInForm : Form
    {
        private TextBox txtName = new TextBox();
        private TextBox txtPassword = new TextBox();
        private Button BtnLogin = new Button();
        private Button BtnCancel = new Button();
        private Button BtnSignup = new Button();

        public LogInForm()
        {
            InitializeComponent();
            this.Controls.Add(txtName);
            this.Controls.Add(txtPassword);
            this.Controls.Add(BtnLogin);
            this.Controls.Add(BtnCancel);
            this.Controls.Add(BtnSignup);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPassword.Text == "password")
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(); // Assuming you have a SignUpForm
            signUpForm.Show();
            this.Hide(); // Optionally hide the login form
        }


    }
}