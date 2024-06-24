using System;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    public partial class FormDetails : Form
    {
        private WorkInstruction workInstruction;

        public FormDetails(WorkInstruction workInstruction)
        {
            InitializeComponent();
            this.workInstruction = workInstruction;
            DisplayWorkInstructionDetails();
        }

        private void DisplayWorkInstructionDetails()
        {
            txtDetails.Text = $"작업 이름: {workInstruction.TaskName}\n" +
                              $"작업 내용: {workInstruction.Content}\n" +
                              $"날짜: {workInstruction.Date}\n" +
                              $"작성자: {workInstruction.Writer}\n" +
                              $"우선순위: {workInstruction.Priority}";
        }
    }
}
