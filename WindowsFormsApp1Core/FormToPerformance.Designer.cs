using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace WorkManagementSystem
{
    partial class FormToPerformance
    {
        private IContainer components = null;
        private TextBox txtPlanName;
        private TextBox txtDescription;
        private DateTimePicker datePickerStart;
        private DateTimePicker datePickerEnd;
        private ComboBox comboBoxStatus;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dataGridPerformancePlans;
        private Button btnExportToExcel;
        private Label lblPlanName;
        private Label lblDescription;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblStatus;

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
            this.txtPlanName = new TextBox();
            this.txtDescription = new TextBox();
            this.datePickerStart = new DateTimePicker();
            this.datePickerEnd = new DateTimePicker();
            this.comboBoxStatus = new ComboBox();
            this.btnSave = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnSearch = new Button();
            this.txtSearch = new TextBox();
            this.dataGridPerformancePlans = new DataGridView();
            this.btnExportToExcel = new Button();
            this.lblPlanName = new Label();
            this.lblDescription = new Label();
            this.lblStartDate = new Label();
            this.lblEndDate = new Label();
            this.lblStatus = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerformancePlans)).BeginInit();
            this.SuspendLayout();

            // lblPlanName
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Location = new System.Drawing.Point(20, 30);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(55, 13);
            this.lblPlanName.TabIndex = 0;
            this.lblPlanName.Text = "계획 이름"; // Plan Name to 계획 이름
            this.lblPlanName.ForeColor = System.Drawing.Color.White;

            // txtPlanName
            this.txtPlanName.Location = new System.Drawing.Point(120, 30);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(200, 20);
            this.txtPlanName.TabIndex = 1;

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "설명"; // Description to 설명
            this.lblDescription.ForeColor = System.Drawing.Color.White;

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(120, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 3;

            // lblStartDate
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(20, 110);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "시작 날짜"; // Start Date to 시작 날짜
            this.lblStartDate.ForeColor = System.Drawing.Color.White;

            // datePickerStart
            this.datePickerStart.Location = new System.Drawing.Point(120, 110);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(200, 20);
            this.datePickerStart.TabIndex = 5;

            // lblEndDate
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(20, 150);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "종료 날짜"; // End Date to 종료 날짜
            this.lblEndDate.ForeColor = System.Drawing.Color.White;

            // datePickerEnd
            this.datePickerEnd.Location = new System.Drawing.Point(120, 150);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.datePickerEnd.TabIndex = 7;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(31, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "상태"; // Status to 상태
            this.lblStatus.ForeColor = System.Drawing.Color.White;

            // comboBoxStatus
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] { "계획됨", "진행 중", "완료" }); // Planned, In Progress, Completed to 계획됨, 진행 중, 완료
            this.comboBoxStatus.Location = new System.Drawing.Point(120, 190);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStatus.TabIndex = 9;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(340, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "저장"; // Save to 저장
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 1;
            this.btnSave.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnSave.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(340, 70);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "수정"; // Update to 수정
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 1;
            this.btnUpdate.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnUpdate.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(340, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "삭제"; // Delete to 삭제
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 1;
            this.btnDelete.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnDelete.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(120, 230);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 13;

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(340, 230);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "검색"; // Search to 검색
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnSearch.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // dataGridPerformancePlans
            this.dataGridPerformancePlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPerformancePlans.Location = new System.Drawing.Point(20, 270);
            this.dataGridPerformancePlans.Name = "dataGridPerformancePlans";
            this.dataGridPerformancePlans.Size = new System.Drawing.Size(420, 150);
            this.dataGridPerformancePlans.TabIndex = 15;
            this.dataGridPerformancePlans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPerformancePlans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPerformancePlans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.dataGridPerformancePlans.GridColor = System.Drawing.Color.White;

            // btnExportToExcel
            this.btnExportToExcel.Location = new System.Drawing.Point(120, 430);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(100, 23);
            this.btnExportToExcel.TabIndex = 16;
            this.btnExportToExcel.Text = "엑셀로 내보내기"; // Export to Excel to 엑셀로 내보내기
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportToExcel.BackColor = System.Drawing.Color.White;
            this.btnExportToExcel.FlatStyle = FlatStyle.Flat;
            this.btnExportToExcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExportToExcel.FlatAppearance.BorderSize = 1;
            this.btnExportToExcel.MouseEnter += new EventHandler(this.Button_MouseEnter);
            this.btnExportToExcel.MouseLeave += new EventHandler(this.Button_MouseLeave);
            this.btnExportToExcel.Click += new EventHandler(this.btnExportToExcel_Click);

            // FormToPerformance
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblPlanName);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.datePickerStart);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.datePickerEnd);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridPerformancePlans);
            this.Controls.Add(this.btnExportToExcel);
            this.Name = "FormToPerformance";
            this.Text = "계획 및 실적"; // Plan and Performance to 계획 및 실적
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3B4E");
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPerformancePlans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.ColorTranslator.FromHtml("#D3D3D3"); // Light Gray for hover effect
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = System.Drawing.Color.White;
        }
    }
}
