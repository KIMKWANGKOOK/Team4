using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // 이 부분이 필요합니다.
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormToPerformance : Form
    {
        private List<PerformancePlan> performancePlans; // 성과 계획을 저장하는 리스트

        public FormToPerformance()
        {
            InitializeComponent();
            performancePlans = new List<PerformancePlan>(); // 성과 계획 리스트 초기화
            LoadPerformancePlans(); // 성과 계획 로드
        }

        // 성과 계획을 로드하는 메서드
        private void LoadPerformancePlans()
        {
            dataGridPerformancePlans.DataSource = null;
            dataGridPerformancePlans.DataSource = performancePlans; // 데이터 그리드에 성과 계획 리스트 설정
        }

        // 저장 버튼 클릭 이벤트 핸들러
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputs()) // 입력 값 검증
            {
                // 새로운 성과 계획 객체 생성 및 값 설정
                var performancePlan = new PerformancePlan
                {
                    PlanName = txtPlanName.Text,
                    Description = txtDescription.Text,
                    StartDate = datePickerStart.Value,
                    EndDate = datePickerEnd.Value,
                    Status = comboBoxStatus.SelectedItem.ToString()
                };

                performancePlans.Add(performancePlan); // 성과 계획 리스트에 추가
                LoadPerformancePlans(); // 데이터 그리드 업데이트
                ClearInputs(); // 입력 폼 초기화
                MessageBox.Show("계획이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 수정 버튼 클릭 이벤트 핸들러
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridPerformancePlans.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridPerformancePlans.SelectedRows[0];
                var selectedPlan = selectedRow.DataBoundItem as PerformancePlan;

                if (ValidateInputs()) // 입력 값 검증
                {
                    // 선택한 성과 계획 객체 값 업데이트
                    selectedPlan.PlanName = txtPlanName.Text;
                    selectedPlan.Description = txtDescription.Text;
                    selectedPlan.StartDate = datePickerStart.Value;
                    selectedPlan.EndDate = datePickerEnd.Value;
                    selectedPlan.Status = comboBoxStatus.SelectedItem.ToString();

                    LoadPerformancePlans(); // 데이터 그리드 업데이트
                    ClearInputs(); // 입력 폼 초기화
                    MessageBox.Show("계획이 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dataGridPerformancePlans.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridPerformancePlans.SelectedRows[0];
                var selectedPlan = selectedRow.DataBoundItem as PerformancePlan;

                performancePlans.Remove(selectedPlan); // 성과 계획 리스트에서 제거
                LoadPerformancePlans(); // 데이터 그리드 업데이트
                ClearInputs(); // 입력 폼 초기화
                MessageBox.Show("계획이 삭제되었습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 데이터 그리드 선택 변경 이벤트 핸들러
        private void dataGridPerformancePlans_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPerformancePlans.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridPerformancePlans.SelectedRows[0];
                var selectedPlan = selectedRow.DataBoundItem as PerformancePlan;

                // 선택한 성과 계획 객체 값을 입력 폼에 설정
                txtPlanName.Text = selectedPlan.PlanName;
                txtDescription.Text = selectedPlan.Description;
                datePickerStart.Value = selectedPlan.StartDate;
                datePickerEnd.Value = selectedPlan.EndDate;
                comboBoxStatus.SelectedItem = selectedPlan.Status;
            }
        }

        // 입력 값 검증 메서드
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

        // 입력 폼 초기화 메서드
        private void ClearInputs()
        {
            txtPlanName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            datePickerStart.Value = DateTime.Now;
            datePickerEnd.Value = DateTime.Now;
            comboBoxStatus.SelectedItem = null;
        }

        // 검색 버튼 클릭 이벤트 핸들러
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = txtSearch.Text.ToLower();
            var filteredPlans = performancePlans.Where(p => p.PlanName.ToLower().Contains(query) ||
                                                            p.Description.ToLower().Contains(query)).ToList();
            dataGridPerformancePlans.DataSource = null;
            dataGridPerformancePlans.DataSource = filteredPlans; // 검색 결과를 데이터 그리드에 표시
        }

        // 엑셀로 내보내기 버튼 클릭 이벤트 핸들러
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            // 엑셀 내보내기 구현
            MessageBox.Show("엑셀로 내보내기 기능은 구현되지 않았습니다.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // 성과 계획 클래스 정의
    public class PerformancePlan
    {
        public string PlanName { get; set; } // 계획 이름
        public string Description { get; set; } // 설명
        public DateTime StartDate { get; set; } // 시작 날짜
        public DateTime EndDate { get; set; } // 종료 날짜
        public string Status { get; set; } // 상태 (예: 완료, 진행 중 등)
    }
}
