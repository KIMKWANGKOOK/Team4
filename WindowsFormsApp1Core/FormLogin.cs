using System;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormLogin : Form
    {
        public bool IsAuthenticated { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // 로그인 창을 전체 화면으로 설정
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 여기에 로그인 인증 로직을 추가하세요.
            // 예시로 간단한 조건문을 사용하겠습니다.
            if (txtUsername.Text == "김광국" && txtPassword.Text == "0620")
            {
                IsAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("사용자 이름 또는 비밀번호가 잘못되었습니다.");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
