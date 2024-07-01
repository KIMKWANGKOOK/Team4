using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorkManagementSystem
{
    partial class FormWorkInstruction
    {
        private IContainer components = null;
        private ComboBox comboBoxTaskName;
        private TextBox txtContent;
        private DateTimePicker datePicker;
        private TextBox txtWriter;
        private TextBox txtWorker;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxQuantity;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExportToExcel;
        private Button btnViewDetails;
        private Button btnStartWork;
        private Button btnStopWork;
        private Button btnUpdateTodayWorkList;
        private DataGridView dataGridWorkInstructions;
        private DataGridView dataGridTodayWorkList;
        private DataGridView dataGridWorkForToday;
        private Label lblTaskName;
        private Label lblContent;
        private Label lblDate;
        private Label lblWriter;
        private Label lblWorker;
        private Label lblPriority;
        private Label lblQuantity;
        private Label lblTodayWorkList;
        private Label lblWorkTable;
        private Label lblWorkForToday;
        private Label lblWorkStatus; // 작업 상태를 나타내는 레이블
        private Timer timer;

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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            comboBoxTaskName = new ComboBox();
            txtContent = new TextBox();
            datePicker = new DateTimePicker();
            txtWriter = new TextBox();
            txtWorker = new TextBox();
            comboBoxPriority = new ComboBox();
            comboBoxQuantity = new ComboBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExportToExcel = new Button();
            btnViewDetails = new Button();
            btnStartWork = new Button();
            btnStopWork = new Button();
            btnUpdateTodayWorkList = new Button();
            dataGridWorkInstructions = new DataGridView();
            dataGridTodayWorkList = new DataGridView();
            dataGridWorkForToday = new DataGridView();
            lblTaskName = new Label();
            lblContent = new Label();
            lblDate = new Label();
            lblWriter = new Label();
            lblWorker = new Label();
            lblPriority = new Label();
            lblQuantity = new Label();
            lblTodayWorkList = new Label();
            lblWorkTable = new Label();
            lblWorkForToday = new Label();
            lblWorkStatus = new Label();
            timer = new Timer(components);
            label1 = new Label();
            bt_OpenPLC = new Button();
            bt_ClosePLC = new Button();
            label2 = new Label();
            lb_state = new Label();
            combo_plcNum = new TextBox();
            ((ISupportInitialize)dataGridWorkInstructions).BeginInit();
            ((ISupportInitialize)dataGridTodayWorkList).BeginInit();
            ((ISupportInitialize)dataGridWorkForToday).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTaskName
            // 
            comboBoxTaskName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaskName.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBoxTaskName.FormattingEnabled = true;
            comboBoxTaskName.Location = new Point(200, 20);
            comboBoxTaskName.Margin = new Padding(4);
            comboBoxTaskName.Name = "comboBoxTaskName";
            comboBoxTaskName.Size = new Size(200, 40);
            comboBoxTaskName.TabIndex = 0;
            comboBoxTaskName.SelectedIndexChanged += ComboBoxTaskName_SelectedIndexChanged;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtContent.Location = new Point(200, 90);
            txtContent.Margin = new Padding(4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(200, 39);
            txtContent.TabIndex = 1;
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            datePicker.Location = new Point(200, 170);
            datePicker.Margin = new Padding(4);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 2;
            // 
            // txtWriter
            // 
            txtWriter.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtWriter.Location = new Point(200, 240);
            txtWriter.Margin = new Padding(4);
            txtWriter.Name = "txtWriter";
            txtWriter.Size = new Size(200, 39);
            txtWriter.TabIndex = 3;
            // 
            // txtWorker
            // 
            txtWorker.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtWorker.Location = new Point(200, 310);
            txtWorker.Margin = new Padding(4);
            txtWorker.Name = "txtWorker";
            txtWorker.Size = new Size(200, 39);
            txtWorker.TabIndex = 8;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBoxPriority.Location = new Point(688, 90);
            comboBoxPriority.Margin = new Padding(4);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(200, 40);
            comboBoxPriority.TabIndex = 4;
            // 
            // comboBoxQuantity
            // 
            comboBoxQuantity.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBoxQuantity.Location = new Point(688, 21);
            comboBoxQuantity.Margin = new Padding(4);
            comboBoxQuantity.Name = "comboBoxQuantity";
            comboBoxQuantity.Size = new Size(200, 40);
            comboBoxQuantity.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(17, 17, 17);
            btnSave.Location = new Point(430, 20);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 5;
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
            btnUpdate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(17, 17, 17);
            btnUpdate.Location = new Point(430, 90);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Revise";
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
            btnDelete.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(17, 17, 17);
            btnDelete.Location = new Point(430, 160);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += Button_MouseEnter;
            btnDelete.MouseLeave += Button_MouseLeave;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.FromArgb(224, 224, 224);
            btnExportToExcel.FlatAppearance.BorderColor = Color.White;
            btnExportToExcel.FlatStyle = FlatStyle.Flat;
            btnExportToExcel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportToExcel.ForeColor = Color.FromArgb(17, 17, 17);
            btnExportToExcel.Location = new Point(910, 310);
            btnExportToExcel.Margin = new Padding(4);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(120, 40);
            btnExportToExcel.TabIndex = 10;
            btnExportToExcel.Text = "Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            btnExportToExcel.MouseEnter += Button_MouseEnter;
            btnExportToExcel.MouseLeave += Button_MouseLeave;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(224, 224, 224);
            btnViewDetails.FlatAppearance.BorderColor = Color.White;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = Color.FromArgb(17, 17, 17);
            btnViewDetails.Location = new Point(910, 20);
            btnViewDetails.Margin = new Padding(4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(120, 40);
            btnViewDetails.TabIndex = 11;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            btnViewDetails.MouseEnter += Button_MouseEnter;
            btnViewDetails.MouseLeave += Button_MouseLeave;
            // 
            // btnStartWork
            // 
            btnStartWork.BackColor = Color.FromArgb(224, 224, 224);
            btnStartWork.FlatAppearance.BorderColor = Color.White;
            btnStartWork.FlatStyle = FlatStyle.Flat;
            btnStartWork.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartWork.ForeColor = Color.FromArgb(17, 17, 17);
            btnStartWork.Location = new Point(430, 240);
            btnStartWork.Margin = new Padding(4);
            btnStartWork.Name = "btnStartWork";
            btnStartWork.Size = new Size(120, 40);
            btnStartWork.TabIndex = 21;
            btnStartWork.Text = "Start";
            btnStartWork.UseVisualStyleBackColor = false;
            btnStartWork.Click += btnStartWork_Click;
            btnStartWork.MouseEnter += Button_MouseEnter;
            btnStartWork.MouseLeave += Button_MouseLeave;
            // 
            // btnStopWork
            // 
            btnStopWork.BackColor = Color.FromArgb(224, 224, 224);
            btnStopWork.FlatAppearance.BorderColor = Color.White;
            btnStopWork.FlatStyle = FlatStyle.Flat;
            btnStopWork.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStopWork.ForeColor = Color.FromArgb(17, 17, 17);
            btnStopWork.Location = new Point(430, 310);
            btnStopWork.Margin = new Padding(4);
            btnStopWork.Name = "btnStopWork";
            btnStopWork.Size = new Size(120, 40);
            btnStopWork.TabIndex = 22;
            btnStopWork.Text = "Stop";
            btnStopWork.UseVisualStyleBackColor = false;
            btnStopWork.Click += btnStopWork_Click;
            btnStopWork.MouseEnter += Button_MouseEnter;
            btnStopWork.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdateTodayWorkList
            // 
            btnUpdateTodayWorkList.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdateTodayWorkList.FlatAppearance.BorderColor = Color.White;
            btnUpdateTodayWorkList.FlatStyle = FlatStyle.Flat;
            btnUpdateTodayWorkList.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateTodayWorkList.ForeColor = Color.FromArgb(17, 17, 17);
            btnUpdateTodayWorkList.Location = new Point(910, 90);
            btnUpdateTodayWorkList.Margin = new Padding(4);
            btnUpdateTodayWorkList.Name = "btnUpdateTodayWorkList";
            btnUpdateTodayWorkList.Size = new Size(120, 40);
            btnUpdateTodayWorkList.TabIndex = 23;
            btnUpdateTodayWorkList.Text = "Update";
            btnUpdateTodayWorkList.UseVisualStyleBackColor = false;
            btnUpdateTodayWorkList.Click += btnUpdateTodayWorkList_Click;
            btnUpdateTodayWorkList.MouseEnter += Button_MouseEnter;
            btnUpdateTodayWorkList.MouseLeave += Button_MouseLeave;
            // 
            // dataGridWorkInstructions
            // 
            dataGridWorkInstructions.AllowUserToAddRows = false;
            dataGridWorkInstructions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridWorkInstructions.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridWorkInstructions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridWorkInstructions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridWorkInstructions.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridWorkInstructions.GridColor = Color.White;
            dataGridWorkInstructions.Location = new Point(30, 450);
            dataGridWorkInstructions.Margin = new Padding(4);
            dataGridWorkInstructions.Name = "dataGridWorkInstructions";
            dataGridWorkInstructions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridWorkInstructions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridWorkInstructions.RowHeadersWidth = 51;
            dataGridWorkInstructions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridWorkInstructions.Size = new Size(1840, 200);
            dataGridWorkInstructions.TabIndex = 12;
            dataGridWorkInstructions.SelectionChanged += dataGridWorkInstructions_SelectionChanged;
            dataGridWorkInstructions.ForeColor = Color.Black;
            // 
            // dataGridTodayWorkList
            // 
            dataGridTodayWorkList.AllowUserToAddRows = false;
            dataGridTodayWorkList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTodayWorkList.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridTodayWorkList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridTodayWorkList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridTodayWorkList.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridTodayWorkList.GridColor = Color.White;
            dataGridTodayWorkList.Location = new Point(30, 700);
            dataGridTodayWorkList.Margin = new Padding(4);
            dataGridTodayWorkList.Name = "dataGridTodayWorkList";
            dataGridTodayWorkList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridTodayWorkList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridTodayWorkList.RowHeadersWidth = 51;
            dataGridTodayWorkList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTodayWorkList.Size = new Size(920, 200);
            dataGridTodayWorkList.TabIndex = 23;
            dataGridTodayWorkList.ForeColor = Color.Black;
            // 
            // dataGridWorkForToday
            // 
            dataGridWorkForToday.AllowUserToAddRows = false;
            dataGridWorkForToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridWorkForToday.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridWorkForToday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridWorkForToday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridWorkForToday.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridWorkForToday.GridColor = Color.White;
            dataGridWorkForToday.Location = new Point(950, 700);
            dataGridWorkForToday.Margin = new Padding(4);
            dataGridWorkForToday.Name = "dataGridWorkForToday";
            dataGridWorkForToday.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(46, 59, 78);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridWorkForToday.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridWorkForToday.RowHeadersWidth = 51;
            dataGridWorkForToday.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridWorkForToday.Size = new Size(920, 200);
            dataGridWorkForToday.TabIndex = 26;
            dataGridWorkForToday.ForeColor = Color.Black;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaskName.ForeColor = Color.White;
            lblTaskName.Location = new Point(30, 30);
            lblTaskName.Margin = new Padding(4, 0, 4, 0);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(143, 29);
            lblTaskName.TabIndex = 13;
            lblTaskName.Text = "Code Name";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent.ForeColor = Color.White;
            lblContent.Location = new Point(30, 100);
            lblContent.Margin = new Padding(4, 0, 4, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(149, 29);
            lblContent.TabIndex = 14;
            lblContent.Text = "Work Details";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(30, 170);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(63, 29);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date";
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWriter.ForeColor = Color.White;
            lblWriter.Location = new Point(30, 240);
            lblWriter.Margin = new Padding(4, 0, 4, 0);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new Size(77, 29);
            lblWriter.TabIndex = 16;
            lblWriter.Text = "Writer";
            // 
            // lblWorker
            // 
            lblWorker.AutoSize = true;
            lblWorker.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorker.ForeColor = Color.White;
            lblWorker.Location = new Point(30, 310);
            lblWorker.Margin = new Padding(4, 0, 4, 0);
            lblWorker.Name = "lblWorker";
            lblWorker.Size = new Size(91, 29);
            lblWorker.TabIndex = 18;
            lblWorker.Text = "Worker";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriority.ForeColor = Color.White;
            lblPriority.Location = new Point(580, 100);
            lblPriority.Margin = new Padding(4, 0, 4, 0);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(88, 29);
            lblPriority.TabIndex = 17;
            lblPriority.Text = "Priority";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(580, 30);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 29);
            lblQuantity.TabIndex = 19;
            lblQuantity.Text = "Quantity";
            // 
            // lblTodayWorkList
            // 
            lblTodayWorkList.AutoSize = true;
            lblTodayWorkList.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayWorkList.ForeColor = Color.White;
            lblTodayWorkList.Location = new Point(30, 669);
            lblTodayWorkList.Margin = new Padding(4, 0, 4, 0);
            lblTodayWorkList.Name = "lblTodayWorkList";
            lblTodayWorkList.Size = new Size(355, 29);
            lblTodayWorkList.TabIndex = 24;
            lblTodayWorkList.Text = "List of tasks completed for today";
            // 
            // lblWorkTable
            // 
            lblWorkTable.AutoSize = true;
            lblWorkTable.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorkTable.ForeColor = Color.White;
            lblWorkTable.Location = new Point(30, 417);
            lblWorkTable.Margin = new Padding(4, 0, 4, 0);
            lblWorkTable.Name = "lblWorkTable";
            lblWorkTable.Size = new Size(138, 29);
            lblWorkTable.TabIndex = 25;
            lblWorkTable.Text = "Work Table";
            // 
            // lblWorkForToday
            // 
            lblWorkForToday.AutoSize = true;
            lblWorkForToday.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorkForToday.ForeColor = Color.White;
            lblWorkForToday.Location = new Point(950, 668);
            lblWorkForToday.Margin = new Padding(4, 0, 4, 0);
            lblWorkForToday.Name = "lblWorkForToday";
            lblWorkForToday.Size = new Size(202, 29);
            lblWorkForToday.TabIndex = 27;
            lblWorkForToday.Text = "Today's Work List";
            // 
            // lblWorkStatus
            // 
            lblWorkStatus.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblWorkStatus.ForeColor = Color.White;
            lblWorkStatus.Location = new Point(1202, 79);
            lblWorkStatus.Margin = new Padding(4, 0, 4, 0);
            lblWorkStatus.Name = "lblWorkStatus";
            lblWorkStatus.Size = new Size(615, 200);
            lblWorkStatus.TabIndex = 30;
            lblWorkStatus.Text = "현재 작업이 대기중입니다\r\n\r\n      ※확인해주세요※";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(580, 170);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 29);
            label1.TabIndex = 32;
            label1.Text = "Plc Num";
            // 
            // bt_OpenPLC
            // 
            bt_OpenPLC.BackColor = Color.FromArgb(224, 224, 224);
            bt_OpenPLC.FlatAppearance.BorderColor = Color.White;
            bt_OpenPLC.FlatStyle = FlatStyle.Flat;
            bt_OpenPLC.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_OpenPLC.ForeColor = Color.FromArgb(17, 17, 17);
            bt_OpenPLC.Location = new Point(910, 164);
            bt_OpenPLC.Margin = new Padding(4);
            bt_OpenPLC.Name = "bt_OpenPLC";
            bt_OpenPLC.Size = new Size(120, 40);
            bt_OpenPLC.TabIndex = 33;
            bt_OpenPLC.Text = "PLC연결";
            bt_OpenPLC.UseVisualStyleBackColor = false;
            bt_OpenPLC.Click += bt_OpenPLC_Click;
            // 
            // bt_ClosePLC
            // 
            bt_ClosePLC.BackColor = Color.FromArgb(224, 224, 224);
            bt_ClosePLC.FlatAppearance.BorderColor = Color.White;
            bt_ClosePLC.FlatStyle = FlatStyle.Flat;
            bt_ClosePLC.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_ClosePLC.ForeColor = Color.FromArgb(17, 17, 17);
            bt_ClosePLC.Location = new Point(910, 240);
            bt_ClosePLC.Margin = new Padding(4);
            bt_ClosePLC.Name = "bt_ClosePLC";
            bt_ClosePLC.Size = new Size(120, 40);
            bt_ClosePLC.TabIndex = 33;
            bt_ClosePLC.Text = "PLC닫기";
            bt_ClosePLC.UseVisualStyleBackColor = false;
            bt_ClosePLC.Click += bt_ClosePLC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(580, 240);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 29);
            label2.TabIndex = 32;
            label2.Text = "Connect State :";
            // 
            // lb_state
            // 
            lb_state.AutoSize = true;
            lb_state.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lb_state.ForeColor = Color.White;
            lb_state.Location = new Point(750, 240);
            lb_state.Margin = new Padding(4, 0, 4, 0);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(24, 32);
            lb_state.TabIndex = 32;
            lb_state.Text = "-";
            // 
            // combo_plcNum
            // 
            combo_plcNum.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            combo_plcNum.Location = new Point(688, 164);
            combo_plcNum.Margin = new Padding(4);
            combo_plcNum.Name = "combo_plcNum";
            combo_plcNum.Size = new Size(200, 39);
            combo_plcNum.TabIndex = 8;
            // 
            // FormWorkInstruction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 78);
            ClientSize = new Size(1900, 1037);
            Controls.Add(bt_ClosePLC);
            Controls.Add(bt_OpenPLC);
            Controls.Add(lb_state);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblWorkStatus);
            Controls.Add(lblWorkForToday);
            Controls.Add(dataGridWorkForToday);
            Controls.Add(lblWorkTable);
            Controls.Add(dataGridTodayWorkList);
            Controls.Add(lblTodayWorkList);
            Controls.Add(btnUpdateTodayWorkList);
            Controls.Add(btnStopWork);
            Controls.Add(btnStartWork);
            Controls.Add(comboBoxQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(comboBoxTaskName);
            Controls.Add(txtContent);
            Controls.Add(datePicker);
            Controls.Add(txtWriter);
            Controls.Add(combo_plcNum);
            Controls.Add(txtWorker);
            Controls.Add(comboBoxPriority);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnViewDetails);
            Controls.Add(lblTaskName);
            Controls.Add(lblContent);
            Controls.Add(lblDate);
            Controls.Add(lblWriter);
            Controls.Add(lblWorker);
            Controls.Add(lblPriority);
            Controls.Add(dataGridWorkInstructions);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "FormWorkInstruction";
            Text = "작업 지시";
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)dataGridWorkInstructions).EndInit();
            ((ISupportInitialize)dataGridTodayWorkList).EndInit();
            ((ISupportInitialize)dataGridWorkForToday).EndInit();
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
        private Label label1;
        private Button bt_OpenPLC;
        private Button bt_ClosePLC;
        private Label label2;
        private Label lb_state;
        private TextBox combo_plcNum;
    }
}
