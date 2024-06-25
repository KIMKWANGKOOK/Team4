using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormWorkInstruction : Form
    {
        private List<WorkInstruction> workInstructions;

        public FormWorkInstruction()
        {
            InitializeComponent();
            workInstructions = new List<WorkInstruction>();
            LoadWorkInstructions();//
        }

        private void LoadWorkInstructions()
        {
            dataGridWorkInstructions.DataSource = null;
            dataGridWorkInstructions.DataSource = workInstructions;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var workInstruction = new WorkInstruction
                {
                    TaskName = txtTaskName.Text,
                    Content = txtContent.Text,
                    Date = datePicker.Value,
                    Writer = txtWriter.Text,
                    Priority = comboBoxPriority.SelectedItem.ToString()
                };

                workInstructions.Add(workInstruction);
                LoadWorkInstructions();
                ClearInputs();
                MessageBox.Show("작업지시가 저장되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridWorkInstructions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridWorkInstructions.SelectedRows[0];
                var selectedWorkInstruction = selectedRow.DataBoundItem as WorkInstruction;

                if (ValidateInputs())
                {
                    selectedWorkInstruction.TaskName = txtTaskName.Text;
                    selectedWorkInstruction.Content = txtContent.Text;
                    selectedWorkInstruction.Date = datePicker.Value;
                    selectedWorkInstruction.Writer = txtWriter.Text;
                    selectedWorkInstruction.Priority = comboBoxPriority.SelectedItem.ToString();

                    LoadWorkInstructions();
                    ClearInputs();
                    MessageBox.Show("작업지시가 수정되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("수정할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridWorkInstructions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridWorkInstructions.SelectedRows[0];
                var selectedWorkInstruction = selectedRow.DataBoundItem as WorkInstruction;

                workInstructions.Remove(selectedWorkInstruction);
                LoadWorkInstructions();
                ClearInputs();
                MessageBox.Show("작업지시가 삭제되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridWorkInstructions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridWorkInstructions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridWorkInstructions.SelectedRows[0];
                var selectedWorkInstruction = selectedRow.DataBoundItem as WorkInstruction;

                txtTaskName.Text = selectedWorkInstruction.TaskName;
                txtContent.Text = selectedWorkInstruction.Content;
                datePicker.Value = selectedWorkInstruction.Date;
                txtWriter.Text = selectedWorkInstruction.Writer;
                comboBoxPriority.SelectedItem = selectedWorkInstruction.Priority;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("작업 이름을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("내용을 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtWriter.Text))
            {
                MessageBox.Show("작성자를 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxPriority.SelectedItem == null)
            {
                MessageBox.Show("우선순위를 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtTaskName.Text = string.Empty;
            txtContent.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            txtWriter.Text = string.Empty;
            comboBoxPriority.SelectedItem = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.ToLower();
            var filteredInstructions = workInstructions.Where(wi =>
                wi.TaskName.ToLower().Contains(keyword) ||
                wi.Content.ToLower().Contains(keyword) ||
                wi.Writer.ToLower().Contains(keyword) ||
                wi.Priority.ToLower().Contains(keyword)).ToList();

            dataGridWorkInstructions.DataSource = null;
            dataGridWorkInstructions.DataSource = filteredInstructions;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // 엑셀로 내보내기 구현
            // 필요한 패키지 참조 추가 필요 (예: EPPlus)
            MessageBox.Show("엑셀로 내보내기 기능은 아직 구현되지 않았습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dataGridWorkInstructions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridWorkInstructions.SelectedRows[0];
                var selectedWorkInstruction = selectedRow.DataBoundItem as WorkInstruction;
                var detailsForm = new FormDetails(selectedWorkInstruction);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("상세 내용을 볼 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
