using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    [SupportedOSPlatform("windows10.0.177630")]
    public partial class FormMain : Form
    {
        private FormWorkInstruction formWorkInstruction; // 작업지시 폼
        private FormWorkPerformance formWorkPerformance; // 작업실적 폼
        private FormMonthAttend formMonthAttend; // 월별근태 폼
        private FormToPerformance formToPerformance; // 계획 및 실적 폼
        private FormProblemManager formProblemManager; // 문제 관리 폼
        private Components.Dashboard.DashboardForm dashboardForm; // 대시보드 폼 추가

        public FormMain()
        {
            InitializeComponent(); // 폼 초기화
        }

        // 메인 폼 초기화 메서드
        private void InitializeComponent()
        {
            // 메뉴 스트립과 메뉴 항목들 초기화
            this.menuStrip = new MenuStrip();
            this.menuWorkInstruction = new ToolStripMenuItem();
            this.menuWorkPerformance = new ToolStripMenuItem();
            this.menuMonthAttend = new ToolStripMenuItem();
            this.menuToPerformance = new ToolStripMenuItem();
            this.menuProblemManager = new ToolStripMenuItem();
            this.menuDashboard = new ToolStripMenuItem(); // 대시보드 메뉴 항목 추가

            // 메뉴 항목들을 메뉴 스트립에 추가
            this.menuStrip.Items.AddRange(new ToolStripItem[]
            {
                this.menuWorkInstruction,
                this.menuWorkPerformance,
                this.menuMonthAttend,
                this.menuToPerformance,
                this.menuProblemManager,
                this.menuDashboard // 대시보드 메뉴 항목 추가
            });

            // 각 메뉴 항목의 텍스트 설정
            this.menuWorkInstruction.Text = "작업지시";
            this.menuWorkPerformance.Text = "작업실적";
            this.menuMonthAttend.Text = "월별근태";
            this.menuToPerformance.Text = "계획 및 실적";
            this.menuProblemManager.Text = "문제 관리";
            this.menuDashboard.Text = "대시보드"; // 대시보드 텍스트 설정

            // 각 메뉴 항목에 대한 클릭 이벤트 핸들러 추가
            this.menuWorkInstruction.Click += new EventHandler(this.MenuWorkInstruction_Click);
            this.menuWorkPerformance.Click += new EventHandler(this.MenuWorkPerformance_Click);
            this.menuMonthAttend.Click += new EventHandler(this.MenuMonthAttend_Click);
            this.menuToPerformance.Click += new EventHandler(this.MenuToPerformance_Click);
            this.menuProblemManager.Click += new EventHandler(this.MenuProblemManager_Click);
            this.menuDashboard.Click += new EventHandler(this.MenuDashboard_Click); // 대시보드 클릭 이벤트 추가

            // 메인 폼 설정
            this.MainMenuStrip = this.menuStrip;
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();

            // 폼 속성 설정
            this.Text = "생산 관리 시스템";
            this.IsMdiContainer = true; // 자식 폼을 포함할 수 있도록 설정
            this.WindowState = FormWindowState.Maximized; // 창을 최대화 상태로 설정
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3B4E"); // 배경색 설정
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#E0E0E0"); // 전경색 설정
            this.ResumeLayout(false);
            this.PerformLayout();

            // 자식 폼 초기화
            formWorkInstruction = new FormWorkInstruction { MdiParent = this };
            formWorkPerformance = new FormWorkPerformance { MdiParent = this };
            formMonthAttend = new FormMonthAttend { MdiParent = this };
            formToPerformance = new FormToPerformance { MdiParent = this };
            formProblemManager = new FormProblemManager { MdiParent = this };
            dashboardForm = new Components.Dashboard.DashboardForm { MdiParent = this }; // 대시보드 폼 초기화
        }

        // 작업지시 메뉴 항목 클릭 이벤트 핸들러
        private void MenuWorkInstruction_Click(object sender, EventArgs e)
        {
            formWorkInstruction.Show();
            formWorkInstruction.BringToFront();
        }

        // 작업실적 메뉴 항목 클릭 이벤트 핸들러
        private void MenuWorkPerformance_Click(object sender, EventArgs e)
        {
            formWorkPerformance.Show();
            formWorkPerformance.BringToFront();
        }

        // 월별근태 메뉴 항목 클릭 이벤트 핸들러
        private void MenuMonthAttend_Click(object sender, EventArgs e)
        {
            formMonthAttend.Show();
            formMonthAttend.BringToFront();
        }

        // 계획 및 실적 메뉴 항목 클릭 이벤트 핸들러
        private void MenuToPerformance_Click(object sender, EventArgs e)
        {
            formToPerformance.Show();
            formToPerformance.BringToFront();
        }

        // 문제 관리 메뉴 항목 클릭 이벤트 핸들러
        private void MenuProblemManager_Click(object sender, EventArgs e)
        {
            formProblemManager.Show();
            formProblemManager.BringToFront();
        }

        // 대시보드 메뉴 항목 클릭 이벤트 핸들러
        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            dashboardForm.Show();
            dashboardForm.BringToFront();
        }

        // 폼에 사용되는 컨트롤들 선언
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuWorkInstruction;
        private ToolStripMenuItem menuWorkPerformance;
        private ToolStripMenuItem menuMonthAttend;
        private ToolStripMenuItem menuToPerformance;
        private ToolStripMenuItem menuProblemManager;
        private ToolStripMenuItem menuDashboard; // 대시보드 메뉴 항목
    }
}
