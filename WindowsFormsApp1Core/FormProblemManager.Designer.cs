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
            txtProblemName = new TextBox();
            txtDescription = new TextBox();
            datePickerReported = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            btnSaveProblem = new Button();
            btnUpdateProblem = new Button();
            btnDeleteProblem = new Button();
            dataGridProblems = new DataGridView();
            lblProblemName = new Label();
            lblDescription = new Label();
            lblReportedDate = new Label();
            lblStatus = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblSearch = new Label();
            bt_exportExel = new Button();
            ((ISupportInitialize)dataGridProblems).BeginInit();
            SuspendLayout();
            // 
            // txtProblemName
            // 
            txtProblemName.Location = new Point(140, 34);
            txtProblemName.Margin = new Padding(3, 4, 3, 4);
            txtProblemName.Name = "txtProblemName";
            txtProblemName.Size = new Size(233, 23);
            txtProblemName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(140, 81);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(233, 23);
            txtDescription.TabIndex = 1;
            // 
            // datePickerReported
            // 
            datePickerReported.Location = new Point(140, 127);
            datePickerReported.Margin = new Padding(3, 4, 3, 4);
            datePickerReported.Name = "datePickerReported";
            datePickerReported.Size = new Size(233, 23);
            datePickerReported.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "열림", "닫힘", "보류" });
            comboBoxStatus.Location = new Point(140, 173);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(233, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // btnSaveProblem
            // 
            btnSaveProblem.BackColor = Color.White;
            btnSaveProblem.FlatAppearance.BorderColor = Color.White;
            btnSaveProblem.FlatStyle = FlatStyle.Flat;
            btnSaveProblem.ForeColor = Color.Black;
            btnSaveProblem.Location = new Point(397, 34);
            btnSaveProblem.Margin = new Padding(3, 4, 3, 4);
            btnSaveProblem.Name = "btnSaveProblem";
            btnSaveProblem.Size = new Size(117, 26);
            btnSaveProblem.TabIndex = 4;
            btnSaveProblem.Text = "저장";
            btnSaveProblem.UseVisualStyleBackColor = false;
            btnSaveProblem.Click += btnSave_Click;
            btnSaveProblem.MouseEnter += Button_MouseEnter;
            btnSaveProblem.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdateProblem
            // 
            btnUpdateProblem.BackColor = Color.White;
            btnUpdateProblem.FlatAppearance.BorderColor = Color.White;
            btnUpdateProblem.FlatStyle = FlatStyle.Flat;
            btnUpdateProblem.ForeColor = Color.Black;
            btnUpdateProblem.Location = new Point(397, 81);
            btnUpdateProblem.Margin = new Padding(3, 4, 3, 4);
            btnUpdateProblem.Name = "btnUpdateProblem";
            btnUpdateProblem.Size = new Size(117, 26);
            btnUpdateProblem.TabIndex = 5;
            btnUpdateProblem.Text = "수정";
            btnUpdateProblem.UseVisualStyleBackColor = false;
            btnUpdateProblem.Click += btnUpdate_Click;
            btnUpdateProblem.MouseEnter += Button_MouseEnter;
            btnUpdateProblem.MouseLeave += Button_MouseLeave;
            // 
            // btnDeleteProblem
            // 
            btnDeleteProblem.BackColor = Color.White;
            btnDeleteProblem.FlatAppearance.BorderColor = Color.White;
            btnDeleteProblem.FlatStyle = FlatStyle.Flat;
            btnDeleteProblem.ForeColor = Color.Black;
            btnDeleteProblem.Location = new Point(397, 127);
            btnDeleteProblem.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProblem.Name = "btnDeleteProblem";
            btnDeleteProblem.Size = new Size(117, 26);
            btnDeleteProblem.TabIndex = 6;
            btnDeleteProblem.Text = "삭제";
            btnDeleteProblem.UseVisualStyleBackColor = false;
            btnDeleteProblem.Click += btnUpdate_Click;
            btnDeleteProblem.MouseEnter += Button_MouseEnter;
            btnDeleteProblem.MouseLeave += Button_MouseLeave;
            // 
            // dataGridProblems
            // 
            dataGridProblems.AllowUserToAddRows = false;
            dataGridProblems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProblems.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProblems.GridColor = Color.White;
            dataGridProblems.Location = new Point(23, 266);
            dataGridProblems.Margin = new Padding(3, 4, 3, 4);
            dataGridProblems.Name = "dataGridProblems";
            dataGridProblems.ReadOnly = true;
            dataGridProblems.RowHeadersWidth = 51;
            dataGridProblems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProblems.Size = new Size(992, 353);
            dataGridProblems.TabIndex = 14;
            // 
            // lblProblemName
            // 
            lblProblemName.AutoSize = true;
            lblProblemName.ForeColor = Color.White;
            lblProblemName.Location = new Point(23, 40);
            lblProblemName.Name = "lblProblemName";
            lblProblemName.Size = new Size(43, 15);
            lblProblemName.TabIndex = 7;
            lblProblemName.Text = "문제명";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(23, 86);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(31, 15);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "설명";
            // 
            // lblReportedDate
            // 
            lblReportedDate.AutoSize = true;
            lblReportedDate.ForeColor = Color.White;
            lblReportedDate.Location = new Point(23, 133);
            lblReportedDate.Name = "lblReportedDate";
            lblReportedDate.Size = new Size(43, 15);
            lblReportedDate.TabIndex = 9;
            lblReportedDate.Text = "보고일";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(23, 178);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(31, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "상태";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(140, 219);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(233, 23);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(397, 219);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 26);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "검색";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += Button_MouseEnter;
            btnSearch.MouseLeave += Button_MouseLeave;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(23, 225);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(31, 15);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "검색";
            // 
            // bt_exportExel
            // 
            bt_exportExel.BackColor = Color.White;
            bt_exportExel.FlatAppearance.BorderColor = Color.White;
            bt_exportExel.FlatStyle = FlatStyle.Flat;
            bt_exportExel.ForeColor = Color.Black;
            bt_exportExel.Location = new Point(446, 640);
            bt_exportExel.Margin = new Padding(3, 4, 3, 4);
            bt_exportExel.Name = "bt_exportExel";
            bt_exportExel.Size = new Size(117, 26);
            bt_exportExel.TabIndex = 15;
            bt_exportExel.Text = "엑셀로 다운";
            bt_exportExel.UseVisualStyleBackColor = false;
            bt_exportExel.Click += btnExport_Click;
            // 
            // FormProblemManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 78);
            ClientSize = new Size(1904, 1041);
            Controls.Add(bt_exportExel);
            Controls.Add(txtProblemName);
            Controls.Add(txtDescription);
            Controls.Add(datePickerReported);
            Controls.Add(comboBoxStatus);
            Controls.Add(btnSaveProblem);
            Controls.Add(btnUpdateProblem);
            Controls.Add(btnDeleteProblem);
            Controls.Add(lblProblemName);
            Controls.Add(lblDescription);
            Controls.Add(lblReportedDate);
            Controls.Add(lblStatus);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridProblems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProblemManager";
            Text = "문제 관리";
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)dataGridProblems).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

        private Button bt_exportExel;
    }
}
