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
            txtEmployeeName.Location = new Point(293, 25);
            txtEmployeeName.Multiline = true;
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(224, 34);
            txtEmployeeName.TabIndex = 1;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(293, 149);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(224, 21);
            datePicker.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Items.AddRange(new object[] { "출근", "결근", "지각", "조퇴" });
            comboBoxStatus.Location = new Point(293, 261);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(224, 23);
            comboBoxStatus.TabIndex = 5;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(17, 17, 17);
            btnSave.Location = new Point(556, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(17, 17, 17);
            btnUpdate.Location = new Point(556, 83);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 37);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += Button_MouseEnter;
            btnUpdate.MouseLeave += Button_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(224, 224, 224);
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(17, 17, 17);
            btnDelete.Location = new Point(556, 143);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 37);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(293, 322);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(224, 34);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.FromArgb(17, 17, 17);
            btnSearch.Location = new Point(556, 322);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 37);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += Button_MouseEnter;
            btnSearch.MouseLeave += Button_MouseLeave;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.FromArgb(224, 224, 224);
            btnExportToExcel.FlatAppearance.BorderColor = Color.White;
            btnExportToExcel.FlatStyle = FlatStyle.Flat;
            btnExportToExcel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportToExcel.ForeColor = Color.FromArgb(17, 17, 17);
            btnExportToExcel.Location = new Point(427, 798);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(258, 71);
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
            dataGridMonthAttend.Location = new Point(35, 397);
            dataGridMonthAttend.Name = "dataGridMonthAttend";
            dataGridMonthAttend.ReadOnly = true;
            dataGridMonthAttend.RowHeadersWidth = 51;
            dataGridMonthAttend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMonthAttend.Size = new Size(1104, 371);
            dataGridMonthAttend.TabIndex = 13;
            dataGridMonthAttend.CellContentClick += dataGridMonthAttend_CellContentClick;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.ForeColor = Color.White;
            lblEmployeeName.Location = new Point(20, 25);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(225, 41);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Emp Name";
            lblEmployeeName.Click += lblEmployeeName_Click;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(17, 142);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(225, 52);
            lblDate.TabIndex = 2;
            lblDate.Text = "Start Date";
            lblDate.Click += lblDate_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(20, 261);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(190, 41);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(20, 322);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(118, 45);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(293, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(224, 21);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 37);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 203);
            label1.Name = "label1";
            label1.Size = new Size(190, 40);
            label1.TabIndex = 16;
            label1.Text = "End Date";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 83);
            label2.Name = "label2";
            label2.Size = new Size(190, 46);
            label2.TabIndex = 17;
            label2.Text = "Description";
            // 
            // FormMonthAttend
            // 
            BackColor = Color.FromArgb(46, 59, 78);
            ClientSize = new Size(1902, 1033);
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
            Font = new Font("Microsoft Sans Serif", 9F);
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
