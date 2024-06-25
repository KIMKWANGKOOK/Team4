using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormWorkPerformance : Form
    {
        private BindingList <WorkPerformance> workPerformances;

        public FormWorkPerformance()
        {
            InitializeComponent();
            workPerformances = new BindingList<WorkPerformance>();
            LoadWorkPerformances();
        }

        private void LoadWorkPerformances()
        {
            dataGridWorkPerformances.DefaultCellStyle.ForeColor = Color.Black;
            dataGridWorkPerformances.DataSource = null;
            dataGridWorkPerformances.DataSource = workPerformances;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var performance = new WorkPerformance
                {
                    TaskName = txtTaskName.Text,
                    Date = datePicker.Value,
                    Worker = txtWorker.Text,
                    Status = comboBoxStatus.SelectedItem.ToString()
                };

                workPerformances.Add(performance);
                LoadWorkPerformances();
                ClearInputs();
                MessageBox.Show("작업 실적이 저장되었습니다.");
            }
        }

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

                    LoadWorkPerformances();
                    ClearInputs();
                    MessageBox.Show("작업 실적이 수정되었습니다.");
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridWorkPerformances.CurrentRow?.DataBoundItem is WorkPerformance selectedWorkPerformance)
            {
                workPerformances.Remove(selectedWorkPerformance);
                LoadWorkPerformances();
                ClearInputs();
                MessageBox.Show("작업 실적이 삭제되었습니다.");
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }

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

            return true;
        }

        private void ClearInputs()
        {
            txtTaskName.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            txtWorker.Text = string.Empty;
            comboBoxStatus.SelectedItem = null;
        }

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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // 엑셀로 내보내기 구현
            // 필요한 패키지 참조 추가 필요 (예: EPPlus)
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {

        }
    }

    public class WorkPerformance
    {
        public string TaskName { get; set; }
        public DateTime Date { get; set; }
        public string Worker { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{TaskName} - {Date.ToShortDateString()} - {Worker} - {Status}";
        }
    }
}
