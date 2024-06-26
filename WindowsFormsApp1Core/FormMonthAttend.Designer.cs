using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    partial class FormMonthAttend
    {
        private IContainer components = null;
        private TextBox txtEmployeeName;
        private DateTimePicker datePicker;
        private ComboBox comboBoxStatus;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnExportToExcel;
        private DataGridView dataGridMonthAttend;
        private Label lblEmployeeName;
        private Label lblDate;
        private Label lblStatus;
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
            txtEmployeeName = new TextBox();
            datePicker = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnExportToExcel = new Button();
            dataGridMonthAttend = new DataGridView();
            lblEmployeeName = new Label();
            lblDate = new Label();
            lblStatus = new Label();
            lblSearch = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((ISupportInitialize)dataGridMonthAttend).BeginInit();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(172, 13);
            txtEmployeeName.Multiline = true;
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(200, 45);
            txtEmployeeName.TabIndex = 1;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(683, 79);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 27);
            datePicker.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Items.AddRange(new object[] { "출근", "결근", "지각", "조퇴" });
            comboBoxStatus.Location = new Point(172, 134);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 28);
            comboBoxStatus.TabIndex = 5;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(394, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(394, 64);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 45);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += Button_MouseEnter;
            btnUpdate.MouseLeave += Button_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("맑은 고딕", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(905, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 44);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(683, 13);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 45);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(905, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 44);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += Button_MouseEnter;
            btnSearch.MouseLeave += Button_MouseLeave;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.White;
            btnExportToExcel.FlatAppearance.BorderColor = Color.White;
            btnExportToExcel.FlatStyle = FlatStyle.Flat;
            btnExportToExcel.ForeColor = Color.Black;
            btnExportToExcel.Location = new Point(414, 591);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(235, 51);
            btnExportToExcel.TabIndex = 12;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            btnExportToExcel.MouseEnter += Button_MouseEnter;
            btnExportToExcel.MouseLeave += Button_MouseLeave;
            // 
            // dataGridMonthAttend
            // 
            dataGridMonthAttend.AllowUserToAddRows = false;
            dataGridMonthAttend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMonthAttend.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridMonthAttend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMonthAttend.GridColor = Color.White;
            dataGridMonthAttend.Location = new Point(64, 209);
            dataGridMonthAttend.Name = "dataGridMonthAttend";
            dataGridMonthAttend.ReadOnly = true;
            dataGridMonthAttend.RowHeadersWidth = 51;
            dataGridMonthAttend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMonthAttend.Size = new Size(933, 334);
            dataGridMonthAttend.TabIndex = 13;
            dataGridMonthAttend.CellContentClick += dataGridMonthAttend_CellContentClick;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblEmployeeName.ForeColor = Color.White;
            lblEmployeeName.Location = new Point(20, 30);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(128, 27);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Emp Name";
            lblEmployeeName.Click += lblEmployeeName_Click;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(549, 79);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(128, 34);
            lblDate.TabIndex = 2;
            lblDate.Text = "Start Date";
            lblDate.Click += lblDate_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(20, 139);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(555, 30);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(94, 31);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(683, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 73);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 40);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.White;
            label1.Location = new Point(549, 128);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 16;
            label1.Text = "End Date";
            // 
            // label2
            // 
            label2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 86);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 17;
            label2.Text = "Description";
            // 
            // FormMonthAttend
            // 
            BackColor = Color.FromArgb(46, 59, 78);
            ClientSize = new Size(998, 697);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblDate);
            Controls.Add(datePicker);
            Controls.Add(lblStatus);
            Controls.Add(comboBoxStatus);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnExportToExcel);
            Controls.Add(dataGridMonthAttend);
            ForeColor = Color.FromArgb(224, 224, 224);
            Name = "FormMonthAttend";
            Text = "월별 근태";
            WindowState = FormWindowState.Maximized;
            Load += FormMonthAttend_Load;
            ((ISupportInitialize)dataGridMonthAttend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3"); // Light Gray for hover effect
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = System.Drawing.Color.White;
            }
        }

        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;

        // 이벤트 핸들러 메서드를 여기에 추가합니다.
    }
}
