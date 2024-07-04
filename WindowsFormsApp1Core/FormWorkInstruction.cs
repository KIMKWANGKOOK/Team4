using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ActUtlTypeLib;
using ClosedXML.Excel;

namespace WorkManagementSystem
{
    public partial class FormWorkInstruction : Form
    {
        private ActUtlType plc01 = new ActUtlType();
        private BindingList<WorkInstruction> workInstructions;
        private BindingList<WorkInstruction> todayWorkList;
        private BindingList<WorkInstruction> workForToday;
        private Timer checkCompletionTimer;

        public FormWorkInstruction()
        {
            InitializeComponent();
            workInstructions = new BindingList<WorkInstruction>();
            todayWorkList = new BindingList<WorkInstruction>();
            workForToday = new BindingList<WorkInstruction>();
            LoadWorkInstructions();
            InitializeComboBoxTaskName();
            InitializeComboBoxPriority();
            InitializeComboBoxQuantity();
            LoadTodayWorkList();
            LoadWorkForToday();
            InitializeDataGrids();
        }

        private void InitializeDataGrids()
        {
            dataGridWorkInstructions.CellFormatting += DataGridWorkInstructions_CellFormatting;
            dataGridTodayWorkList.CellFormatting += DataGridTodayWorkList_CellFormatting;
            dataGridWorkForToday.CellFormatting += DataGridWorkForToday_CellFormatting;
        }

        private void DataGridWorkInstructions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatQuantityColumn(e, dataGridWorkInstructions);
        }

