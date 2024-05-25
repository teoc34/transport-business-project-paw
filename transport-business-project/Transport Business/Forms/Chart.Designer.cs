namespace transport_business_project.Transport_Business.Forms
{
    partial class ChartForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.SuspendLayout();
            // 
            // ChartForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ChartForm";
            this.Text = "Statistics Chart";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartForm_Paint);
            this.ResumeLayout(false);
        }
    }
}
