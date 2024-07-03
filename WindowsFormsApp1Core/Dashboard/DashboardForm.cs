using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WorkManagementSystem.Components.Dashboard.Services;
using WorkManagementSystem.Components.Dashboard.Models;

namespace WorkManagementSystem.Components.Dashboard
{
    // 대시보드 폼을 정의하는 클래스
    public partial class DashboardForm : Form
    {
        // 대시보드 데이터를 처리하는 서비스 인스턴스
        private DashboardService _dashboardService;

        // 대시보드 폼 생성자
        public DashboardForm()
        {
            InitializeComponent(); // 폼 구성 요소 초기화
            _dashboardService = new DashboardService(); // 대시보드 서비스 초기화
            LoadDashboardData(); // 대시보드 데이터 로드
        }

        // 대시보드 데이터를 로드하는 메서드
        private void LoadDashboardData()
        {
            // 대시보드 데이터 서비스에서 데이터 가져오기
            var data = _dashboardService.GetDashboardData();

            // 레이블에 데이터 바인딩
            lblCurrentStatus.Text = $"Current Status: {data.CurrentStatus}";
            lblKPI.Text = $"KPI: {data.KPI}";
            lblNotifications.Text = $"Notifications: {data.Notifications}";

            // 차트에 데이터 바인딩
            BindChartData(chartProduction, data.ProductionData, "Date", "Value");
            BindChartData(chartDefectRate, data.DefectRateData, "Date", "Value");
        }

        // 차트에 데이터를 바인딩하는 메서드
        private void BindChartData(Chart chart, List<ChartData> data, string xValueMember, string yValueMembers)
        {
            chart.Series[0].Points.Clear(); // 기존 차트 데이터 지우기
            foreach (var item in data) // 데이터 항목을 반복
            {
                // 차트에 데이터 추가
                chart.Series[0].Points.AddXY(item.Date, item.Value);
            }
        }
    }
}
