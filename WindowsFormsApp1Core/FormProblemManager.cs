using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace WorkManagementSystem
{
    [SupportedOSPlatform("windows10.0.177630")] // 경고제거
    public partial class FormProblemManager : Form
    {
        private BindingList<Problem> problems;

        private MySqlConnection conn;

        public FormProblemManager()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Port=3306;Database=test_db;Uid=test_user;Pwd=java");
            problems = new BindingList<Problem>();
            LoadProblems();
            dataGridProblems.Columns["ReportedDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM problem_manager", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridProblems.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

            try
            {
                conn.Open();
                string query = "INSERT INTO problem_manager (Name, Description, ReportedDate, Status) " +
                    "VALUES (@value1, @value2, @value3, @value4)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@value1", txtProblemName.Text);
                cmd.Parameters.AddWithValue("@value2", txtDescription.Text);
                cmd.Parameters.AddWithValue("@value3", datePickerReported.Value);
                cmd.Parameters.AddWithValue("@value4", comboBoxStatus.SelectedItem);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            

            var problem = new Problem
            {
                Name = txtProblemName.Text,
                Description = txtDescription.Text,
                ReportedDate = datePickerReported.Value,
                Status = comboBoxStatus.SelectedItem.ToString()
            };

            problems.Add(problem);
            LoadData(); // 데이터 다시 로드
            // UpdateDataGrid();
            ClearForm();
            MessageBox.Show("문제가 저장되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridProblems.SelectedRows.Count > 0)
            {
                if (!ValidateInputs())
                    return;

                var selectedRow = dataGridProblems.SelectedRows[0];
                String name = selectedRow.Cells["Name"].Value.ToString();
                String description = selectedRow.Cells["Description"].Value.ToString();
                String reportedDate = selectedRow.Cells["ReportedDate"].Value.ToString();
                String status = selectedRow.Cells["Status"].Value.ToString();



                try
                {
                    conn.Open();
                    string query = "UPDATE problem_manager SET Name = @value1, Description = @value2, ReportedDate = @value3, Status = @value4  " +
                        "WHERE Name = @name AND Description = @description AND ReportedDate = @reportedDate AND Status = @status";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@value1", txtProblemName.Text);
                    cmd.Parameters.AddWithValue("@value2", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@value3", datePickerReported.Value);
                    cmd.Parameters.AddWithValue("@value4", comboBoxStatus.SelectedItem.ToString());

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@reportedDate", reportedDate);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }


                LoadData(); // 데이터 다시 로드
                // UpdateDataGrid();
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

        private void btnExport_Click(object sender, EventArgs e) // 엑셀파일 저장
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

                    MessageBox.Show("다운로드 되었습니다.", "Info");
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
