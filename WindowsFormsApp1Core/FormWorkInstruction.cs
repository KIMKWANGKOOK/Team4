using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormWorkInstruction : Form
    {
        private BindingList<WorkInstruction> workInstructions;
        private BindingList<WorkInstruction> todayWorkList;
        private BindingList<WorkInstruction> workForToday;
        private int imageIndex = 0;
        private string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "사진자료");
        private string[] imagePaths;
        private string progressGifPath;
        int pp = 1;
        int pp_max = 3;

        public FormWorkInstruction()
        {
            InitializeComponent();
            workInstructions = new BindingList<WorkInstruction>();
            todayWorkList = new BindingList<WorkInstruction>();
            workForToday = new BindingList<WorkInstruction>();
            LoadWorkInstructions();
            InitializeComboBoxTaskName();
            InitializeComboBoxPriority();
            InitializeComboBoxSupply();
            LoadTodayWorkList();
            LoadWorkForToday();

            imagePaths = new string[]
            {
                Path.Combine(basePath, "작업중1.png"),
                Path.Combine(basePath, "작업중2.png"),
                Path.Combine(basePath, "작업중3.png")
            };

            progressGifPath = Path.Combine(basePath, "진행중.gif");

            timer = new Timer();
            timer.Interval = 1000; // 1초마다 이미지 변경
            timer.Tick += Timer_Tick;
        }

        private void LoadWorkInstructions()
        {
            dataGridWorkInstructions.DataSource = null;
            dataGridWorkInstructions.DataSource = workInstructions;
            if (!dataGridWorkInstructions.Columns.Contains("Worker"))
            {
                dataGridWorkInstructions.Columns.Add("Worker", "Worker");
            }
            if (!dataGridWorkInstructions.Columns.Contains("Supply"))
            {
                dataGridWorkInstructions.Columns.Add("Supply", "Supply");
            }
        }

        private void LoadTodayWorkList()
        {
            dataGridTodayWorkList.DataSource = null;
            dataGridTodayWorkList.DataSource = todayWorkList;
            if (dataGridTodayWorkList.Columns["CodeName"] != null)
            {
                dataGridTodayWorkList.Columns["CodeName"].HeaderText = "Code Name";
            }
            if (dataGridTodayWorkList.Columns["WorkDetails"] != null)
            {
                dataGridTodayWorkList.Columns["WorkDetails"].HeaderText = "Work Details";
            }
            if (dataGridTodayWorkList.Columns["Date"] != null)
            {
                dataGridTodayWorkList.Columns["Date"].HeaderText = "Completion Time";
            }
            if (dataGridTodayWorkList.Columns["Writer"] != null)
            {
                dataGridTodayWorkList.Columns["Writer"].Visible = false;
            }
            if (dataGridTodayWorkList.Columns["Worker"] != null)
            {
                dataGridTodayWorkList.Columns["Worker"].HeaderText = "Worker";
            }
            if (dataGridTodayWorkList.Columns["Supply"] != null)
            {
                dataGridTodayWorkList.Columns["Supply"].HeaderText = "Supply";
            }
            if (dataGridTodayWorkList.Columns["Priority"] != null)
            {
                dataGridTodayWorkList.Columns["Priority"].Visible = false;
            }
            if (dataGridTodayWorkList.Columns["Work_Status"] != null)
            {
                dataGridTodayWorkList.Columns["Work_Status"].Visible = false;
            }
        }

        private void LoadWorkForToday()
        {
            dataGridWorkForToday.DataSource = null;
            dataGridWorkForToday.DataSource = workForToday;
            if (dataGridWorkForToday.Columns["CodeName"] != null)
            {
                dataGridWorkForToday.Columns["CodeName"].HeaderText = "Code Name";
            }
            if (dataGridWorkForToday.Columns["WorkDetails"] != null)
            {
                dataGridWorkForToday.Columns["WorkDetails"].HeaderText = "Work Details";
            }
            if (dataGridWorkForToday.Columns["Supply"] != null)
            {
                dataGridWorkForToday.Columns["Supply"].HeaderText = "Supply";
            }
            if (dataGridWorkForToday.Columns["Date"] != null)
            {
                dataGridWorkForToday.Columns["Date"].Visible = false;
            }
            if (dataGridWorkForToday.Columns["Writer"] != null)
            {
                dataGridWorkForToday.Columns["Writer"].Visible = false;
            }
            if (dataGridWorkForToday.Columns["Worker"] != null)
            {
                dataGridWorkForToday.Columns["Worker"].HeaderText = "Worker";
            }
            if (dataGridWorkForToday.Columns["Priority"] != null)
            {
                dataGridWorkForToday.Columns["Priority"].Visible = false;
            }
            if (dataGridWorkForToday.Columns["Work_Status"] != null)
            {
                dataGridWorkForToday.Columns["Work_Status"].Visible = false;
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

        private void InitializeComboBoxPriority()
        {
            comboBoxPriority.Items.AddRange(new object[]
            {
                "높음",
                "중간",
                "낮음"
            });
        }

        private void InitializeComboBoxSupply()
        {
            comboBoxSupply.Items.AddRange(new object[]
            {
                "1EA",
                "2EA",
                "3EA",
                "4EA",
                "5EA"
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
                        comboBoxPriority.SelectedItem = "낮음";
                        txtWorker.Text = "김대연";
                        break;
                    case "FR02-A1":
                        txtContent.Text = "비금속작업";
                        comboBoxPriority.SelectedItem = "중간";
                        txtWorker.Text = "김대연";
                        break;
                    case "FR02-A2":
                        txtContent.Text = "금속+비금속작업";
                        comboBoxPriority.SelectedItem = "높음";
                        txtWorker.Text = "김대연";
                        break;
                }
                txtWriter.Text = "관리자";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var workInstruction = new WorkInstruction
                {
                    CodeName = comboBoxTaskName.Text,
                    WorkDetails = txtContent.Text,
                    Date = datePicker.Value,
                    Writer = txtWriter.Text,
                    Priority = comboBoxPriority.SelectedItem.ToString(),
                    Worker = txtWorker.Text,
                    Supply = comboBoxSupply.SelectedItem.ToString(),
                    Work_Status = "대기중"
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
                    selectedWorkInstruction.CodeName = comboBoxTaskName.Text;
                    selectedWorkInstruction.WorkDetails = txtContent.Text;
                    selectedWorkInstruction.Date = datePicker.Value;
                    selectedWorkInstruction.Writer = txtWriter.Text;
                    selectedWorkInstruction.Priority = comboBoxPriority.SelectedItem.ToString();
                    selectedWorkInstruction.Worker = txtWorker.Text;
                    selectedWorkInstruction.Supply = comboBoxSupply.SelectedItem.ToString();
                    selectedWorkInstruction.Work_Status = "대기중";

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
                    comboBoxTaskName.Text = selectedWorkInstruction.CodeName;
                    txtContent.Text = selectedWorkInstruction.WorkDetails;
                    datePicker.Value = selectedWorkInstruction.Date;
                    txtWriter.Text = selectedWorkInstruction.Writer;
                    comboBoxPriority.SelectedItem = selectedWorkInstruction.Priority;
                    txtWorker.Text = selectedWorkInstruction.Worker;
                    comboBoxSupply.SelectedItem = selectedWorkInstruction.Supply;
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

            if (comboBoxSupply.SelectedItem == null)
            {
                MessageBox.Show("공급량을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtWorker.Text = string.Empty;
            comboBoxSupply.SelectedItem = null;
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

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            if (dataGridWorkInstructions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridWorkInstructions.SelectedRows[0];
                var selectedWorkInstruction = selectedRow.DataBoundItem as WorkInstruction;
                string details = $"작업명: {selectedWorkInstruction.CodeName}\n내용: {selectedWorkInstruction.WorkDetails}\n날짜: {selectedWorkInstruction.Date}\n작성자: {selectedWorkInstruction.Writer}\n우선순위: {selectedWorkInstruction.Priority}\n작업자: {selectedWorkInstruction.Worker}\n공급량: {selectedWorkInstruction.Supply}";

                DialogResult result = MessageBox.Show($"작업을 진행하시겠습니까?\n\n{details}", "작업 시작", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    selectedWorkInstruction.Work_Status = "진행중";
                    LoadWorkInstructions();
                    MessageBox.Show("작업이 시작되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer.Start();

                    pictureBoxProgress.Image = Image.FromFile(progressGifPath);
                    pictureBoxProgress.Visible = true;
                    lblWorkStatus.Text = "현재 작업이 진행중입니다\r\n\r\n      ※확인해주세요※";
                }
            }
            else
            {
                MessageBox.Show("작업을 시작할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStopWork_Click(object sender, EventArgs e)
        {
            if (dataGridWorkInstructions.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridWorkInstructions.SelectedRows[0];
                var selectedWorkInstruction = selectedRow.DataBoundItem as WorkInstruction;

                DialogResult result = MessageBox.Show($"작업을 중지하시겠습니까?\n\n작업명: {selectedWorkInstruction.CodeName}", "작업 중지", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    selectedWorkInstruction.Work_Status = "완료";
                    workInstructions.Remove(selectedWorkInstruction);
                    todayWorkList.Add(selectedWorkInstruction);
                    LoadWorkInstructions();
                    LoadTodayWorkList();
                    MessageBox.Show("작업이 완료되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer.Stop();
                    pictureBoxWorkStatus.Image = null;
                    pictureBoxProgress.Visible = false; // 작업 완료 시 진행 중 아이콘 숨기기
                    lblWorkStatus.Text = "현재 작업이 대기중입니다\r\n\r\n      ※확인해주세요※";
                }
            }
            else
            {
                MessageBox.Show("작업을 중지할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateTodayWorkList_Click(object sender, EventArgs e)
        {
            int supplyAmount = 20;

            if (workForToday.Count < 3)
            {
                string codeName = $"FR02-A{workForToday.Count}";
                string workDetails = string.Empty;

                switch (codeName)
                {
                    case "FR02-A0":
                        workDetails = "금속작업";
                        break;
                    case "FR02-A1":
                        workDetails = "비금속작업";
                        break;
                    case "FR02-A2":
                        workDetails = "금속+비금속작업";
                        break;
                }

                var newWork = new WorkInstruction
                {
                    CodeName = codeName,
                    WorkDetails = workDetails,
                    Worker = "김대연",
                    Supply = $"{supplyAmount}EA"
                };

                workForToday.Add(newWork);
            }
            else
            {
                var firstWork = workForToday.First();
                supplyAmount = int.Parse(firstWork.Supply.Replace("EA", "")) + 20;
                firstWork.Supply = $"{supplyAmount}EA";
            }

            LoadWorkForToday();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            try
            {
                imageIndex = (imageIndex + 1) % imagePaths.Length;
                string imagePath = imagePaths[imageIndex];
                pictureBoxWorkStatus.Image = Image.FromFile(imagePath);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"이미지를 찾을 수 없습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지를 로드하는 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer.Stop();
            }
        }
    }
}
