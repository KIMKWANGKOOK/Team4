using System;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    static class Program
    {
        /// <summary>
        /// 애플리케이션의 메인 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
