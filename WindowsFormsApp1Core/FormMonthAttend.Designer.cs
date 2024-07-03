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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            txtEmployeeName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(190, 27);
            txtEmployeeName.Multiline = true;
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(200, 40);
            txtEmployeeName.TabIndex = 1;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Microsoft Sans Serif", 18F);
            datePicker.Location = new Point(190, 170);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 35);
            datePicker.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Microsoft Sans Serif", 18F);
            comboBoxStatus.Items.AddRange(new object[] { "출근", "결근", "지각", "조퇴" });
            comboBoxStatus.Location = new Point(190, 307);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 37);
            comboBoxStatus.TabIndex = 5;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 18F);
            btnSave.ForeColor = Color.FromArgb(17, 17, 17);
            btnSave.Location = new Point(427, 27);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
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
            btnUpdate.Font = new Font("Microsoft Sans Serif", 18F);
            btnUpdate.ForeColor = Color.FromArgb(17, 17, 17);
            btnUpdate.Location = new Point(427, 100);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
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
            btnDelete.Font = new Font("Microsoft Sans Serif", 18F);
            btnDelete.ForeColor = Color.FromArgb(17, 17, 17);
            btnDelete.Location = new Point(427, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 18F);
            txtSearch.Location = new Point(190, 377);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 40);
            txtSearch.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 18F);
            btnSearch.ForeColor = Color.FromArgb(17, 17, 17);
            btnSearch.Location = new Point(427, 374);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
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
            btnExportToExcel.Font = new Font("Microsoft Sans Serif", 18F);
            btnExportToExcel.ForeColor = Color.FromArgb(17, 17, 17);
            btnExportToExcel.Location = new Point(427, 239);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(120, 40);
            btnExportToExcel.TabIndex = 12;
            btnExportToExcel.Text = "Excel";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridMonthAttend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridMonthAttend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridMonthAttend.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridMonthAttend.GridColor = Color.White;
            dataGridMonthAttend.Location = new Point(30, 450);
            dataGridMonthAttend.Name = "dataGridMonthAttend";
            dataGridMonthAttend.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridMonthAttend.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridMonthAttend.RowHeadersWidth = 51;
            dataGridMonthAttend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMonthAttend.Size = new Size(1840, 400);
            dataGridMonthAttend.TabIndex = 13;
            dataGridMonthAttend.CellContentClick += dataGridMonthAttend_CellContentClick;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.ForeColor = Color.White;
            lblEmployeeName.Location = new Point(30, 30);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(143, 41);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Emp Name";
            lblEmployeeName.Click += lblEmployeeName_Click;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(30, 170);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(146, 52);
            lblDate.TabIndex = 2;
            lblDate.Text = "Start Date";
            lblDate.Click += lblDate_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(30, 310);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(104, 41);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(30, 380);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(118, 45);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "Search";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 18F);
            dateTimePicker1.Location = new Point(190, 240);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 35);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 18F);
            textBox1.Location = new Point(190, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 40);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 240);
            label1.Name = "label1";
            label1.Size = new Size(127, 40);
            label1.TabIndex = 16;
            label1.Text = "End Date";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(143, 46);
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
