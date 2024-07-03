using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WorkManagementSystem
{
    // FormWorkPerformance 클래스는 작업 실적을 관리하는 폼을 정의합니다.
    public partial class FormWorkPerformance : Form
    {
        // 작업 실적 데이터를 저장하는 바인딩 리스트
        private BindingList<WorkPerformance> workPerformances;

        // 생성자
        public FormWorkPerformance()
        {
            InitializeComponent(); // 폼의 구성 요소를 초기화합니다.
            workPerformances = new BindingList<WorkPerformance>(); // 작업 실적 리스트 초기화
            LoadWorkPerformances(); // 작업 실적 데이터를 로드합니다.
            InitializeCharts(); // 차트를 초기화합니다.
            ShowDefaultCharts(); // 기본 차트를 표시합니다.
        }

        // 작업 실적 데이터를 로드하는 메서드
        private void LoadWorkPerformances()
        {
            dataGridWorkPerformances.DefaultCellStyle.ForeColor = Color.Black;
            dataGridWorkPerformances.DataSource = null;
            dataGridWorkPerformances.DataSource = workPerformances;
        }

        // 차트를 초기화하는 메서드
        private void InitializeCharts()
        {
            InitializeChart(chartWorkPerformance, "금속 작업 실적");
            InitializeChart(chartNonMetalWorkPerformance, "비금속 작업 실적");
            InitializeChart(chartMetalNonMetalWorkPerformance, "금속+비금속 작업 실적");
        }

        // 개별 차트를 초기화하는 메서드
        private void InitializeChart(Chart chart, string title)
        {
            chart.Series.Clear();
            chart.Titles.Clear();

            chart.Titles.Add(title);
            Series series = new Series("작업 실적")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };
            series.Color = Color.FromArgb(46, 59, 78);
            chart.Series.Add(series);

            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisY.Maximum = 5;
        }

        // 기본 차트를 표시하는 메서드
        private void ShowDefaultCharts()
        {
            ShowDefaultChart(chartWorkPerformance, "FR02-A0");
            ShowDefaultChart(chartNonMetalWorkPerformance, "FR02-A1");
            ShowDefaultChart(chartMetalNonMetalWorkPerformance, "FR02-A2");
        }

        // 개별 기본 차트를 표시하는 메서드
        private void ShowDefaultChart(Chart chart, string taskName)
        {
            if (chart.Series.Count == 0) return;

            var series = chart.Series[0];
            series.Points.Clear();
            series.Points.AddXY(taskName, 0); // 기본 차트 표시
        }

        // 차트를 업데이트하는 메서드
        private void UpdateCharts()
        {
            UpdateChart(chartWorkPerformance, "FR02-A0");
            UpdateChart(chartNonMetalWorkPerformance, "FR02-A1");
            UpdateChart(chartMetalNonMetalWorkPerformance, "FR02-A2");
        }

        // 개별 차트를 업데이트하는 메서드
        private void UpdateChart(Chart chart, string taskName)
        {
            if (chart.Series.Count == 0) return;

            var series = chart.Series[0];
            series.Points.Clear();

            var completedTasks = workPerformances.Where(wp => wp.Status == "완료" && wp.TaskName == taskName);
            foreach (var taskGroup in completedTasks.GroupBy(wp => wp.TaskName))
            {
                series.Points.AddXY(taskGroup.Key, taskGroup.Sum(wp => wp.Quantity));
            }
        }

        // 작업 실적을 추가하는 메서드
        public void AddWorkPerformance(WorkPerformance workPerformance)
        {
            workPerformances.Add(workPerformance);
            LoadWorkPerformances();
            UpdateCharts();
        }

        // 저장 버튼 클릭 시 호출되는 메서드
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var performance = new WorkPerformance
                {
                    TaskName = txtTaskName.Text,
                    Date = datePicker.Value,
                    Worker = txtWorker.Text,
                    Status = comboBoxStatus.SelectedItem.ToString(),
                    Quantity = int.Parse(comboBoxQuantity.SelectedItem.ToString()) // 작업 수량 추가
                };

                workPerformances.Add(performance);
                LoadWorkPerformances();
                ClearInputs();
                UpdateCharts();
                MessageBox.Show("작업 실적이 저장되었습니다.");
            }
        }

        // 수정 버튼 클릭 시 호출되는 메서드
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridWorkPerformances.CurrentRow?.DataBoundItem is WorkPerformance selectedWorkPerformance)
            {
                if (ValidateInputs())
                {
                    selectedWorkPerformance.TaskName = txtTaskName.Text;
                    selectedWorkPerformance.Date = datePicker.Value;
                    selectedWorkPerformance.Worker = txtWorker.Text;
                    selectedWorkPerformance.Status = comboBoxStatus.SelectedItem.ToString();
                    selectedWorkPerformance.Quantity = int.Parse(comboBoxQuantity.SelectedItem.ToString()); // 작업 수량 추가

                    LoadWorkPerformances();
                    ClearInputs();
                    UpdateCharts();
                    MessageBox.Show("작업 실적이 수정되었습니다.");
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
            }
        }

        // 삭제 버튼 클릭 시 호출되는 메서드
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridWorkPerformances.CurrentRow?.DataBoundItem is WorkPerformance selectedWorkPerformance)
            {
                workPerformances.Remove(selectedWorkPerformance);
                LoadWorkPerformances();
                ClearInputs();
                UpdateCharts();
                MessageBox.Show("작업 실적이 삭제되었습니다.");
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }

        // 입력을 검증하는 메서드
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("작업명을 입력하세요.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtWorker.Text))
            {
                MessageBox.Show("작업자를 입력하세요.");
                return false;
            }

            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("상태를 선택하세요.");
                return false;
            }

            if (comboBoxQuantity.SelectedItem == null)
            {
                MessageBox.Show("수량을 선택하세요.");
                return false;
            }

            return true;
        }

        // 입력 필드를 초기화하는 메서드
        private void ClearInputs()
        {
            txtTaskName.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            txtWorker.Text = string.Empty;
            comboBoxStatus.SelectedItem = null;
            comboBoxQuantity.SelectedItem = null;
        }

        // 검색 버튼 클릭 시 호출되는 메서드
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.ToLower();
            var filteredPerformances = workPerformances.Where(wp =>
                wp.TaskName.ToLower().Contains(keyword) ||
                wp.Worker.ToLower().Contains(keyword) ||
                wp.Status.ToLower().Contains(keyword)).ToList();

            dataGridWorkPerformances.DataSource = null;
            dataGridWorkPerformances.DataSource = filteredPerformances;
        }

        // 엑셀로 내보내기 버튼 클릭 시 호출되는 메서드
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // 엑셀로 내보내기 구현
            // 필요한 패키지 참조 추가 필요 (예: EPPlus)
        }

        // 이벤트 핸들러 (현재 비어 있음)
        private void lblStatus_Click(object sender, EventArgs e)
        {
        }

        // 이벤트 핸들러 (현재 비어 있음)
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        // 이벤트 핸들러 (현재 비어 있음)
        private void lblTaskName_Click(object sender, EventArgs e)
        {
        }

        // 이벤트 핸들러 (현재 비어 있음)
        private void lblSearch_Click(object sender, EventArgs e)
        {
        }
    }

    // 작업 실적 클래스를 정의합니다.
    public class WorkPerformance
    {
        public string TaskName { get; set; }
        public DateTime Date { get; set; }
        public string Worker { get; set; }
        public string Status { get; set; }
        public int Quantity { get; set; }

        // 작업 실적을 문자열로 표현합니다.
        public override string ToString()
        {
            return $"{TaskName} - {Date.ToShortDateString()} - {Worker} - {Status}";
        }
    }
}
