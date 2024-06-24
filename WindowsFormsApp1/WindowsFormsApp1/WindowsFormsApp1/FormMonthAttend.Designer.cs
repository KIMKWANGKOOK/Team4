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
            this.txtEmployeeName = new TextBox();
            this.datePicker = new DateTimePicker();
            this.comboBoxStatus = new ComboBox();
            this.btnSave = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.btnExportToExcel = new Button();
            this.dataGridMonthAttend = new DataGridView();
            this.lblEmployeeName = new Label();
            this.lblDate = new Label();
            this.lblStatus = new Label();
            this.lblSearch = new Label();
            ((ISupportInitialize)(this.dataGridMonthAttend)).BeginInit();
            this.SuspendLayout();

            // 
            // FormMonthAttend
            // 
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.BackColor = Color.FromArgb(46, 59, 78); // Tech Blue
            this.ForeColor = Color.FromArgb(224, 224, 224); // Light Gray
            this.Text = "월별 근태";

            // lblEmployeeName
            this.lblEmployeeName.Location = new Point(20, 30);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new Size(100, 23);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "직원명";
            this.lblEmployeeName.ForeColor = Color.White;

            // txtEmployeeName
            this.txtEmployeeName.Location = new Point(120, 30);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new Size(200, 25);
            this.txtEmployeeName.TabIndex = 1;

            // lblDate
            this.lblDate.Location = new Point(20, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(100, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "날짜";
            this.lblDate.ForeColor = Color.White;

            // datePicker
            this.datePicker.Location = new Point(120, 70);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new Size(200, 25);
            this.datePicker.TabIndex = 3;

            // lblStatus
            this.lblStatus.Location = new Point(20, 110);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(100, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "상태";
            this.lblStatus.ForeColor = Color.White;

            // comboBoxStatus
            this.comboBoxStatus.Items.AddRange(new object[] { "출근", "결근", "지각", "조퇴" });
            this.comboBoxStatus.Location = new Point(120, 110);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new Size(200, 23);
            this.comboBoxStatus.TabIndex = 5;

            // btnSave
            this.btnSave.Location = new Point(340, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.ForeColor = Color.Black;
            this.btnSave.BackColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = Color.White;
            this.btnSave.FlatAppearance.BorderSize = 1;
            this.btnSave.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnSave.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnUpdate
            this.btnUpdate.Location = new Point(420, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(100, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.ForeColor = Color.Black;
            this.btnUpdate.BackColor = Color.White;
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderColor = Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 1;
            this.btnUpdate.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnUpdate.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new Point(500, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(100, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.ForeColor = Color.Black;
            this.btnDelete.BackColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 1;
            this.btnDelete.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnDelete.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // lblSearch
            this.lblSearch.Location = new Point(20, 150);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new Size(100, 23);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "검색";
            this.lblSearch.ForeColor = Color.White;

            // txtSearch
            this.txtSearch.Location = new Point(120, 150);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(200, 25);
            this.txtSearch.TabIndex = 10;

            // btnSearch
            this.btnSearch.Location = new Point(340, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(100, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.ForeColor = Color.Black;
            this.btnSearch.BackColor = Color.White;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderColor = Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnSearch.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // btnExportToExcel
            this.btnExportToExcel.Location = new Point(120, 190);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new Size(100, 23);
            this.btnExportToExcel.TabIndex = 12;
            this.btnExportToExcel.Text = "엑셀로 내보내기";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.ForeColor = Color.Black;
            this.btnExportToExcel.BackColor = Color.White;
            this.btnExportToExcel.FlatStyle = FlatStyle.Flat;
            this.btnExportToExcel.FlatAppearance.BorderColor = Color.White;
            this.btnExportToExcel.FlatAppearance.BorderSize = 1;
            this.btnExportToExcel.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnExportToExcel.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnExportToExcel.Click += new EventHandler(this.btnExportToExcel_Click);

            // dataGridMonthAttend
            this.dataGridMonthAttend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonthAttend.Location = new Point(20, 230);
            this.dataGridMonthAttend.Name = "dataGridMonthAttend";
            this.dataGridMonthAttend.Size = new Size(850, 400);
            this.dataGridMonthAttend.TabIndex = 13;
            this.dataGridMonthAttend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMonthAttend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMonthAttend.BackgroundColor = Color.FromArgb(46, 59, 78);
            this.dataGridMonthAttend.ForeColor = Color.White;
            this.dataGridMonthAttend.GridColor = Color.White;

            // Add controls to form
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dataGridMonthAttend);

            ((ISupportInitialize)(this.dataGridMonthAttend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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

        // 이벤트 핸들러 메서드를 여기에 추가합니다.
    }
}
