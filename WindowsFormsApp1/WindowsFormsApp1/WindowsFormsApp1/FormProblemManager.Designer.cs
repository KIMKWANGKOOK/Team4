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
            this.txtProblemName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.datePickerReported = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveProblem = new System.Windows.Forms.Button();
            this.btnUpdateProblem = new System.Windows.Forms.Button();
            this.btnDeleteProblem = new System.Windows.Forms.Button();
            this.dataGridProblems = new System.Windows.Forms.DataGridView();
            this.lblProblemName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblReportedDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProblems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProblemName
            // 
            this.txtProblemName.Location = new System.Drawing.Point(160, 35);
            this.txtProblemName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProblemName.Name = "txtProblemName";
            this.txtProblemName.Size = new System.Drawing.Size(265, 25);
            this.txtProblemName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(160, 81);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 25);
            this.txtDescription.TabIndex = 1;
            // 
            // datePickerReported
            // 
            this.datePickerReported.Location = new System.Drawing.Point(160, 127);
            this.datePickerReported.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePickerReported.Name = "datePickerReported";
            this.datePickerReported.Size = new System.Drawing.Size(265, 25);
            this.datePickerReported.TabIndex = 2;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "열림",
            "닫힘",
            "보류"});
            this.comboBoxStatus.Location = new System.Drawing.Point(160, 173);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(265, 23);
            this.comboBoxStatus.TabIndex = 3;
            // 
            // btnSaveProblem
            // 
            this.btnSaveProblem.BackColor = System.Drawing.Color.White;
            this.btnSaveProblem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProblem.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProblem.Location = new System.Drawing.Point(453, 35);
            this.btnSaveProblem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveProblem.Name = "btnSaveProblem";
            this.btnSaveProblem.Size = new System.Drawing.Size(133, 27);
            this.btnSaveProblem.TabIndex = 4;
            this.btnSaveProblem.Text = "저장";
            this.btnSaveProblem.UseVisualStyleBackColor = false;
            this.btnSaveProblem.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSaveProblem.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSaveProblem.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnUpdateProblem
            // 
            this.btnUpdateProblem.BackColor = System.Drawing.Color.White;
            this.btnUpdateProblem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProblem.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProblem.Location = new System.Drawing.Point(453, 81);
            this.btnUpdateProblem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateProblem.Name = "btnUpdateProblem";
            this.btnUpdateProblem.Size = new System.Drawing.Size(133, 27);
            this.btnUpdateProblem.TabIndex = 5;
            this.btnUpdateProblem.Text = "수정";
            this.btnUpdateProblem.UseVisualStyleBackColor = false;
            this.btnUpdateProblem.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdateProblem.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnUpdateProblem.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnDeleteProblem
            // 
            this.btnDeleteProblem.BackColor = System.Drawing.Color.White;
            this.btnDeleteProblem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProblem.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProblem.Location = new System.Drawing.Point(453, 127);
            this.btnDeleteProblem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteProblem.Name = "btnDeleteProblem";
            this.btnDeleteProblem.Size = new System.Drawing.Size(133, 27);
            this.btnDeleteProblem.TabIndex = 6;
            this.btnDeleteProblem.Text = "삭제";
            this.btnDeleteProblem.UseVisualStyleBackColor = false;
            this.btnDeleteProblem.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDeleteProblem.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDeleteProblem.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // dataGridProblems
            // 
            this.dataGridProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProblems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.dataGridProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProblems.GridColor = System.Drawing.Color.White;
            this.dataGridProblems.Location = new System.Drawing.Point(27, 265);
            this.dataGridProblems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridProblems.Name = "dataGridProblems";
            this.dataGridProblems.RowHeadersWidth = 51;
            this.dataGridProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProblems.Size = new System.Drawing.Size(1133, 462);
            this.dataGridProblems.TabIndex = 14;
            // 
            // lblProblemName
            // 
            this.lblProblemName.AutoSize = true;
            this.lblProblemName.ForeColor = System.Drawing.Color.White;
            this.lblProblemName.Location = new System.Drawing.Point(27, 40);
            this.lblProblemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProblemName.Name = "lblProblemName";
            this.lblProblemName.Size = new System.Drawing.Size(52, 15);
            this.lblProblemName.TabIndex = 7;
            this.lblProblemName.Text = "문제명";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(27, 87);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(37, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "설명";
            // 
            // lblReportedDate
            // 
            this.lblReportedDate.AutoSize = true;
            this.lblReportedDate.ForeColor = System.Drawing.Color.White;
            this.lblReportedDate.Location = new System.Drawing.Point(27, 133);
            this.lblReportedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportedDate.Name = "lblReportedDate";
            this.lblReportedDate.Size = new System.Drawing.Size(52, 15);
            this.lblReportedDate.TabIndex = 9;
            this.lblReportedDate.Text = "보고일";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(27, 179);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 15);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "상태";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(160, 219);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 25);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(453, 219);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 27);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(27, 225);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(37, 15);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "검색";
            // 
            // FormProblemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1200, 808);
            this.Controls.Add(this.txtProblemName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.datePickerReported);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.btnSaveProblem);
            this.Controls.Add(this.btnUpdateProblem);
            this.Controls.Add(this.btnDeleteProblem);
            this.Controls.Add(this.lblProblemName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblReportedDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridProblems);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormProblemManager";
            this.Text = "문제 관리";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProblems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
