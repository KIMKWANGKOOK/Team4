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
            LoadWorkInstructions();
            InitializeComboBoxTaskName();
            InitializeComboBoxPriority(); // 우선순위 콤보 박스를 초기화합니다.
        }

        private void LoadWorkInstructions()
        {
            dataGridWorkInstructions.DataSource = null;
            dataGridWorkInstructions.DataSource = workInstructions;
            // Worker 열을 추가합니다.
            if (!dataGridWorkInstructions.Columns.Contains("Worker"))
            {
                dataGridWorkInstructions.Columns.Add("Worker", "Worker");
            }
        }

        private void InitializeComboBoxTaskName()
        {
            comboBoxTaskName.Items.AddRange(new object[]
            {
                "FR02-A0",
                "FR02-A1",
                "FR02-A2"
            });

            comboBoxTaskName.SelectedIndexChanged += ComboBoxTaskName_SelectedIndexChanged;
        }

        // 추가: 우선순위 콤보 박스 초기화 메서드
        private void InitializeComboBoxPriority()
        {
            comboBoxPriority.Items.AddRange(new object[]
            {
                "높음",
                "중간",
                "낮음"
            });
        }

        private void ComboBoxTaskName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTaskName.SelectedItem != null)
            {
                string selectedTask = comboBoxTaskName.SelectedItem.ToString();
                switch (selectedTask)
                {
                    case "FR02-A0":
                        txtContent.Text = "금속작업";
                        comboBoxPriority.SelectedItem = "낮음"; // 우선순위 자동 설정
                        txtWorker.Text = "김대연"; // Worker 자동 설정
                        break;
                    case "FR02-A1":
                        txtContent.Text = "비금속작업";
                        comboBoxPriority.SelectedItem = "중간"; // 우선순위 자동 설정
                        txtWorker.Text = "김대연"; // Worker 자동 설정
                        break;
                    case "FR02-A2":
                        txtContent.Text = "금속+비금속작업";
                        comboBoxPriority.SelectedItem = "높음"; // 우선순위 자동 설정
                        txtWorker.Text = "김대연"; // Worker 자동 설정
                        break;
                }

                // 관리자로 자동 지정
                txtWriter.Text = "관리자";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var workInstruction = new WorkInstruction
                {
                    TaskName = comboBoxTaskName.Text,
                    Content = txtContent.Text,
                    Date = datePicker.Value,
                    Writer = txtWriter.Text,
                    Priority = comboBoxPriority.SelectedItem.ToString(),
                    Worker = txtWorker.Text // Worker 설정
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
                    selectedWorkInstruction.TaskName = comboBoxTaskName.Text;
                    selectedWorkInstruction.Content = txtContent.Text;
                    selectedWorkInstruction.Date = datePicker.Value;
                    selectedWorkInstruction.Writer = txtWriter.Text;
                    selectedWorkInstruction.Priority = comboBoxPriority.SelectedItem.ToString();
                    selectedWorkInstruction.Worker = txtWorker.Text; // Worker 설정

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

                if (selectedWorkInstruction != null)
                {
                    comboBoxTaskName.Text = selectedWorkInstruction.TaskName;
                    txtContent.Text = selectedWorkInstruction.Content;
                    datePicker.Value = selectedWorkInstruction.Date;
                    txtWriter.Text = selectedWorkInstruction.Writer;
                    comboBoxPriority.SelectedItem = selectedWorkInstruction.Priority;
                    txtWorker.Text = selectedWorkInstruction.Worker; // Worker 설정
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(comboBoxTaskName.Text))
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

            if (string.IsNullOrWhiteSpace(txtWorker.Text))
            {
                MessageBox.Show("작업자를 입력하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            comboBoxTaskName.Text = string.Empty;
            txtContent.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            txtWriter.Text = string.Empty;
            comboBoxPriority.SelectedItem = null;
            txtWorker.Text = string.Empty; // Worker 초기화
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
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
