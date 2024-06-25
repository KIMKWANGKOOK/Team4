using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WorkManagementSystem.Components.Dashboard.Models;

namespace WorkManagementSystem.Components.Dashboard
{
    partial class DashboardForm
    {
        private IContainer components = null;
        private Label lblCurrentStatus;
        private Label lblKPI;
        private Label lblNotifications;
        private Chart chartProduction;
        private Chart chartDefectRate;
        private Panel panelTop;
        private Panel panelCharts;

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
            this.components = new Container();
            this.panelTop = new Panel();
            this.lblCurrentStatus = new Label();
            this.lblKPI = new Label();
            this.lblNotifications = new Label();
            this.panelCharts = new Panel();
            this.chartProduction = new Chart();
            this.chartDefectRate = new Chart();

            ((ISupportInitialize)(this.chartProduction)).BeginInit();
            ((ISupportInitialize)(this.chartDefectRate)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelCharts.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblCurrentStatus);
            this.panelTop.Controls.Add(this.lblKPI);
            this.panelTop.Controls.Add(this.lblNotifications);
            this.panelTop.Dock = DockStyle.Top;
            this.panelTop.Height = 100;
            this.panelTop.BackColor = ColorTranslator.FromHtml("#2E3B4E");

            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            this.lblCurrentStatus.Location = new Point(20, 20);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new Size(100, 13);
            this.lblCurrentStatus.TabIndex = 0;
            this.lblCurrentStatus.Text = "Current Status: Running";

            // 
            // lblKPI
            // 
            this.lblKPI.AutoSize = true;
            this.lblKPI.ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            this.lblKPI.Location = new Point(20, 40);
            this.lblKPI.Name = "lblKPI";
            this.lblKPI.Size = new Size(25, 13);
            this.lblKPI.TabIndex = 1;
            this.lblKPI.Text = "KPI: 85%";

            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            this.lblNotifications.Location = new Point(20, 60);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new Size(100, 13);
            this.lblNotifications.TabIndex = 2;
            this.lblNotifications.Text = "Notifications: No issues";

            // 
            // panelCharts
            // 
            this.panelCharts.Controls.Add(this.chartProduction);
            this.panelCharts.Controls.Add(this.chartDefectRate);
            this.panelCharts.Dock = DockStyle.Fill;
            this.panelCharts.BackColor = ColorTranslator.FromHtml("#E0E0E0");

            // 
            // chartProduction
            // 
            this.chartProduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.chartProduction.Location = new Point(20, 20);
            this.chartProduction.Name = "chartProduction";
            this.chartProduction.Size = new Size(740, 200);
            this.chartProduction.TabIndex = 3;
            this.chartProduction.Text = "Production Chart";
            this.chartProduction.Series.Add(new Series("Production"));
            CustomizeChart(this.chartProduction, "Production");

            // 
            // chartDefectRate
            // 
            this.chartDefectRate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.chartDefectRate.Location = new Point(20, 240);
            this.chartDefectRate.Name = "chartDefectRate";
            this.chartDefectRate.Size = new Size(740, 200);
            this.chartDefectRate.TabIndex = 4;
            this.chartDefectRate.Text = "Defect Rate Chart";
            this.chartDefectRate.Series.Add(new Series("DefectRate"));
            CustomizeChart(this.chartDefectRate, "Defect Rate");

            // 
            // DashboardForm
            // 
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelTop);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            this.ForeColor = ColorTranslator.FromHtml("#E0E0E0");

            ((ISupportInitialize)(this.chartProduction)).EndInit();
            ((ISupportInitialize)(this.chartDefectRate)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCharts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CustomizeChart(Chart chart, string title)
        {
            chart.BackColor = ColorTranslator.FromHtml("#2E3B4E");
            chart.ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            chart.Titles.Add(title);
            chart.Titles[0].Font = new Font("Arial", 14, FontStyle.Bold);
            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].BackColor = ColorTranslator.FromHtml("#E0E0E0");

            chart.Series[0].ChartType = SeriesChartType.Line;
            chart.Series[0].BorderWidth = 3;
            chart.Series[0].Color = ColorTranslator.FromHtml("#FF5733");
        }
    }
}
