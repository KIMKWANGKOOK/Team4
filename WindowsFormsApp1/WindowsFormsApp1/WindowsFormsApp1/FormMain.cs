using System;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormMain : Form
    {
        private FormWorkInstruction formWorkInstruction;
        private FormWorkPerformance formWorkPerformance;
        private FormMonthAttend formMonthAttend;
        private FormToPerformance formToPerformance; // 계획 및 실적 폼 추가
        private FormProblemManager formProblemManager;

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

            this.menuStrip.Items.AddRange(new ToolStripItem[]
            {
                this.menuWorkInstruction,
                this.menuWorkPerformance,
                this.menuMonthAttend,
                this.menuToPerformance,
                this.menuProblemManager
            });

            this.menuWorkInstruction.Text = "작업지시";
            this.menuWorkPerformance.Text = "작업실적";
            this.menuMonthAttend.Text = "월별근태";
            this.menuToPerformance.Text = "계획 및 실적";
            this.menuProblemManager.Text = "문제 관리";

            this.menuWorkInstruction.Click += new EventHandler(this.MenuWorkInstruction_Click);
            this.menuWorkPerformance.Click += new EventHandler(this.MenuWorkPerformance_Click);
            this.menuMonthAttend.Click += new EventHandler(this.MenuMonthAttend_Click);
            this.menuToPerformance.Click += new EventHandler(this.MenuToPerformance_Click); // 계획 및 실적 클릭 이벤트 추가
            this.menuProblemManager.Click += new EventHandler(this.MenuProblemManager_Click);

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
            formToPerformance = new FormToPerformance { MdiParent = this }; // 계획 및 실적 폼 초기화
            formProblemManager = new FormProblemManager { MdiParent = this };
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

        private void MenuToPerformance_Click(object sender, EventArgs e) // 계획 및 실적 클릭 이벤트 핸들러
        {
            formToPerformance.Show();
            formToPerformance.BringToFront();
        }

        private void MenuProblemManager_Click(object sender, EventArgs e)
        {
            formProblemManager.Show();
            formProblemManager.BringToFront();
        }

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuWorkInstruction;
        private ToolStripMenuItem menuWorkPerformance;
        private ToolStripMenuItem menuMonthAttend;
        private ToolStripMenuItem menuToPerformance;
        private ToolStripMenuItem menuProblemManager;
    }
}
