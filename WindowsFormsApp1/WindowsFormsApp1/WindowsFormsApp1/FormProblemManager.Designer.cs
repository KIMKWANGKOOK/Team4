using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    partial class FormProblemManager
    {
        private IContainer components = null;
        private TextBox txtProblemName;
        private TextBox txtDescription;
        private DateTimePicker datePickerReported;
        private ComboBox comboBoxStatus;
        private Button btnSaveProblem;
        private Button btnUpdateProblem;
        private Button btnDeleteProblem;
        private DataGridView dataGridProblems;
        private Label lblProblemName;
        private Label lblDescription;
        private Label lblReportedDate;
        private Label lblStatus;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtProblemName = new TextBox();
            this.txtDescription = new TextBox();
            this.datePickerReported = new DateTimePicker();
            this.comboBoxStatus = new ComboBox();
            this.btnSaveProblem = new Button();
            this.btnUpdateProblem = new Button();
            this.btnDeleteProblem = new Button();
            this.dataGridProblems = new DataGridView();
            this.lblProblemName = new Label();
            this.lblDescription = new Label();
            this.lblReportedDate = new Label();
            this.lblStatus = new Label();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.lblSearch = new Label();
            ((ISupportInitialize)(this.dataGridProblems)).BeginInit();
            this.SuspendLayout();

            // txtProblemName
            this.txtProblemName.Location = new Point(120, 30);
            this.txtProblemName.Name = "txtProblemName";
            this.txtProblemName.Size = new Size(200, 25);
            this.txtProblemName.TabIndex = 0;

            // txtDescription
            this.txtDescription.Location = new Point(120, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Size(200, 25);
            this.txtDescription.TabIndex = 1;

            // datePickerReported
            this.datePickerReported.Location = new Point(120, 110);
            this.datePickerReported.Name = "datePickerReported";
            this.datePickerReported.Size = new Size(200, 25);
            this.datePickerReported.TabIndex = 2;

            // comboBoxStatus
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] { "열림", "닫힘", "보류" }); // 상태를 한글로 변경
            this.comboBoxStatus.Location = new Point(120, 150);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new Size(200, 23);
            this.comboBoxStatus.TabIndex = 3;

            // btnSaveProblem
            this.btnSaveProblem.Location = new Point(340, 30);
            this.btnSaveProblem.Name = "btnSaveProblem";
            this.btnSaveProblem.Size = new Size(100, 23);
            this.btnSaveProblem.TabIndex = 4;
            this.btnSaveProblem.Text = "저장"; // Save to 저장
            this.btnSaveProblem.UseVisualStyleBackColor = true;
            this.btnSaveProblem.ForeColor = Color.Black;
            this.btnSaveProblem.BackColor = Color.White;
            this.btnSaveProblem.FlatStyle = FlatStyle.Flat;
            this.btnSaveProblem.FlatAppearance.BorderColor = Color.White;
            this.btnSaveProblem.FlatAppearance.BorderSize = 1;
            this.btnSaveProblem.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnSaveProblem.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnSaveProblem.Click += new EventHandler(this.btnSave_Click);


            // btnUpdateProblem
            this.btnUpdateProblem.Location = new Point(340, 70);
            this.btnUpdateProblem.Name = "btnUpdateProblem";
            this.btnUpdateProblem.Size = new Size(100, 23);
            this.btnUpdateProblem.TabIndex = 5;
            this.btnUpdateProblem.Text = "수정"; // Update to 수정
            this.btnUpdateProblem.UseVisualStyleBackColor = true;
            this.btnUpdateProblem.ForeColor = Color.Black;
            this.btnUpdateProblem.BackColor = Color.White;
            this.btnUpdateProblem.FlatStyle = FlatStyle.Flat;
            this.btnUpdateProblem.FlatAppearance.BorderColor = Color.White;
            this.btnUpdateProblem.FlatAppearance.BorderSize = 1;
            this.btnUpdateProblem.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnUpdateProblem.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnUpdateProblem.Click += new EventHandler(this.btnUpdate_Click);

            // btnDeleteProblem
            this.btnDeleteProblem.Location = new Point(340, 110);
            this.btnDeleteProblem.Name = "btnDeleteProblem";
            this.btnDeleteProblem.Size = new Size(100, 23);
            this.btnDeleteProblem.TabIndex = 6;
            this.btnDeleteProblem.Text = "삭제"; // Delete to 삭제
            this.btnDeleteProblem.UseVisualStyleBackColor = true;
            this.btnDeleteProblem.ForeColor = Color.Black;
            this.btnDeleteProblem.BackColor = Color.White;
            this.btnDeleteProblem.FlatStyle = FlatStyle.Flat;
            this.btnDeleteProblem.FlatAppearance.BorderColor = Color.White;
            this.btnDeleteProblem.FlatAppearance.BorderSize = 1;
            this.btnDeleteProblem.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnDeleteProblem.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnDeleteProblem.Click += new EventHandler(this.btnUpdate_Click);

            // lblProblemName
            this.lblProblemName.AutoSize = true;
            this.lblProblemName.ForeColor = Color.White;
            this.lblProblemName.Location = new Point(20, 35);
            this.lblProblemName.Name = "lblProblemName";
            this.lblProblemName.Size = new Size(55, 13);
            this.lblProblemName.TabIndex = 7;
            this.lblProblemName.Text = "문제명"; // Problem Name to 문제명

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = Color.White;
            this.lblDescription.Location = new Point(20, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "설명"; // Description to 설명

            // lblReportedDate
            this.lblReportedDate.AutoSize = true;
            this.lblReportedDate.ForeColor = Color.White;
            this.lblReportedDate.Location = new Point(20, 115);
            this.lblReportedDate.Name = "lblReportedDate";
            this.lblReportedDate.Size = new Size(60, 13);
            this.lblReportedDate.TabIndex = 9;
            this.lblReportedDate.Text = "보고일"; // Reported Date to 보고일

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = Color.White;
            this.lblStatus.Location = new Point(20, 155);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(37, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "상태"; // Status to 상태

            // txtSearch
            this.txtSearch.Location = new Point(120, 190);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(200, 25);
            this.txtSearch.TabIndex = 11;

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = Color.White;
            this.lblSearch.Location = new Point(20, 195);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new Size(37, 13);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "검색"; // Search to 검색

            // btnSearch
            this.btnSearch.Location = new Point(340, 190);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(100, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "검색"; // Search to 검색
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.ForeColor = Color.Black;
            this.btnSearch.BackColor = Color.White;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderColor = Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnSearch.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // dataGridProblems
            this.dataGridProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProblems.Location = new Point(20, 230);
            this.dataGridProblems.Name = "dataGridProblems";
            this.dataGridProblems.Size = new Size(850, 400);
            this.dataGridProblems.TabIndex = 14;
            this.dataGridProblems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProblems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProblems.BackgroundColor = Color.FromArgb(46, 59, 78);
            this.dataGridProblems.ForeColor = Color.White;
            this.dataGridProblems.GridColor = Color.White;

            // FormProblemManager
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 700);
            this.Controls.Add(this.txtProblemName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.datePickerReported);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnSaveProblem);
            this.Controls.Add(this.btnUpdateProblem);
            this.Controls.Add(this.btnDeleteProblem);
            this.Controls.Add(this.lblProblemName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblReportedDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridProblems);
            this.Name = "FormProblemManager";
            this.Text = "문제 관리"; // Problem Manager to 문제 관리
            this.BackColor = Color.FromArgb(46, 59, 78); // Background color set to Tech Blue
            ((ISupportInitialize)(this.dataGridProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = ColorTranslator.FromHtml("#D3D3D3"); // Light Gray for hover effect
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.White;
            }
        }
    }
}
