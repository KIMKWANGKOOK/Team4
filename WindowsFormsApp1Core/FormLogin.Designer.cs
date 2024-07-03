namespace WorkManagementSystem
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;

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
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            txtUsername.Location = new System.Drawing.Point(770, 346);
            txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(349, 35);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            txtPassword.Location = new System.Drawing.Point(770, 462);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(349, 35);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            lblUsername.ForeColor = System.Drawing.SystemColors.Window;
            lblUsername.Location = new System.Drawing.Point(537, 346);
            lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(124, 29);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            lblPassword.ForeColor = System.Drawing.SystemColors.Window;
            lblPassword.Location = new System.Drawing.Point(537, 462);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(120, 29);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            btnLogin.ForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            btnLogin.Location = new System.Drawing.Point(770, 577);
            btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(175, 52);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.Window;
            label1.Location = new System.Drawing.Point(770, 132);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(396, 73);
            label1.TabIndex = 5;
            label1.Text = "생산관리시스템";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 59, 78);
            ClientSize = new System.Drawing.Size(1493, 831);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormLogin";
            Text = "Login";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
    }
}