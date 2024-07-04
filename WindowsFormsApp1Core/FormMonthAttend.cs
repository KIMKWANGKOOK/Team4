using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace WorkManagementSystem
{
    public partial class FormMonthAttend : Form
    {
        private BindingList<MonthlyAttendance> monthlyAttendances; // 월별 근태 정보를 저장하는 바인딩 리스트

        public FormMonthAttend()
        {
            InitializeComponent();
            monthlyAttendances = new BindingList<MonthlyAttendance>(); // 월별 근태 정보 리스트 초기화
            LoadMonthlyAttendances(); // 월별 근태 정보 로드
        }

        // 월별 근태 정보를 로드하는 메서드
        private void LoadMonthlyAttendances()
        {
            dataGridMonthAttend.DefaultCellStyle.ForeColor = Color.Black;
            dataGridMonthAttend.DataSource = null;
            dataGridMonthAttend.DataSource = monthlyAttendances; // 데이터 그리드에 바인딩 리스트 설정
        }

        // 저장 버튼 클릭 이벤트 핸들러
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs()) // 입력 값 검증
            {
                // 새로운 근태 정보 객체 생성 및 값 설정
                var attendance = new MonthlyAttendance
                {
                    EmployeeName = txtEmployeeName.Text,
                    Date = datePicker.Value,
                    Status = comboBoxStatus.SelectedItem.ToString()
                };

                monthlyAttendances.Add(attendance); // 근태 정보 리스트에 추가
                LoadMonthlyAttendances(); // 데이터 그리드 업데이트
                ClearInputs(); // 입력 폼 초기화
                MessageBox.Show("근태 정보가 저장되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 수정 버튼 클릭 이벤트 핸들러
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridMonthAttend.CurrentRow?.DataBoundItem is MonthlyAttendance selectedAttendance)
            {
                if (ValidateInputs()) // 입력 값 검증
                {
                    // 선택한 근태 정보 객체 값 업데이트
                    selectedAttendance.EmployeeName = txtEmployeeName.Text;
                    selectedAttendance.Date = datePicker.Value;
                    selectedAttendance.Status = comboBoxStatus.SelectedItem.ToString();

                    LoadMonthlyAttendances(); // 데이터 그리드 업데이트
                    ClearInputs(); // 입력 폼 초기화
                    MessageBox.Show("근태 정보가 수정되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 삭제 버튼 클릭 이벤트 핸들러
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridMonthAttend.CurrentRow?.DataBoundItem is MonthlyAttendance selectedAttendance)
            {
                monthlyAttendances.Remove(selectedAttendance); // 근태 정보 리스트에서 제거
                LoadMonthlyAttendances(); // 데이터 그리드 업데이트
                ClearInputs(); // 입력 폼 초기화
                MessageBox.Show("근태 정보가 삭제되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 입력 값 검증 메서드
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

        // 입력 폼을 초기화하는 메서드
        private void ClearInputs()
        {
            txtEmployeeName.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            comboBoxStatus.SelectedItem = null;
        }

        // 검색 버튼 클릭 이벤트 핸들러
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.ToLower();
            var filteredAttendances = monthlyAttendances.Where(ma =>
                ma.EmployeeName.ToLower().Contains(keyword) ||
                ma.Status.ToLower().Contains(keyword)).ToList();

            dataGridMonthAttend.DataSource = null;
            dataGridMonthAttend.DataSource = filteredAttendances; // 검색 결과를 데이터 그리드에 표시
        }

        // 엑셀로 내보내기 버튼 클릭 이벤트 핸들러
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // SaveFileDialog를 사용하여 파일 저장 경로와 이름을 설정
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // ClosedXML을 사용하여 DataGridView의 데이터를 엑셀 파일로 저장
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("sheet1");

                        // DataGridView 헤더를 추가
                        for (int i = 0; i < dataGridMonthAttend.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridMonthAttend.Columns[i].HeaderText;
                        }

                        // DataGridView 데이터를 추가
                        for (int i = 0; i < dataGridMonthAttend.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridMonthAttend.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dataGridMonthAttend.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName); // 파일 저장
                    }

                    MessageBox.Show("Export Successful", "info");
                }
            }
        }

        // 기타 이벤트 핸들러
        private void lblEmployeeName_Click(object sender, EventArgs e) { }
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblDate_Click(object sender, EventArgs e) { }
        private void FormMonthAttend_Load(object sender, EventArgs e) { }
        private void dataGridMonthAttend_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }

    // 월별 근태 정보 클래스 정의
    public class MonthlyAttendance
    {
        public string EmployeeName { get; set; } // 직원명
        public DateTime Date { get; set; } // 날짜
        public string Status { get; set; } // 상태 (예: 출근, 결근 등)

        public override string ToString()
        {
            return $"{EmployeeName} - {Date.ToShortDateString()} - {Status}";
        }
    }
}
