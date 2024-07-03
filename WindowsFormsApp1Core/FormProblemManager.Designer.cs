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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            txtProblemName.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtProblemName.Location = new Point(220, 20);
            txtProblemName.Margin = new Padding(3, 4, 3, 4);
            txtProblemName.Name = "txtProblemName";
            txtProblemName.Size = new Size(200, 39);
            txtProblemName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtDescription.Location = new Point(220, 90);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 39);
            txtDescription.TabIndex = 1;
            // 
            // datePickerReported
            // 
            datePickerReported.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            datePickerReported.Location = new Point(220, 160);
            datePickerReported.Margin = new Padding(3, 4, 3, 4);
            datePickerReported.Name = "datePickerReported";
            datePickerReported.Size = new Size(200, 39);
            datePickerReported.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "열림", "닫힘", "보류" });
            comboBoxStatus.Location = new Point(220, 234);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 40);
            comboBoxStatus.TabIndex = 3;
            // 
            // btnSaveProblem
            // 
            btnSaveProblem.BackColor = Color.FromArgb(224, 224, 224);
            btnSaveProblem.FlatAppearance.BorderColor = Color.White;
            btnSaveProblem.FlatStyle = FlatStyle.Flat;
            btnSaveProblem.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveProblem.ForeColor = Color.FromArgb(17, 17, 17);
            btnSaveProblem.Location = new Point(450, 20);
            btnSaveProblem.Margin = new Padding(3, 4, 3, 4);
            btnSaveProblem.Name = "btnSaveProblem";
            btnSaveProblem.Size = new Size(120, 40);
            btnSaveProblem.TabIndex = 4;
            btnSaveProblem.Text = "Save";
            btnSaveProblem.UseVisualStyleBackColor = false;
            btnSaveProblem.Click += btnSave_Click;
            btnSaveProblem.MouseEnter += Button_MouseEnter;
            btnSaveProblem.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdateProblem
            // 
            btnUpdateProblem.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdateProblem.FlatAppearance.BorderColor = Color.White;
            btnUpdateProblem.FlatStyle = FlatStyle.Flat;
            btnUpdateProblem.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateProblem.ForeColor = Color.FromArgb(17, 17, 17);
            btnUpdateProblem.Location = new Point(450, 90);
            btnUpdateProblem.Margin = new Padding(3, 4, 3, 4);
            btnUpdateProblem.Name = "btnUpdateProblem";
            btnUpdateProblem.Size = new Size(120, 40);
            btnUpdateProblem.TabIndex = 5;
            btnUpdateProblem.Text = "Revise";
            btnUpdateProblem.UseVisualStyleBackColor = false;
            btnUpdateProblem.Click += btnUpdate_Click;
            btnUpdateProblem.MouseEnter += Button_MouseEnter;
            btnUpdateProblem.MouseLeave += Button_MouseLeave;
            // 
            // btnDeleteProblem
            // 
            btnDeleteProblem.BackColor = Color.FromArgb(224, 224, 224);
            btnDeleteProblem.FlatAppearance.BorderColor = Color.White;
            btnDeleteProblem.FlatStyle = FlatStyle.Flat;
            btnDeleteProblem.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteProblem.ForeColor = Color.FromArgb(17, 17, 17);
            btnDeleteProblem.Location = new Point(450, 159);
            btnDeleteProblem.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProblem.Name = "btnDeleteProblem";
            btnDeleteProblem.Size = new Size(120, 40);
            btnDeleteProblem.TabIndex = 6;
            btnDeleteProblem.Text = "Delete";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 59, 78);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridProblems.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridProblems.GridColor = Color.White;
            dataGridProblems.Location = new Point(30, 450);
            dataGridProblems.Margin = new Padding(3, 4, 3, 4);
            dataGridProblems.Name = "dataGridProblems";
            dataGridProblems.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridProblems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridProblems.RowHeadersWidth = 51;
            dataGridProblems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProblems.Size = new Size(1840, 400);
            dataGridProblems.TabIndex = 14;
            // 
            // lblProblemName
            // 
            lblProblemName.AutoSize = true;
            lblProblemName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProblemName.ForeColor = Color.White;
            lblProblemName.Location = new Point(30, 30);
            lblProblemName.Name = "lblProblemName";
            lblProblemName.Size = new Size(176, 29);
            lblProblemName.TabIndex = 7;
            lblProblemName.Text = "Problem Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(30, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(135, 29);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // lblReportedDate
            // 
            lblReportedDate.AutoSize = true;
            lblReportedDate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReportedDate.ForeColor = Color.White;
            lblReportedDate.Location = new Point(30, 170);
            lblReportedDate.Name = "lblReportedDate";
            lblReportedDate.Size = new Size(164, 29);
            lblReportedDate.TabIndex = 9;
            lblReportedDate.Text = "ReportedDate";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(30, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 29);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtSearch.Location = new Point(220, 310);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 39);
            txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(17, 17, 17);
            btnSearch.Location = new Point(450, 234);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += Button_MouseEnter;
            btnSearch.MouseLeave += Button_MouseLeave;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(30, 310);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(89, 29);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search";
            // 
            // bt_exportExel
            // 
            bt_exportExel.BackColor = Color.FromArgb(224, 224, 224);
            bt_exportExel.FlatAppearance.BorderColor = Color.White;
            bt_exportExel.FlatStyle = FlatStyle.Flat;
            bt_exportExel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_exportExel.ForeColor = Color.FromArgb(17, 17, 17);
            bt_exportExel.Location = new Point(450, 313);
            bt_exportExel.Margin = new Padding(3, 4, 3, 4);
            bt_exportExel.Name = "bt_exportExel";
            bt_exportExel.Size = new Size(120, 40);
            bt_exportExel.TabIndex = 15;
            bt_exportExel.Text = "Excel";
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
