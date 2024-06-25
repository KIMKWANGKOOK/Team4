using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    partial class FormWorkPerformance
    {
        private IContainer components = null;
        private TextBox txtTaskName;
        private DateTimePicker datePicker;
        private TextBox txtWorker;
        private ComboBox comboBoxStatus;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnExportToExcel;
        private DataGridView dataGridWorkPerformances;
        private Label lblTaskName;
        private Label lblDate;
        private Label lblWorker;
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
            txtTaskName = new TextBox();
            datePicker = new DateTimePicker();
            txtWorker = new TextBox();
            comboBoxStatus = new ComboBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnExportToExcel = new Button();
            dataGridWorkPerformances = new DataGridView();
            lblTaskName = new Label();
            lblDate = new Label();
            lblWorker = new Label();
            lblStatus = new Label();
            lblSearch = new Label();
            ((ISupportInitialize)dataGridWorkPerformances).BeginInit();
            SuspendLayout();
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(180, 46);
            txtTaskName.Margin = new Padding(4, 5, 4, 5);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(298, 27);
            txtTaskName.TabIndex = 0;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(180, 108);
            datePicker.Margin = new Padding(4, 5, 4, 5);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(298, 27);
            datePicker.TabIndex = 1;
            datePicker.Value = new DateTime(2024, 6, 25, 0, 0, 0, 0);
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // txtWorker
            // 
            txtWorker.Location = new Point(180, 169);
            txtWorker.Margin = new Padding(4, 5, 4, 5);
            txtWorker.Name = "txtWorker";
            txtWorker.Size = new Size(298, 27);
            txtWorker.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Items.AddRange(new object[] { "완료", "진행 중", "대기" });
            comboBoxStatus.Location = new Point(180, 231);
            comboBoxStatus.Margin = new Padding(4, 5, 4, 5);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(298, 28);
            comboBoxStatus.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(510, 46);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 4;
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
            btnUpdate.Location = new Point(510, 106);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 35);
            btnUpdate.TabIndex = 5;
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
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(510, 170);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(180, 354);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(298, 27);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(510, 354);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 35);
            btnSearch.TabIndex = 8;
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
            btnExportToExcel.Location = new Point(180, 415);
            btnExportToExcel.Margin = new Padding(4, 5, 4, 5);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(150, 35);
            btnExportToExcel.TabIndex = 9;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            btnExportToExcel.MouseEnter += Button_MouseEnter;
            btnExportToExcel.MouseLeave += Button_MouseLeave;
            // 
            // dataGridWorkPerformances
            // 
            dataGridWorkPerformances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridWorkPerformances.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridWorkPerformances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWorkPerformances.GridColor = Color.White;
            dataGridWorkPerformances.Location = new Point(30, 477);
            dataGridWorkPerformances.Margin = new Padding(4, 5, 4, 5);
            dataGridWorkPerformances.Name = "dataGridWorkPerformances";
            dataGridWorkPerformances.RowHeadersWidth = 51;
            dataGridWorkPerformances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridWorkPerformances.Size = new Size(1275, 538);
            dataGridWorkPerformances.TabIndex = 10;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.ForeColor = Color.White;
            lblTaskName.Location = new Point(30, 54);
            lblTaskName.Margin = new Padding(4, 0, 4, 0);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(82, 20);
            lblTaskName.TabIndex = 11;
            lblTaskName.Text = "Task name";
            lblTaskName.Click += lblTaskName_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(30, 115);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(86, 20);
            lblDate.TabIndex = 12;
            lblDate.Text = "Description";
            // 
            // lblWorker
            // 
            lblWorker.AutoSize = true;
            lblWorker.ForeColor = Color.White;
            lblWorker.Location = new Point(30, 177);
            lblWorker.Margin = new Padding(4, 0, 4, 0);
            lblWorker.Name = "lblWorker";
            lblWorker.Size = new Size(55, 20);
            lblWorker.TabIndex = 13;
            lblWorker.Text = "worker";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(30, 238);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(30, 362);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(54, 20);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search";
            // 
            // FormWorkPerformance
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 78);
            ClientSize = new Size(1350, 1055);
            Controls.Add(txtTaskName);
            Controls.Add(datePicker);
            Controls.Add(txtWorker);
            Controls.Add(comboBoxStatus);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnExportToExcel);
            Controls.Add(dataGridWorkPerformances);
            Controls.Add(lblTaskName);
            Controls.Add(lblDate);
            Controls.Add(lblWorker);
            Controls.Add(lblStatus);
            Controls.Add(lblSearch);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormWorkPerformance";
            Text = "작업 실적";
            ((ISupportInitialize)dataGridWorkPerformances).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#D3D3D3"); // Light Gray for hover effect
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        // 이벤트 핸들러 메서드들 구현은 여기에 추가합니다.
    }
}
