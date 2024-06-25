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
            txtDetails = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtDetails
            // 
            txtDetails.Location = new System.Drawing.Point(12, 12);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDetails.Size = new System.Drawing.Size(360, 237);
            txtDetails.TabIndex = 0;
            // 
            // FormDetails
            // 
            ClientSize = new System.Drawing.Size(384, 261);
            Controls.Add(txtDetails);
            Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            Name = "FormDetails";
            Text = "상세 정보";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
