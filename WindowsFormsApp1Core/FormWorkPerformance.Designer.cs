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
            this.txtTaskName = new TextBox();
            this.datePicker = new DateTimePicker();
            this.txtWorker = new TextBox();
            this.comboBoxStatus = new ComboBox();
            this.btnSave = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.btnExportToExcel = new Button();
            this.dataGridWorkPerformances = new DataGridView();
            this.lblTaskName = new Label();
            this.lblDate = new Label();
            this.lblWorker = new Label();
            this.lblStatus = new Label();
            this.lblSearch = new Label();
            ((ISupportInitialize)(this.dataGridWorkPerformances)).BeginInit();
            this.SuspendLayout();

            // txtTaskName
            this.txtTaskName.Location = new Point(120, 30);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new Size(200, 25);
            this.txtTaskName.TabIndex = 0;

            // datePicker
            this.datePicker.Location = new Point(120, 70);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new Size(200, 25);
            this.datePicker.TabIndex = 1;

            // txtWorker
            this.txtWorker.Location = new Point(120, 110);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new Size(200, 25);
            this.txtWorker.TabIndex = 2;

            // comboBoxStatus
            this.comboBoxStatus.Items.AddRange(new object[] { "완료", "진행 중", "대기" });
            this.comboBoxStatus.Location = new Point(120, 150);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new Size(200, 23);
            this.comboBoxStatus.TabIndex = 3;

            // btnSave
            this.btnSave.Location = new Point(340, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 23);
            this.btnSave.TabIndex = 4;
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
            this.btnUpdate.Location = new Point(450, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(100, 23);
            this.btnUpdate.TabIndex = 5;
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
            this.btnDelete.Location = new Point(450, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(100, 23);
            this.btnDelete.TabIndex = 6;
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

            // txtSearch
            this.txtSearch.Location = new Point(120, 230);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new Size(200, 25);
            this.txtSearch.TabIndex = 7;

            // btnSearch
            this.btnSearch.Location = new Point(340, 230);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(100, 23);
            this.btnSearch.TabIndex = 8;
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
            this.btnExportToExcel.Location = new Point(120, 270);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new Size(100, 23);
            this.btnExportToExcel.TabIndex = 9;
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

            // dataGridWorkPerformances
            this.dataGridWorkPerformances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkPerformances.Location = new Point(20, 310);
            this.dataGridWorkPerformances.Name = "dataGridWorkPerformances";
            this.dataGridWorkPerformances.Size = new Size(850, 350);
            this.dataGridWorkPerformances.TabIndex = 10;
            this.dataGridWorkPerformances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWorkPerformances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWorkPerformances.BackgroundColor = Color.FromArgb(46, 59, 78);
            this.dataGridWorkPerformances.ForeColor = Color.White;
            this.dataGridWorkPerformances.GridColor = Color.White;

            // lblTaskName
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = Color.White;
            this.lblTaskName.Location = new Point(20, 35);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new Size(55, 13);
            this.lblTaskName.TabIndex = 11;
            this.lblTaskName.Text = "작업명";

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = Color.White;
            this.lblDate.Location = new Point(20, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(31, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "날짜";

            // lblWorker
            this.lblWorker.AutoSize = true;
            this.lblWorker.ForeColor = Color.White;
            this.lblWorker.Location = new Point(20, 115);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new Size(43, 13);
            this.lblWorker.TabIndex = 13;
            this.lblWorker.Text = "작업자";

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = Color.White;
            this.lblStatus.Location = new Point(20, 155);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(31, 13);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "상태";

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = Color.White;
            this.lblSearch.Location = new Point(20, 235);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new Size(31, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "검색";

            // FormWorkPerformance
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 700);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtWorker);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.dataGridWorkPerformances);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSearch);
            this.Name = "FormWorkPerformance";
            this.Text = "작업 실적";
            this.BackColor = Color.FromArgb(46, 59, 78); // Tech Blue
            ((ISupportInitialize)(this.dataGridWorkPerformances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
