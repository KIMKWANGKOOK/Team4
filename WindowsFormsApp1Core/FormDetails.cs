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
            txtDetails.Text = $"작업 이름: {workInstruction.CodeName}\r\n" +
                              $"작업 내용: {workInstruction.WorkDetails}\r\n" +
                              $"날짜: {workInstruction.Date}\r\n" +
                              $"작성자: {workInstruction.Writer}\r\n" +
                              $"우선순위: {workInstruction.Priority}\r\n" +
                              $"작업자:{workInstruction.Worker}\r\n" +
                              $"물량:{workInstruction.Quantity}\r\n" +
                              $"현재상태:{workInstruction.Work_Status}\r\n";
        }
    }
}
