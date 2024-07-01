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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtPlanName = new TextBox();
            txtDescription = new TextBox();
            datePickerStart = new DateTimePicker();
            datePickerEnd = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridPerformancePlans = new DataGridView();
            btnExportToExcel = new Button();
            lblPlanName = new Label();
            lblDescription = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblStatus = new Label();
            ((ISupportInitialize)dataGridPerformancePlans).BeginInit();
            SuspendLayout();
            // 
            // txtPlanName
            // 
            txtPlanName.Font = new Font("Microsoft Sans Serif", 18F);
            txtPlanName.Location = new Point(189, 24);
            txtPlanName.Margin = new Padding(4, 3, 4, 3);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(200, 35);
            txtPlanName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft Sans Serif", 18F);
            txtDescription.Location = new Point(189, 94);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 35);
            txtDescription.TabIndex = 3;
            // 
            // datePickerStart
            // 
            datePickerStart.Font = new Font("Microsoft Sans Serif", 18F);
            datePickerStart.Location = new Point(189, 165);
            datePickerStart.Margin = new Padding(4, 3, 4, 3);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new Size(200, 35);
            datePickerStart.TabIndex = 5;
            // 
            // datePickerEnd
            // 
            datePickerEnd.Font = new Font("Microsoft Sans Serif", 18F);
            datePickerEnd.Location = new Point(189, 235);
            datePickerEnd.Margin = new Padding(4, 3, 4, 3);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new Size(200, 35);
            datePickerEnd.TabIndex = 7;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Microsoft Sans Serif", 18F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "계획됨", "진행 중", "완료" });
            comboBoxStatus.Location = new Point(189, 307);
            comboBoxStatus.Margin = new Padding(4, 3, 4, 3);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 37);
            comboBoxStatus.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(244, 244, 244);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 18F);
            btnSave.ForeColor = Color.FromArgb(17, 17, 17);
            btnSave.Location = new Point(419, 24);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.MouseEnter += Button_MouseEnter;
            btnSave.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(244, 244, 244);
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 18F);
            btnUpdate.ForeColor = Color.FromArgb(17, 17, 17);
            btnUpdate.Location = new Point(419, 91);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Revise";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.MouseEnter += Button_MouseEnter;
            btnUpdate.MouseLeave += Button_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 244, 244);
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 18F);
            btnDelete.ForeColor = Color.FromArgb(17, 17, 17);
            btnDelete.Location = new Point(419, 164);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(244, 244, 244);
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 18F);
            btnSearch.ForeColor = Color.FromArgb(17, 17, 17);
            btnSearch.Location = new Point(419, 372);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Serch";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.MouseEnter += Button_MouseEnter;
            btnSearch.MouseLeave += Button_MouseLeave;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 18F);
            txtSearch.Location = new Point(189, 377);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 35);
            txtSearch.TabIndex = 13;
            // 
            // dataGridPerformancePlans
            // 
            dataGridPerformancePlans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPerformancePlans.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPerformancePlans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPerformancePlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridPerformancePlans.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridPerformancePlans.GridColor = Color.White;
            dataGridPerformancePlans.Location = new Point(30, 450);
            dataGridPerformancePlans.Margin = new Padding(4, 3, 4, 3);
            dataGridPerformancePlans.Name = "dataGridPerformancePlans";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridPerformancePlans.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridPerformancePlans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPerformancePlans.Size = new Size(1840, 400);
            dataGridPerformancePlans.TabIndex = 15;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.FromArgb(244, 244, 244);
            btnExportToExcel.FlatAppearance.BorderColor = Color.White;
            btnExportToExcel.FlatStyle = FlatStyle.Flat;
            btnExportToExcel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportToExcel.ForeColor = Color.FromArgb(17, 17, 17);
            btnExportToExcel.Location = new Point(419, 234);
            btnExportToExcel.Margin = new Padding(4, 3, 4, 3);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(120, 40);
            btnExportToExcel.TabIndex = 16;
            btnExportToExcel.Text = "Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            btnExportToExcel.MouseEnter += Button_MouseEnter;
            btnExportToExcel.MouseLeave += Button_MouseLeave;
            // 
            // lblPlanName
            // 
            lblPlanName.AutoSize = true;
            lblPlanName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlanName.ForeColor = Color.White;
            lblPlanName.Location = new Point(30, 30);
            lblPlanName.Margin = new Padding(4, 0, 4, 0);
            lblPlanName.Name = "lblPlanName";
            lblPlanName.Size = new Size(126, 29);
            lblPlanName.TabIndex = 0;
            lblPlanName.Text = "PlanName";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft Sans Serif", 18F);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(30, 100);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(135, 29);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Microsoft Sans Serif", 18F);
            lblStartDate.ForeColor = Color.White;
            lblStartDate.Location = new Point(30, 170);
            lblStartDate.Margin = new Padding(4, 0, 4, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(112, 29);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "StartDate";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Microsoft Sans Serif", 18F);
            lblEndDate.ForeColor = Color.White;
            lblEndDate.Location = new Point(30, 240);
            lblEndDate.Margin = new Padding(4, 0, 4, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(106, 29);
            lblEndDate.TabIndex = 6;
            lblEndDate.Text = "EndDate";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 18F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(30, 310);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(79, 29);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // FormToPerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 78);
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblPlanName);
            Controls.Add(txtPlanName);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblStartDate);
            Controls.Add(datePickerStart);
            Controls.Add(lblEndDate);
            Controls.Add(datePickerEnd);
            Controls.Add(lblStatus);
            Controls.Add(comboBoxStatus);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridPerformancePlans);
            Controls.Add(btnExportToExcel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormToPerformance";
            Text = "계획 및 실적";
            ((ISupportInitialize)dataGridPerformancePlans).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
