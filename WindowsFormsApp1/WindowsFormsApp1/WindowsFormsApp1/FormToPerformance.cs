using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // 이 부분이 필요합니다.
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormToPerformance : Form
    {
        private List<PerformancePlan> performancePlans;

        public FormToPerformance()
        {
            InitializeComponent();
            performancePlans = new List<PerformancePlan>();
            LoadPerformancePlans();
        }

        private void LoadPerformancePlans()
        {
            dataGridPerformancePlans.DataSource = null;
            dataGridPerformancePlans.DataSource = performancePlans;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var performancePlan = new PerformancePlan
                {
                    PlanName = txtPlanName.Text,
                    Description = txtDescription.Text,
                    StartDate = datePickerStart.Value,
                    EndDate = datePickerEnd.Value,
                    Status = comboBoxStatus.SelectedItem.ToString()
                };

                performancePlans.Add(performancePlan);
                LoadPerformancePlans();
                ClearInputs();
                MessageBox.Show("계획이 저장되었습니다.","알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridPerformancePlans.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridPerformancePlans.SelectedRows[0];
                var selectedPlan = selectedRow.DataBoundItem as PerformancePlan;

                if (ValidateInputs())
                {
                    selectedPlan.PlanName = txtPlanName.Text;
                    selectedPlan.Description = txtDescription.Text;
                    selectedPlan.StartDate = datePickerStart.Value;
                    selectedPlan.EndDate = datePickerEnd.Value;
                    selectedPlan.Status = comboBoxStatus.SelectedItem.ToString();

                    LoadPerformancePlans();
                    ClearInputs();
                    MessageBox.Show("계획이 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridPerformancePlans.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridPerformancePlans.SelectedRows[0];
                var selectedPlan = selectedRow.DataBoundItem as PerformancePlan;

                performancePlans.Remove(selectedPlan);
                LoadPerformancePlans();
                ClearInputs();
                MessageBox.Show("계획이 삭제되었습니다.","정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridPerformancePlans_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPerformancePlans.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridPerformancePlans.SelectedRows[0];
                var selectedPlan = selectedRow.DataBoundItem as PerformancePlan;

                txtPlanName.Text = selectedPlan.PlanName;
                txtDescription.Text = selectedPlan.Description;
                datePickerStart.Value = selectedPlan.StartDate;
                datePickerEnd.Value = selectedPlan.EndDate;
                comboBoxStatus.SelectedItem = selectedPlan.Status;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtPlanName.Text))
            {
                MessageBox.Show("계획 이름을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("설명을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("상태를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtPlanName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            datePickerStart.Value = DateTime.Now;
            datePickerEnd.Value = DateTime.Now;
            comboBoxStatus.SelectedItem = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtSearch.Text.ToLower();
            var filteredPlans = performancePlans.Where(p => p.PlanName.ToLower().Contains(query) ||
                                                            p.Description.ToLower().Contains(query)).ToList();
            dataGridPerformancePlans.DataSource = null;
            dataGridPerformancePlans.DataSource = filteredPlans;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // 엑셀 내보내기 구현
            MessageBox.Show("엑셀로 내보내기 기능은 구현되지 않았습니다.","정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class PerformancePlan
    {
        public string PlanName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
