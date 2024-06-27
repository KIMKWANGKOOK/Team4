using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    [SupportedOSPlatform("windows10.0.177630")]
    public partial class FormProblemManager : Form
    {
        private BindingList<Problem> problems;

        public FormProblemManager()
        {
            InitializeComponent();
            problems = new BindingList<Problem>();
            LoadProblems();
            // asdf
        }

        private void LoadProblems()
        {
            // 초기 데이터를 로드하거나 빈 리스트로 시작할 수 있습니다.
            // 여기에 필요한 경우 초기 데이터를 추가할 수 있습니다.
            dataGridProblems.DefaultCellStyle.ForeColor = Color.Black;
            UpdateDataGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            var problem = new Problem
            {
                Name = txtProblemName.Text,
                Description = txtDescription.Text,
                ReportedDate = datePickerReported.Value,
                Status = comboBoxStatus.SelectedItem.ToString()
            };

            problems.Add(problem);
            UpdateDataGrid();
            ClearForm();
            MessageBox.Show("문제가 저장되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridProblems.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridProblems.SelectedRows[0];
                var problem = (Problem)selectedRow.DataBoundItem;

                if (!ValidateInputs())
                    return;

                problem.Name = txtProblemName.Text;
                problem.Description = txtDescription.Text;
                problem.ReportedDate = datePickerReported.Value;
                problem.Status = comboBoxStatus.SelectedItem.ToString();

                UpdateDataGrid();
                ClearForm();
                MessageBox.Show("문제가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("수정할 문제를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridProblems.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridProblems.SelectedRows[0];
                var problem = (Problem)selectedRow.DataBoundItem;

                problems.Remove(problem);
                UpdateDataGrid();
                ClearForm();
                MessageBox.Show("문제가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제할 문제를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtSearch.Text.ToLower();
            var searchResult = problems
                .Where(p => p.Name.ToLower().Contains(query) || p.Description.ToLower().Contains(query))
                .ToList();

            dataGridProblems.DataSource = null;
            dataGridProblems.DataSource = searchResult;

            MessageBox.Show($"{searchResult.Count}개의 문제가 검색되었습니다.", "검색 결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // Export logic to be implemented
            MessageBox.Show("엑셀로 내보내기 기능은 아직 구현되지 않았습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDataGrid()
        {
            dataGridProblems.DataSource = null;
            dataGridProblems.DataSource = problems;
        }

        private void ClearForm()
        {
            txtProblemName.Clear();
            txtDescription.Clear();
            datePickerReported.Value = DateTime.Now;
            comboBoxStatus.SelectedIndex = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProblemName.Text))
            {
                MessageBox.Show("문제명을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dataGridProblems_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridProblems.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridProblems.SelectedRows[0];
                var problem = (Problem)selectedRow.DataBoundItem;

                txtProblemName.Text = problem.Name;
                txtDescription.Text = problem.Description;
                datePickerReported.Value = problem.ReportedDate;
                comboBoxStatus.SelectedItem = problem.Status;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // SaveFileDialog를 사용하여 파일 저장 경로와 이름을 설정
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // ClosedXML을 사용하여 DataGridView의 데이터를 엑셀 파일로 저장
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sheet1");

                        // DataGridView 헤더를 추가
                        for (int i = 0; i < dataGridProblems.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dataGridProblems.Columns[i].HeaderText;
                        }

                        // DataGridView 데이터를 추가
                        for (int i = 0; i < dataGridProblems.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridProblems.Columns.Count; j++)
                            {
                                worksheet.Cell(i + 2, j + 1).Value = dataGridProblems.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Export Successful", "Info");
                }
            }
        }

    }

    public class Problem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReportedDate { get; set; }
        public string Status { get; set; }
    }
}
