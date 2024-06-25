namespace WorkManagementSystem
{
    partial class FormDetails
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDetails;

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
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(12, 12);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(360, 237);
            this.txtDetails.TabIndex = 0;
            // 
            // FormDetails
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtDetails);
            this.Name = "FormDetails";
            this.Text = "상세 정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
