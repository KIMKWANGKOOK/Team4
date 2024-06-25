using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WorkManagementSystem.Components.Dashboard.Services;
using WorkManagementSystem.Components.Dashboard.Models;

namespace WorkManagementSystem.Components.Dashboard
{
    public partial class DashboardForm : Form
    {
        private DashboardService _dashboardService;

        public DashboardForm()
        {
            InitializeComponent();
            _dashboardService = new DashboardService();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            var data = _dashboardService.GetDashboardData();

            lblCurrentStatus.Text = $"Current Status: {data.CurrentStatus}";
            lblKPI.Text = $"KPI: {data.KPI}";
            lblNotifications.Text = $"Notifications: {data.Notifications}";

            // Bind data to charts
            BindChartData(chartProduction, data.ProductionData, "Date", "Value");
            BindChartData(chartDefectRate, data.DefectRateData, "Date", "Value");
        }

        private void BindChartData(Chart chart, List<ChartData> data, string xValueMember, string yValueMembers)
        {
            chart.Series[0].Points.Clear();
            foreach (var item in data)
            {
                chart.Series[0].Points.AddXY(item.Date, item.Value);
            }
        }
    }
}
