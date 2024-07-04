using System;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin loginForm = new FormLogin();
            Application.Run(loginForm);

            if (loginForm.IsAuthenticated)
            {
                Application.Run(new FormMain());
            }
            else
            {
                MessageBox.Show("로그인이 필요합니다.");
            }
        }
    }
}