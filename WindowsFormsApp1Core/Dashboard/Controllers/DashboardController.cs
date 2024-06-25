using System;
using WorkManagementSystem.Components.Dashboard.Services;

namespace WorkManagementSystem.Components.Dashboard.Controllers
{
    public class DashboardController
    {
        private DashboardService _dashboardService;

        public DashboardController()
        {
            _dashboardService = new DashboardService();
        }

        public void LoadDashboardData()
        {
            var data = _dashboardService.GetDashboardData();
            // 데이터 처리 로직
        }
    }
}
