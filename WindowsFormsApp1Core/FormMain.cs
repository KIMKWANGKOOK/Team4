using System;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormMain : Form
    {
        private FormWorkInstruction formWorkInstruction;
        private FormWorkPerformance formWorkPerformance;
        private FormMonthAttend formMonthAttend;
        private FormToPerformance formToPerformance;
        private FormProblemManager formProblemManager;
        private Components.Dashboard.DashboardForm dashboardForm; // 대시보드 폼 추가

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menuStrip = new MenuStrip();
            this.menuWorkInstruction = new ToolStripMenuItem();
            this.menuWorkPerformance = new ToolStripMenuItem();
            this.menuMonthAttend = new ToolStripMenuItem();
            this.menuToPerformance = new ToolStripMenuItem();
            this.menuProblemManager = new ToolStripMenuItem();
            this.menuDashboard = new ToolStripMenuItem(); // 대시보드 메뉴 항목 추가

            this.menuStrip.Items.AddRange(new ToolStripItem[]
            {
                this.menuWorkInstruction,
                this.menuWorkPerformance,
                this.menuMonthAttend,
                this.menuToPerformance,
                this.menuProblemManager,
                this.menuDashboard // 대시보드 메뉴 항목 추가
            });

            this.menuWorkInstruction.Text = "작업지시";
            this.menuWorkPerformance.Text = "작업실적";
            this.menuMonthAttend.Text = "월별근태";
            this.menuToPerformance.Text = "계획 및 실적";
            this.menuProblemManager.Text = "문제 관리";
            this.menuDashboard.Text = "대시보드"; // 대시보드 텍스트 설정

            this.menuWorkInstruction.Click += new EventHandler(this.MenuWorkInstruction_Click);
            this.menuWorkPerformance.Click += new EventHandler(this.MenuWorkPerformance_Click);
            this.menuMonthAttend.Click += new EventHandler(this.MenuMonthAttend_Click);
            this.menuToPerformance.Click += new EventHandler(this.MenuToPerformance_Click);
            this.menuProblemManager.Click += new EventHandler(this.MenuProblemManager_Click);
            this.menuDashboard.Click += new EventHandler(this.MenuDashboard_Click); // 대시보드 클릭 이벤트 추가

            this.MainMenuStrip = this.menuStrip;
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();

            // Set form properties
            this.Text = "생산 관리 시스템";
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3B4E"); // Tech Blue
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0"); // Grey
            this.ResumeLayout(false);
            this.PerformLayout();

            // Initialize forms
            formWorkInstruction = new FormWorkInstruction { MdiParent = this };
            formWorkPerformance = new FormWorkPerformance { MdiParent = this };
            formMonthAttend = new FormMonthAttend { MdiParent = this };
            formToPerformance = new FormToPerformance { MdiParent = this };
            formProblemManager = new FormProblemManager { MdiParent = this };
            dashboardForm = new Components.Dashboard.DashboardForm { MdiParent = this }; // 대시보드 폼 초기화
        }

        private void MenuWorkInstruction_Click(object sender, EventArgs e)
        {
            formWorkInstruction.Show();
            formWorkInstruction.BringToFront();
        }

        private void MenuWorkPerformance_Click(object sender, EventArgs e)
        {
            formWorkPerformance.Show();
            formWorkPerformance.BringToFront();
        }

        private void MenuMonthAttend_Click(object sender, EventArgs e)
        {
            formMonthAttend.Show();
            formMonthAttend.BringToFront();
        }

        private void MenuToPerformance_Click(object sender, EventArgs e)
        {
            formToPerformance.Show();
            formToPerformance.BringToFront();
        }

        private void MenuProblemManager_Click(object sender, EventArgs e)
        {
            formProblemManager.Show();
            formProblemManager.BringToFront();
        }

        private void MenuDashboard_Click(object sender, EventArgs e) // 대시보드 클릭 이벤트 핸들러
        {
            dashboardForm.Show();
            dashboardForm.BringToFront();
        }

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuWorkInstruction;
        private ToolStripMenuItem menuWorkPerformance;
        private ToolStripMenuItem menuMonthAttend;
        private ToolStripMenuItem menuToPerformance;
        private ToolStripMenuItem menuProblemManager;
        private ToolStripMenuItem menuDashboard; // 대시보드 메뉴 항목
    }
}