        private void DataGridTodayWorkList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatQuantityColumn(e, dataGridTodayWorkList);
        }

        private void DataGridWorkForToday_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatQuantityColumn(e, dataGridWorkForToday);
        }

        private void FormatQuantityColumn(DataGridViewCellFormattingEventArgs e, DataGridView grid)
        {
            if (e.ColumnIndex == grid.Columns["Quantity"].Index && e.Value != null)
            {
                e.Value = $"{e.Value} EA";
                e.FormattingApplied = true;
            }
        }

        private void LoadWorkInstructions()
        {
            dataGridWorkInstructions.DataSource = null;
            dataGridWorkInstructions.DataSource = workInstructions;
            if (!dataGridWorkInstructions.Columns.Contains("Worker"))
            {
                dataGridWorkInstructions.Columns.Add("Worker", "Worker");
            }
            if (!dataGridWorkInstructions.Columns.Contains("Quantity"))
            {
                dataGridWorkInstructions.Columns.Add("Quantity", "Quantity");
            }
        }

        private void LoadTodayWorkList()
        {
            dataGridTodayWorkList.DataSource = null;
            dataGridTodayWorkList.DataSource = todayWorkList;
            if (dataGridTodayWorkList.Columns["Code Name"] != null)
            {
                dataGridTodayWorkList.Columns["Code Name"].HeaderText = "Code Name";
            }
            if (dataGridTodayWorkList.Columns["Work Details"] != null)
            {
                dataGridTodayWorkList.Columns["Work Details"].HeaderText = "Work Details";
            }
            if (dataGridTodayWorkList.Columns["Date"] != null)
            {
                dataGridTodayWorkList.Columns["Date"].HeaderText = "Date";
            }
            if (dataGridTodayWorkList.Columns["Writer"] != null)
            {
                dataGridTodayWorkList.Columns["Writer"].Visible = false;
            }
            if (dataGridTodayWorkList.Columns["Worker"] != null)
            {
                dataGridTodayWorkList.Columns["Worker"].HeaderText = "Worker";
            }
            if (dataGridTodayWorkList.Columns["Quantity"] != null)
            {
                dataGridTodayWorkList.Columns["Quantity"].HeaderText = "Quantity";
            }
            if (dataGridTodayWorkList.Columns["Priority"] != null)
            {
                dataGridTodayWorkList.Columns["Priority"].Visible = false;
            }
            if (dataGridTodayWorkList.Columns["Work Status"] != null)
            {
                dataGridTodayWorkList.Columns["Work Status"].Visible = false;
            }
        }

        private void LoadWorkForToday()
        {
            dataGridWorkForToday.DataSource = null;
            dataGridWorkForToday.DataSource = workForToday;
            if (dataGridWorkForToday.Columns["Code Name"] != null)
            {
                dataGridWorkForToday.Columns["Code Name"].HeaderText = "Code Name";
            }
            if (dataGridWorkForToday.Columns["Work Details"] != null)
            {
                dataGridWorkForToday.Columns["Work Details"].HeaderText = "Work Details";
            }
            if (dataGridWorkForToday.Columns["Quantity"] != null)
            {
                dataGridWorkForToday.Columns["Quantity"].HeaderText = "Quantity";
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

        private void InitializeComboBoxQuantity()
        {
            comboBoxQuantity.Items.AddRange(new object[]
            {
                "1",
                "2",
                "3",
                "4",
                "5"
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
                    Quantity = int.Parse(comboBoxQuantity.SelectedItem.ToString()),
                    WorkStatus = "대기중"
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
                    selectedWorkInstruction.Quantity = int.Parse(comboBoxQuantity.SelectedItem.ToString());
                    selectedWorkInstruction.WorkStatus = "대기중";

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
                    comboBoxQuantity.SelectedItem = selectedWorkInstruction.Quantity.ToString();
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

            if (comboBoxQuantity.SelectedItem == null)
            {
                MessageBox.Show("수량을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            comboBoxQuantity.SelectedItem = null;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // SaveFileDialog를 사용하여 파일 저장 경로와 이름을 설정
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // ClosedXML을 사용하여 DataGridView의 데이터를 엑셀 파일로 저장
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet1 = workbook.Worksheets.Add("Work Table");

                        // DataGridView 헤더를 추가
                        for (int i = 0; i < dataGridWorkInstructions.Columns.Count; i++)
                        {
                            worksheet1.Cell(1, i + 1).Value = dataGridWorkInstructions.Columns[i].HeaderText;
                        }

                        // DataGridView 데이터를 추가
                        for (int i = 0; i < dataGridWorkInstructions.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridWorkInstructions.Columns.Count; j++)
                            {
                                worksheet1.Cell(i + 2, j + 1).Value = dataGridWorkInstructions.Rows[i].Cells[j].Value?.ToString();
                            }
                        }



                        var worksheet2 = workbook.Worksheets.Add("List of tasks");

                        // DataGridView 헤더를 추가
                        for (int i = 0; i < dataGridTodayWorkList.Columns.Count; i++)
                        {
                            worksheet2.Cell(1, i + 1).Value = dataGridTodayWorkList.Columns[i].HeaderText;
                        }

                        // DataGridView 데이터를 추가
                        for (int i = 0; i < dataGridTodayWorkList.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridTodayWorkList.Columns.Count; j++)
                            {
                                worksheet2.Cell(i + 2, j + 1).Value = dataGridTodayWorkList.Rows[i].Cells[j].Value?.ToString();
                            }
                        }



                        var worksheet3 = workbook.Worksheets.Add("Today's Work List");

                        // DataGridView 헤더를 추가
                        for (int i = 0; i < dataGridWorkForToday.Columns.Count; i++)
                        {
                            worksheet3.Cell(1, i + 1).Value = dataGridWorkForToday.Columns[i].HeaderText;
                        }

                        // DataGridView 데이터를 추가
                        for (int i = 0; i < dataGridWorkForToday.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridWorkForToday.Columns.Count; j++)
                            {
                                worksheet3.Cell(i + 2, j + 1).Value = dataGridWorkForToday.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("다운로드 되었습니다.", "Info");
                }
            }
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
                string details = $"작업명: {selectedWorkInstruction.CodeName}\n내용: {selectedWorkInstruction.WorkDetails}\n날짜: {selectedWorkInstruction.Date}\n작성자: {selectedWorkInstruction.Writer}\n우선순위: {selectedWorkInstruction.Priority}\n작업자: {selectedWorkInstruction.Worker}\n수량: {selectedWorkInstruction.Quantity} EA";

                DialogResult result = MessageBox.Show($"작업을 진행하시겠습니까?\n\n{details}", "작업 시작", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    selectedWorkInstruction.WorkStatus = "진행중";
                    LoadWorkInstructions();
                    MessageBox.Show("작업이 시작되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblWorkStatus.Text = "현재 작업이 진행중입니다\r\n\r\n      ※확인해주세요※";

                    // PLC 공정 시작
                    StartPLCProcess(selectedWorkInstruction);
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
                    selectedWorkInstruction.WorkStatus = "완료";
                    workInstructions.Remove(selectedWorkInstruction);
                    todayWorkList.Add(selectedWorkInstruction);
                    LoadWorkInstructions();
                    LoadTodayWorkList();
                    MessageBox.Show("작업이 완료되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblWorkStatus.Text = "현재 작업이 대기중입니다\r\n\r\n      ※확인해주세요※";

                    // 작업 완료 후 차트 업데이트
                    FormWorkPerformance formWorkPerformance = Application.OpenForms.OfType<FormWorkPerformance>().FirstOrDefault();
                    if (formWorkPerformance != null)
                    {
                        formWorkPerformance.AddWorkPerformance(new WorkPerformance
                        {
                            TaskName = selectedWorkInstruction.CodeName,
                            Date = selectedWorkInstruction.Date,
                            Worker = selectedWorkInstruction.Worker,
                            Status = selectedWorkInstruction.WorkStatus,
                            Quantity = selectedWorkInstruction.Quantity // 작업 수량 추가
                        });
                    }
                }
            }
            else
            {
                MessageBox.Show("작업을 중지할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateTodayWorkList_Click(object sender, EventArgs e)
        {
            int quantity = 20;

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
                    Quantity = quantity
                };

                workForToday.Add(newWork);
            }
            else
            {
                var firstWork = workForToday.First();
                quantity = firstWork.Quantity + 20;
                firstWork.Quantity = quantity;
            }

            LoadWorkForToday();
        }

        private void bt_OpenPLC_Click(object sender, EventArgs e) // PLC 연결
        {
            if (string.IsNullOrWhiteSpace(combo_plcNum.Text))
            {
                MessageBox.Show("연결할 PLC번호를 입력하세요");
                return;
            }
            else
            {
                MessageBox.Show("통신확인을 해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            plc01.ActLogicalStationNumber = Convert.ToInt32(combo_plcNum.Text);

            int open_state = plc01.Open();
            if (open_state == 0)
            {
                lb_state.ForeColor = Color.Green;
                lb_state.Text = "연결됨";
            }
            else
            {
                lb_state.ForeColor = Color.Red;
                lb_state.Text = "0x" + Convert.ToString(open_state, 16);
            }
        }

        private void bt_ClosePLC_Click(object sender, EventArgs e) // PLC 닫기
        {
            lb_state.ForeColor = Color.Red;
            lb_state.Text = "연결닫힘";
            plc01.Close();
        }

        private void StartPLCProcess(WorkInstruction workInstruction)
        {
            try
            {
                int setResult = 0;
                string device = string.Empty;

                if (workInstruction.CodeName == "FR02-A0")
                {
                    device = "X00"; // 금속 작업
                }
                else if (workInstruction.CodeName == "FR02-A1")
                {
                    device = "X01"; // 비금속 작업
                }
                else if (workInstruction.CodeName == "FR02-A2")
                {
                    device = "X02"; // 금속+비금속 작업
                }

                setResult = plc01.SetDevice(device, 1);
                if (setResult == 0)
                {
                    MessageBox.Show($"{workInstruction.CodeName} 공정이 시작되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CheckProcessCompletion(workInstruction);
                }
                else
                {
                    MessageBox.Show($"PLC {workInstruction.CodeName} 공정 시작에 실패했습니다. 오류 코드: {setResult}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PLC 공정 시작 중 예외가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopPLCProcess(string device)
        {
            try
            {
                plc01.SetDevice(device, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PLC 공정 중지 중 예외가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckProcessCompletion(WorkInstruction workInstruction)
        {
            checkCompletionTimer = new Timer();
            checkCompletionTimer.Interval = 1000;
            checkCompletionTimer.Tick += (s, e) =>
            {
                try
                {
                    int completionValue;
                    string completionDevice = string.Empty;

                    if (workInstruction.CodeName == "FR02-A0")
                    {
                        completionDevice = "D0";
                    }
                    else if (workInstruction.CodeName == "FR02-A1")
                    {
                        completionDevice = "D10";
                    }
                    else if (workInstruction.CodeName == "FR02-A2")
                    {
                        completionDevice = "D20";
                    }

                    plc01.GetDevice(completionDevice, out completionValue);

                    if (completionValue >= workInstruction.Quantity)
                    {
                        checkCompletionTimer.Stop();
                        string device = string.Empty;

                        if (workInstruction.CodeName == "FR02-A0")
                        {
                            device = "X00";
                        }
                        else if (workInstruction.CodeName == "FR02-A1")
                        {
                            device = "X01";
                        }
                        else if (workInstruction.CodeName == "FR02-A2")
                        {
                            device = "X02";
                        }

                        StopPLCProcess(device);

                        workInstruction.WorkStatus = "완료";
                        Invoke(new Action(() =>
                        {
                            workInstructions.Remove(workInstruction);
                            todayWorkList.Add(workInstruction);
                            LoadWorkInstructions();
                            LoadTodayWorkList();
                            lblWorkStatus.Text = "현재 작업이 대기중입니다\r\n\r\n      ※확인해주세요※";
                            MessageBox.Show("작업이 완료되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 작업 완료 후 차트 업데이트
                            FormWorkPerformance formWorkPerformance = Application.OpenForms.OfType<FormWorkPerformance>().FirstOrDefault();
                            if (formWorkPerformance != null)
                            {
                                formWorkPerformance.AddWorkPerformance(new WorkPerformance
                                {
                                    TaskName = workInstruction.CodeName,
                                    Date = workInstruction.Date,
                                    Worker = workInstruction.Worker,
                                    Status = workInstruction.WorkStatus,
                                    Quantity = workInstruction.Quantity // 작업 수량 추가
                                });
                            }
                        }));
                    }
                }
                catch (Exception ex)
                {
                    checkCompletionTimer.Stop();
                    MessageBox.Show($"D 값을 읽는 중 예외가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            checkCompletionTimer.Start();
        }
    }
}