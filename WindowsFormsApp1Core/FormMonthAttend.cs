using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormMonthAttend : Form
    {
        private BindingList<MonthlyAttendance> monthlyAttendances;

        public FormMonthAttend()
        {
            InitializeComponent();
            monthlyAttendances = new BindingList<MonthlyAttendance>();
            LoadMonthlyAttendances();
        }

        private void LoadMonthlyAttendances()
        {
            dataGridMonthAttend.DefaultCellStyle.ForeColor = Color.Black;
            dataGridMonthAttend.DataSource = null;
            dataGridMonthAttend.DataSource = monthlyAttendances;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var attendance = new MonthlyAttendance
                {
                    EmployeeName = txtEmployeeName.Text,
                    Date = datePicker.Value,
                    Status = comboBoxStatus.SelectedItem.ToString()
                };

                monthlyAttendances.Add(attendance);
                LoadMonthlyAttendances();
                ClearInputs();
                MessageBox.Show("근태 정보가 저장되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridMonthAttend.CurrentRow?.DataBoundItem is MonthlyAttendance selectedAttendance)
            {
                if (ValidateInputs())
                {
                    selectedAttendance.EmployeeName = txtEmployeeName.Text;
                    selectedAttendance.Date = datePicker.Value;
                    selectedAttendance.Status = comboBoxStatus.SelectedItem.ToString();

                    LoadMonthlyAttendances();
                    ClearInputs();
                    MessageBox.Show("근태 정보가 수정되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridMonthAttend.CurrentRow?.DataBoundItem is MonthlyAttendance selectedAttendance)
            {
                monthlyAttendances.Remove(selectedAttendance);
                LoadMonthlyAttendances();
                ClearInputs();
                MessageBox.Show("근태 정보가 삭제되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("직원명을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtEmployeeName.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            comboBoxStatus.SelectedItem = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.ToLower();
            var filteredAttendances = monthlyAttendances.Where(ma =>
                ma.EmployeeName.ToLower().Contains(keyword) ||
                ma.Status.ToLower().Contains(keyword)).ToList();

            dataGridMonthAttend.DataSource = null;
            dataGridMonthAttend.DataSource = filteredAttendances;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // 엑셀로 내보내기 구현
            // 필요한 패키지 참조 추가 필요 (예: EPPlus)
        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }

    public class MonthlyAttendance
    {
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{EmployeeName} - {Date.ToShortDateString()} - {Status}";
        }

    }
}
