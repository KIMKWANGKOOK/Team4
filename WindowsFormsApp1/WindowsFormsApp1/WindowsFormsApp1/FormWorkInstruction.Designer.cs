using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    partial class FormWorkInstruction
    {
        private IContainer components = null;
        private TextBox txtTaskName;
        private TextBox txtContent;
        private DateTimePicker datePicker;
        private TextBox txtWriter;
        private ComboBox comboBoxPriority;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnExportToExcel;
        private Button btnViewDetails;
        private DataGridView dataGridWorkInstructions;
        private Label lblTaskName;
        private Label lblContent;
        private Label lblDate;
        private Label lblWriter;
        private Label lblPriority;
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
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dataGridWorkInstructions = new System.Windows.Forms.DataGridView();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkInstructions)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(140, 28);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(233, 21);
            this.txtTaskName.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(140, 65);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(233, 21);
            this.txtContent.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(140, 102);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(233, 21);
            this.datePicker.TabIndex = 2;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(140, 138);
            this.txtWriter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(233, 21);
            this.txtWriter.TabIndex = 3;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Items.AddRange(new object[] {
            "높음",
            "중간",
            "낮음"});
            this.comboBoxPriority.Location = new System.Drawing.Point(140, 175);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(233, 20);
            this.comboBoxPriority.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(397, 28);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 21);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(525, 65);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 21);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(525, 102);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 21);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 212);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(233, 21);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(397, 212);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 21);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.Color.White;
            this.btnExportToExcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportToExcel.Location = new System.Drawing.Point(140, 249);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(117, 21);
            this.btnExportToExcel.TabIndex = 10;
            this.btnExportToExcel.Text = "엑셀로 내보내기";
            this.btnExportToExcel.UseVisualStyleBackColor = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            this.btnExportToExcel.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnExportToExcel.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.White;
            this.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.ForeColor = System.Drawing.Color.Black;
            this.btnViewDetails.Location = new System.Drawing.Point(268, 249);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(117, 21);
            this.btnViewDetails.TabIndex = 11;
            this.btnViewDetails.Text = "상세 보기";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            this.btnViewDetails.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnViewDetails.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // dataGridWorkInstructions
            // 
            this.dataGridWorkInstructions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWorkInstructions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.dataGridWorkInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkInstructions.GridColor = System.Drawing.Color.White;
            this.dataGridWorkInstructions.Location = new System.Drawing.Point(25, 288);
            this.dataGridWorkInstructions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridWorkInstructions.Name = "dataGridWorkInstructions";
            this.dataGridWorkInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridWorkInstructions.Size = new System.Drawing.Size(992, 323);
            this.dataGridWorkInstructions.TabIndex = 12;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = System.Drawing.Color.White;
            this.lblTaskName.Location = new System.Drawing.Point(23, 32);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(57, 12);
            this.lblTaskName.TabIndex = 13;
            this.lblTaskName.Text = "작업 이름";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.ForeColor = System.Drawing.Color.White;
            this.lblContent.Location = new System.Drawing.Point(23, 69);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(57, 12);
            this.lblContent.TabIndex = 14;
            this.lblContent.Text = "작업 내용";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(23, 106);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 12);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "날짜";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.ForeColor = System.Drawing.Color.White;
            this.lblWriter.Location = new System.Drawing.Point(23, 143);
            this.lblWriter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(41, 12);
            this.lblWriter.TabIndex = 16;
            this.lblWriter.Text = "작성자";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.ForeColor = System.Drawing.Color.White;
            this.lblPriority.Location = new System.Drawing.Point(23, 180);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(53, 12);
            this.lblPriority.TabIndex = 17;
            this.lblPriority.Text = "우선순위";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(23, 217);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(29, 12);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "검색";
            // 
            // FormWorkInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1050, 646);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWriter);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridWorkInstructions);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormWorkInstruction";
            this.Text = "작업 지시";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkInstructions)).EndInit();
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

        // 이벤트 핸들러 메서드를 여기에 추가합니다.
    }
}
