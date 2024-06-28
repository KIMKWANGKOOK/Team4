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
        private PictureBox pictureBoxWorkStatus;
        private PictureBox pictureBoxProgress; // 작업 진행 중을 나타내는 PictureBox
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
            pictureBoxWorkStatus = new PictureBox();
            pictureBoxProgress = new PictureBox();
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
            ((ISupportInitialize)pictureBoxWorkStatus).BeginInit();
            ((ISupportInitialize)pictureBoxProgress).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTaskName
            // 
            comboBoxTaskName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaskName.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBoxTaskName.FormattingEnabled = true;
            comboBoxTaskName.Location = new Point(154, 17);
            comboBoxTaskName.Margin = new Padding(4);
            comboBoxTaskName.Name = "comboBoxTaskName";
            comboBoxTaskName.Size = new Size(200, 23);
            comboBoxTaskName.TabIndex = 0;
            comboBoxTaskName.SelectedIndexChanged += ComboBoxTaskName_SelectedIndexChanged;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtContent.Location = new Point(154, 82);
            txtContent.Margin = new Padding(4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(200, 23);
            txtContent.TabIndex = 1;
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            datePicker.Location = new Point(154, 144);
            datePicker.Margin = new Padding(4);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 2;
            // 
            // txtWriter
            // 
            txtWriter.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtWriter.Location = new Point(154, 198);
            txtWriter.Margin = new Padding(4);
            txtWriter.Name = "txtWriter";
            txtWriter.Size = new Size(200, 23);
            txtWriter.TabIndex = 3;
            // 
            // txtWorker
            // 
            txtWorker.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtWorker.Location = new Point(154, 255);
            txtWorker.Margin = new Padding(4);
            txtWorker.Name = "txtWorker";
            txtWorker.Size = new Size(200, 23);
            txtWorker.TabIndex = 8;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBoxPriority.Location = new Point(593, 92);
            comboBoxPriority.Margin = new Padding(4);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(200, 23);
            comboBoxPriority.TabIndex = 4;
            // 
            // comboBoxQuantity
            // 
            comboBoxQuantity.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            comboBoxQuantity.Location = new Point(593, 16);
            comboBoxQuantity.Margin = new Padding(4);
            comboBoxQuantity.Name = "comboBoxQuantity";
            comboBoxQuantity.Size = new Size(200, 29);
            comboBoxQuantity.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(17, 17, 17);
            btnSave.Location = new Point(378, 17);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 32);
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
            btnUpdate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(17, 17, 17);
            btnUpdate.Location = new Point(378, 82);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 32);
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
            btnDelete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(17, 17, 17);
            btnDelete.Location = new Point(378, 145);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 32);
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
            btnExportToExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportToExcel.ForeColor = Color.FromArgb(17, 17, 17);
            btnExportToExcel.Location = new Point(1087, 16);
            btnExportToExcel.Margin = new Padding(4);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(120, 45);
            btnExportToExcel.TabIndex = 10;
            btnExportToExcel.Text = "Send in Excel";
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
            btnViewDetails.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = Color.FromArgb(17, 17, 17);
            btnViewDetails.Location = new Point(816, 23);
            btnViewDetails.Margin = new Padding(4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(80, 32);
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
            btnStartWork.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartWork.ForeColor = Color.FromArgb(17, 17, 17);
            btnStartWork.Location = new Point(378, 198);
            btnStartWork.Margin = new Padding(4);
            btnStartWork.Name = "btnStartWork";
            btnStartWork.Size = new Size(100, 32);
            btnStartWork.TabIndex = 21;
            btnStartWork.Text = "Work Start";
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
            btnStopWork.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStopWork.ForeColor = Color.FromArgb(17, 17, 17);
            btnStopWork.Location = new Point(378, 256);
            btnStopWork.Margin = new Padding(4);
            btnStopWork.Name = "btnStopWork";
            btnStopWork.Size = new Size(100, 32);
            btnStopWork.TabIndex = 22;
            btnStopWork.Text = "Work Stop";
            btnStopWork.UseVisualStyleBackColor = false;
            btnStopWork.Click += btnStopWork_Click;
            btnStopWork.MouseEnter += Button_MouseEnter;
            btnStopWork.MouseLeave += Button_MouseLeave;
            // 
            // btnUpdateTodayWorkList
            // 
            btnUpdateTodayWorkList.BackColor = Color.White;
            btnUpdateTodayWorkList.FlatAppearance.BorderColor = Color.White;
            btnUpdateTodayWorkList.FlatStyle = FlatStyle.Flat;
            btnUpdateTodayWorkList.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnUpdateTodayWorkList.ForeColor = Color.Black;
            btnUpdateTodayWorkList.Location = new Point(1774, 21);
            btnUpdateTodayWorkList.Margin = new Padding(4);
            btnUpdateTodayWorkList.Name = "btnUpdateTodayWorkList";
            btnUpdateTodayWorkList.Size = new Size(120, 45);
            btnUpdateTodayWorkList.TabIndex = 23;
            btnUpdateTodayWorkList.Text = "Update";
            btnUpdateTodayWorkList.UseVisualStyleBackColor = false;
            btnUpdateTodayWorkList.Click += btnUpdateTodayWorkList_Click;
            btnUpdateTodayWorkList.MouseEnter += Button_MouseEnter;
            btnUpdateTodayWorkList.MouseLeave += Button_MouseLeave;
            // 
            // dataGridWorkInstructions
            // 
            dataGridWorkInstructions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridWorkInstructions.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridWorkInstructions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWorkInstructions.GridColor = Color.White;
            dataGridWorkInstructions.Location = new Point(23, 390);
            dataGridWorkInstructions.Margin = new Padding(4);
            dataGridWorkInstructions.Name = "dataGridWorkInstructions";
            dataGridWorkInstructions.RowHeadersWidth = 51;
            dataGridWorkInstructions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridWorkInstructions.Size = new Size(992, 200);
            dataGridWorkInstructions.TabIndex = 12;
            dataGridWorkInstructions.SelectionChanged += dataGridWorkInstructions_SelectionChanged;
            // 
            // dataGridTodayWorkList
            // 
            dataGridTodayWorkList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTodayWorkList.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridTodayWorkList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTodayWorkList.GridColor = Color.White;
            dataGridTodayWorkList.Location = new Point(23, 637);
            dataGridTodayWorkList.Margin = new Padding(4);
            dataGridTodayWorkList.Name = "dataGridTodayWorkList";
            dataGridTodayWorkList.RowHeadersWidth = 51;
            dataGridTodayWorkList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTodayWorkList.Size = new Size(992, 200);
            dataGridTodayWorkList.TabIndex = 23;
            // 
            // dataGridWorkForToday
            // 
            dataGridWorkForToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridWorkForToday.BackgroundColor = Color.FromArgb(46, 59, 78);
            dataGridWorkForToday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridWorkForToday.GridColor = Color.White;
            dataGridWorkForToday.Location = new Point(1294, 91);
            dataGridWorkForToday.Margin = new Padding(4);
            dataGridWorkForToday.Name = "dataGridWorkForToday";
            dataGridWorkForToday.RowHeadersWidth = 51;
            dataGridWorkForToday.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridWorkForToday.Size = new Size(600, 254);
            dataGridWorkForToday.TabIndex = 26;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaskName.ForeColor = Color.White;
            lblTaskName.Location = new Point(20, 30);
            lblTaskName.Margin = new Padding(4, 0, 4, 0);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(93, 20);
            lblTaskName.TabIndex = 13;
            lblTaskName.Text = "Code Name";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContent.ForeColor = Color.White;
            lblContent.Location = new Point(20, 92);
            lblContent.Margin = new Padding(4, 0, 4, 0);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(99, 20);
            lblContent.TabIndex = 14;
            lblContent.Text = "Work Details";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(20, 151);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 20);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date";
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWriter.ForeColor = Color.White;
            lblWriter.Location = new Point(20, 203);
            lblWriter.Margin = new Padding(4, 0, 4, 0);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new Size(51, 20);
            lblWriter.TabIndex = 16;
            lblWriter.Text = "Writer";
            // 
            // lblWorker
            // 
            lblWorker.AutoSize = true;
            lblWorker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorker.ForeColor = Color.White;
            lblWorker.Location = new Point(20, 261);
            lblWorker.Margin = new Padding(4, 0, 4, 0);
            lblWorker.Name = "lblWorker";
            lblWorker.Size = new Size(60, 20);
            lblWorker.TabIndex = 18;
            lblWorker.Text = "Worker";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriority.ForeColor = Color.White;
            lblPriority.Location = new Point(513, 90);
            lblPriority.Margin = new Padding(4, 0, 4, 0);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(56, 20);
            lblPriority.TabIndex = 17;
            lblPriority.Text = "Priority";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(513, 30);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 19;
            lblQuantity.Text = "Quantity";
            // 
            // lblTodayWorkList
            // 
            lblTodayWorkList.AutoSize = true;
            lblTodayWorkList.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTodayWorkList.ForeColor = Color.White;
            lblTodayWorkList.Location = new Point(23, 603);
            lblTodayWorkList.Margin = new Padding(4, 0, 4, 0);
            lblTodayWorkList.Name = "lblTodayWorkList";
            lblTodayWorkList.Size = new Size(259, 21);
            lblTodayWorkList.TabIndex = 24;
            lblTodayWorkList.Text = "List of tasks completed for today";
            // 
            // lblWorkTable
            // 
            lblWorkTable.AutoSize = true;
            lblWorkTable.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblWorkTable.ForeColor = Color.White;
            lblWorkTable.Location = new Point(23, 356);
            lblWorkTable.Margin = new Padding(4, 0, 4, 0);
            lblWorkTable.Name = "lblWorkTable";
            lblWorkTable.Size = new Size(95, 21);
            lblWorkTable.TabIndex = 25;
            lblWorkTable.Text = "Work Table";
            // 
            // lblWorkForToday
            // 
            lblWorkForToday.AutoSize = true;
            lblWorkForToday.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblWorkForToday.ForeColor = Color.White;
            lblWorkForToday.Location = new Point(1504, 25);
            lblWorkForToday.Margin = new Padding(4, 0, 4, 0);
            lblWorkForToday.Name = "lblWorkForToday";
            lblWorkForToday.Size = new Size(181, 30);
            lblWorkForToday.TabIndex = 27;
            lblWorkForToday.Text = "Today's Work List";
            // 
            // pictureBoxWorkStatus
            // 
            pictureBoxWorkStatus.Location = new Point(1087, 637);
            pictureBoxWorkStatus.Name = "pictureBoxWorkStatus";
            pictureBoxWorkStatus.Size = new Size(807, 200);
            pictureBoxWorkStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxWorkStatus.TabIndex = 28;
            pictureBoxWorkStatus.TabStop = false;
            // 
            // pictureBoxProgress
            // 
            pictureBoxProgress.Location = new Point(1694, 390);
            pictureBoxProgress.Name = "pictureBoxProgress";
            pictureBoxProgress.Size = new Size(200, 200);
            pictureBoxProgress.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProgress.TabIndex = 29;
            pictureBoxProgress.TabStop = false;
            pictureBoxProgress.Visible = false;
            // 
            // lblWorkStatus
            // 
            lblWorkStatus.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblWorkStatus.ForeColor = Color.White;
            lblWorkStatus.Location = new Point(1060, 390);
            lblWorkStatus.Margin = new Padding(4, 0, 4, 0);
            lblWorkStatus.Name = "lblWorkStatus";
            lblWorkStatus.Size = new Size(615, 200);
            lblWorkStatus.TabIndex = 30;
            lblWorkStatus.Text = "현재 작업이 대기중입니다\r\n\r\n      ※확인해주세요※";
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(513, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 32;
            label1.Text = "Plc Num";
            // 
            // bt_OpenPLC
            // 
            bt_OpenPLC.BackColor = Color.FromArgb(224, 224, 224);
            bt_OpenPLC.FlatAppearance.BorderColor = Color.White;
            bt_OpenPLC.FlatStyle = FlatStyle.Flat;
            bt_OpenPLC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_OpenPLC.ForeColor = Color.FromArgb(17, 17, 17);
            bt_OpenPLC.Location = new Point(816, 139);
            bt_OpenPLC.Margin = new Padding(4);
            bt_OpenPLC.Name = "bt_OpenPLC";
            bt_OpenPLC.Size = new Size(80, 32);
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
            bt_ClosePLC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_ClosePLC.ForeColor = Color.FromArgb(17, 17, 17);
            bt_ClosePLC.Location = new Point(816, 208);
            bt_ClosePLC.Margin = new Padding(4);
            bt_ClosePLC.Name = "bt_ClosePLC";
            bt_ClosePLC.Size = new Size(80, 32);
            bt_ClosePLC.TabIndex = 33;
            bt_ClosePLC.Text = "PLC닫기";
            bt_ClosePLC.UseVisualStyleBackColor = false;
            bt_ClosePLC.Click += bt_ClosePLC_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(513, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 32;
            label2.Text = "Connect State :";
            // 
            // lb_state
            // 
            lb_state.AutoSize = true;
            lb_state.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lb_state.ForeColor = Color.White;
            lb_state.Location = new Point(649, 191);
            lb_state.Margin = new Padding(4, 0, 4, 0);
            lb_state.Name = "lb_state";
            lb_state.Size = new Size(33, 45);
            lb_state.TabIndex = 32;
            lb_state.Text = "-";
            // 
            // combo_plcNum
            // 
            combo_plcNum.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            combo_plcNum.Location = new Point(593, 146);
            combo_plcNum.Margin = new Padding(4);
            combo_plcNum.Name = "combo_plcNum";
            combo_plcNum.Size = new Size(200, 23);
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
            Controls.Add(pictureBoxWorkStatus);
            Controls.Add(pictureBoxProgress);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "FormWorkInstruction";
            Text = "작업 지시";
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)dataGridWorkInstructions).EndInit();
            ((ISupportInitialize)dataGridTodayWorkList).EndInit();
            ((ISupportInitialize)dataGridWorkForToday).EndInit();
            ((ISupportInitialize)pictureBoxWorkStatus).EndInit();
            ((ISupportInitialize)pictureBoxProgress).EndInit();
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
