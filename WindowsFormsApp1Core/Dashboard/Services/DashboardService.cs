using System;
using System.Collections.Generic;
using WorkManagementSystem.Components.Dashboard.Models;

namespace WorkManagementSystem.Components.Dashboard.Services
{
    public class DashboardService
    {
        public DashboardData GetDashboardData()
        {
            return new DashboardData
            {
                CurrentStatus = "Running",
                KPI = "85%",
                Notifications = "No issues",
                ProductionData = new List<ChartData>
                {
                    new ChartData { Date = DateTime.Now.AddDays(-6), Value = 100 },
                    new ChartData { Date = DateTime.Now.AddDays(-5), Value = 200 },
                    new ChartData { Date = DateTime.Now.AddDays(-4), Value = 300 },
                    new ChartData { Date = DateTime.Now.AddDays(-3), Value = 400 },
                    new ChartData { Date = DateTime.Now.AddDays(-2), Value = 500 },
                    new ChartData { Date = DateTime.Now.AddDays(-1), Value = 600 },
                    new ChartData { Date = DateTime.Now, Value = 700 }
                },
                DefectRateData = new List<ChartData>
                {
                    new ChartData { Date = DateTime.Now.AddDays(-6), Value = 1 },
                    new ChartData { Date = DateTime.Now.AddDays(-5), Value = 2 },
                    new ChartData { Date = DateTime.Now.AddDays(-4), Value = 1.5 },
                    new ChartData { Date = DateTime.Now.AddDays(-3), Value = 2.5 },
                    new ChartData { Date = DateTime.Now.AddDays(-2), Value = 3 },
                    new ChartData { Date = DateTime.Now.AddDays(-1), Value = 2.2 },
                    new ChartData { Date = DateTime.Now, Value = 2.8 }
                }
            };
        }
    }
}
