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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            txtTaskName.Font = new Font("Microsoft Sans Serif", 18F);
            txtTaskName.Location = new Point(191, 27);
            txtTaskName.Margin = new Padding(3, 4, 3, 4);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(200, 35);
            txtTaskName.TabIndex = 0;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Microsoft Sans Serif", 18F);
            datePicker.Location = new Point(191, 95);
            datePicker.Margin = new Padding(3, 4, 3, 4);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 35);
            datePicker.TabIndex = 1;
            datePicker.Value = new DateTime(2024, 6, 25, 0, 0, 0, 0);
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // txtWorker
            // 
            txtWorker.Font = new Font("Microsoft Sans Serif", 18F);
            txtWorker.Location = new Point(191, 167);
            txtWorker.Margin = new Padding(3, 4, 3, 4);
            txtWorker.Name = "txtWorker";
            txtWorker.Size = new Size(200, 35);
            txtWorker.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Microsoft Sans Serif", 18F);
            comboBoxStatus.Items.AddRange(new object[] { "완료", "진행 중", "대기" });
            comboBoxStatus.Location = new Point(191, 237);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 37);
            comboBoxStatus.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 18F);
            btnSave.ForeColor = Color.FromArgb(17, 17, 17);
            btnSave.Location = new Point(430, 24);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 4;
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
            btnUpdate.Location = new Point(430, 94);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 5;
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
            btnDelete.Location = new Point(430, 164);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 18F);
            txtSearch.Location = new Point(191, 316);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 35);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 18F);
            btnSearch.ForeColor = Color.FromArgb(17, 17, 17);
            btnSearch.Location = new Point(430, 313);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
            btnSearch.TabIndex = 8;
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
            btnExportToExcel.Location = new Point(430, 234);
            btnExportToExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(120, 40);
            btnExportToExcel.TabIndex = 9;
            btnExportToExcel.Text = "Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            btnExportToExcel.MouseEnter += Button_MouseEnter;
            btnExportToExcel.MouseLeave += Button_MouseLeave;
            // 
            // dataGridWorkPerformances
            // 
            dataGridWorkPerformances.AllowUserToAddRows = false;
            dataGridWorkPerformances.AllowUserToDeleteRows = false;
            dataGridWorkPerformances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridWorkPerformances.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridWorkPerformances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridWorkPerformances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridWorkPerformances.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridWorkPerformances.GridColor = Color.White;
            dataGridWorkPerformances.Location = new Point(30, 436);
            dataGridWorkPerformances.Margin = new Padding(3, 4, 3, 4);
            dataGridWorkPerformances.Name = "dataGridWorkPerformances";
            dataGridWorkPerformances.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridWorkPerformances.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridWorkPerformances.RowHeadersWidth = 51;
            dataGridWorkPerformances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridWorkPerformances.Size = new Size(1840, 400);
            dataGridWorkPerformances.TabIndex = 10;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaskName.ForeColor = Color.White;
            lblTaskName.Location = new Point(30, 30);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(132, 29);
            lblTaskName.TabIndex = 11;
            lblTaskName.Text = "Task name";
            lblTaskName.Click += lblTaskName_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 18F);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(30, 100);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(135, 29);
            lblDate.TabIndex = 12;
            lblDate.Text = "Description";
            // 
            // lblWorker
            // 
            lblWorker.AutoSize = true;
            lblWorker.Font = new Font("Microsoft Sans Serif", 18F);
            lblWorker.ForeColor = Color.White;
            lblWorker.Location = new Point(30, 170);
            lblWorker.Name = "lblWorker";
            lblWorker.Size = new Size(91, 29);
            lblWorker.TabIndex = 13;
            lblWorker.Text = "Worker";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 18F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(30, 240);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 29);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 18F);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(30, 310);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(89, 29);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search";
            lblSearch.Click += lblSearch_Click;
            // 
            // FormWorkPerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 78);
            ClientSize = new Size(1904, 1041);
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
            Margin = new Padding(3, 4, 3, 4);
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
