using System;
using System.Collections.Generic;

namespace WorkManagementSystem.Components.Dashboard.Models
{
    public class DashboardData
    {
        public string CurrentStatus { get; set; }
        public string KPI { get; set; }
        public string Notifications { get; set; }
        public List<ChartData> ProductionData { get; set; }
        public List<ChartData> DefectRateData { get; set; }
    }

    public class ChartData
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }
    }
}
