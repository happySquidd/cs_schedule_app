namespace scheduleApp
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.viewDayBtn = new System.Windows.Forms.RadioButton();
            this.viewMonthBtn = new System.Windows.Forms.RadioButton();
            this.viewWeekBtn = new System.Windows.Forms.RadioButton();
            this.viewAllBtn = new System.Windows.Forms.RadioButton();
            this.calendarDgv = new System.Windows.Forms.DataGridView();
            this.exitBtn3 = new System.Windows.Forms.Button();
            this.tabAppointment = new System.Windows.Forms.TabPage();
            this.deleteAppointmentBtn = new System.Windows.Forms.Button();
            this.updateAppointmentBtn = new System.Windows.Forms.Button();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentsDgv = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBtn2 = new System.Windows.Forms.Button();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.modifyCustomerBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customersDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.customersReportBtn = new System.Windows.Forms.Button();
            this.scheduleReportBtn = new System.Windows.Forms.Button();
            this.typeReportBtn = new System.Windows.Forms.Button();
            this.typePanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.typeCountLabel = new System.Windows.Forms.Label();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.scheduleDgv = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDgv)).BeginInit();
            this.tabAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDgv)).BeginInit();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            this.tabReport.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.typePanel.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCalendar
            // 
            this.tabCalendar.Controls.Add(this.monthCalendar);
            this.tabCalendar.Controls.Add(this.viewDayBtn);
            this.tabCalendar.Controls.Add(this.viewMonthBtn);
            this.tabCalendar.Controls.Add(this.viewWeekBtn);
            this.tabCalendar.Controls.Add(this.viewAllBtn);
            this.tabCalendar.Controls.Add(this.calendarDgv);
            this.tabCalendar.Controls.Add(this.exitBtn3);
            this.tabCalendar.Location = new System.Drawing.Point(4, 25);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Size = new System.Drawing.Size(571, 422);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(175, 9);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 18;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // viewDayBtn
            // 
            this.viewDayBtn.AutoSize = true;
            this.viewDayBtn.Location = new System.Drawing.Point(374, 174);
            this.viewDayBtn.Name = "viewDayBtn";
            this.viewDayBtn.Size = new System.Drawing.Size(50, 20);
            this.viewDayBtn.TabIndex = 17;
            this.viewDayBtn.TabStop = true;
            this.viewDayBtn.Text = "Day";
            this.viewDayBtn.UseVisualStyleBackColor = true;
            this.viewDayBtn.CheckedChanged += new System.EventHandler(this.viewDayBtn_CheckedChanged);
            // 
            // viewMonthBtn
            // 
            this.viewMonthBtn.AutoSize = true;
            this.viewMonthBtn.Location = new System.Drawing.Point(240, 174);
            this.viewMonthBtn.Name = "viewMonthBtn";
            this.viewMonthBtn.Size = new System.Drawing.Size(61, 20);
            this.viewMonthBtn.TabIndex = 16;
            this.viewMonthBtn.TabStop = true;
            this.viewMonthBtn.Text = "Month";
            this.viewMonthBtn.UseVisualStyleBackColor = true;
            this.viewMonthBtn.CheckedChanged += new System.EventHandler(this.viewMonthBtn_CheckedChanged);
            // 
            // viewWeekBtn
            // 
            this.viewWeekBtn.AutoSize = true;
            this.viewWeekBtn.Location = new System.Drawing.Point(307, 174);
            this.viewWeekBtn.Name = "viewWeekBtn";
            this.viewWeekBtn.Size = new System.Drawing.Size(61, 20);
            this.viewWeekBtn.TabIndex = 15;
            this.viewWeekBtn.TabStop = true;
            this.viewWeekBtn.Text = "Week";
            this.viewWeekBtn.UseVisualStyleBackColor = true;
            this.viewWeekBtn.CheckedChanged += new System.EventHandler(this.viewWeekBtn_CheckedChanged);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.AutoSize = true;
            this.viewAllBtn.Location = new System.Drawing.Point(162, 174);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Size = new System.Drawing.Size(72, 20);
            this.viewAllBtn.TabIndex = 14;
            this.viewAllBtn.TabStop = true;
            this.viewAllBtn.Text = "View All";
            this.viewAllBtn.UseVisualStyleBackColor = true;
            this.viewAllBtn.CheckedChanged += new System.EventHandler(this.viewAllBtn_CheckedChanged);
            // 
            // calendarDgv
            // 
            this.calendarDgv.AllowUserToAddRows = false;
            this.calendarDgv.AllowUserToResizeRows = false;
            this.calendarDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.calendarDgv.EnableHeadersVisualStyles = false;
            this.calendarDgv.Location = new System.Drawing.Point(41, 211);
            this.calendarDgv.MultiSelect = false;
            this.calendarDgv.Name = "calendarDgv";
            this.calendarDgv.ReadOnly = true;
            this.calendarDgv.RowHeadersVisible = false;
            this.calendarDgv.Size = new System.Drawing.Size(491, 139);
            this.calendarDgv.TabIndex = 8;
            this.calendarDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataBindingComplete);
            // 
            // exitBtn3
            // 
            this.exitBtn3.Location = new System.Drawing.Point(455, 370);
            this.exitBtn3.Name = "exitBtn3";
            this.exitBtn3.Size = new System.Drawing.Size(77, 31);
            this.exitBtn3.TabIndex = 6;
            this.exitBtn3.Text = "Log out";
            this.exitBtn3.UseVisualStyleBackColor = true;
            this.exitBtn3.Click += new System.EventHandler(this.exit);
            // 
            // tabAppointment
            // 
            this.tabAppointment.Controls.Add(this.deleteAppointmentBtn);
            this.tabAppointment.Controls.Add(this.updateAppointmentBtn);
            this.tabAppointment.Controls.Add(this.addAppointmentBtn);
            this.tabAppointment.Controls.Add(this.label2);
            this.tabAppointment.Controls.Add(this.appointmentsDgv);
            this.tabAppointment.Controls.Add(this.exitBtn2);
            this.tabAppointment.Location = new System.Drawing.Point(4, 25);
            this.tabAppointment.Name = "tabAppointment";
            this.tabAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointment.Size = new System.Drawing.Size(571, 422);
            this.tabAppointment.TabIndex = 1;
            this.tabAppointment.Text = "Appointments";
            this.tabAppointment.UseVisualStyleBackColor = true;
            // 
            // deleteAppointmentBtn
            // 
            this.deleteAppointmentBtn.Location = new System.Drawing.Point(207, 271);
            this.deleteAppointmentBtn.Name = "deleteAppointmentBtn";
            this.deleteAppointmentBtn.Size = new System.Drawing.Size(77, 31);
            this.deleteAppointmentBtn.TabIndex = 11;
            this.deleteAppointmentBtn.Text = "Delete";
            this.deleteAppointmentBtn.UseVisualStyleBackColor = true;
            this.deleteAppointmentBtn.Click += new System.EventHandler(this.deleteAppointmentBtn_Click);
            // 
            // updateAppointmentBtn
            // 
            this.updateAppointmentBtn.Location = new System.Drawing.Point(124, 271);
            this.updateAppointmentBtn.Name = "updateAppointmentBtn";
            this.updateAppointmentBtn.Size = new System.Drawing.Size(77, 31);
            this.updateAppointmentBtn.TabIndex = 10;
            this.updateAppointmentBtn.Text = "Update";
            this.updateAppointmentBtn.UseVisualStyleBackColor = true;
            this.updateAppointmentBtn.Click += new System.EventHandler(this.updateAppointmentBtn_Click);
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Location = new System.Drawing.Point(41, 271);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(77, 31);
            this.addAppointmentBtn.TabIndex = 9;
            this.addAppointmentBtn.Text = "Add";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "My appointments";
            // 
            // appointmentsDgv
            // 
            this.appointmentsDgv.AllowUserToAddRows = false;
            this.appointmentsDgv.AllowUserToResizeRows = false;
            this.appointmentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.appointmentsDgv.EnableHeadersVisualStyles = false;
            this.appointmentsDgv.Location = new System.Drawing.Point(41, 66);
            this.appointmentsDgv.MultiSelect = false;
            this.appointmentsDgv.Name = "appointmentsDgv";
            this.appointmentsDgv.ReadOnly = true;
            this.appointmentsDgv.RowHeadersVisible = false;
            this.appointmentsDgv.Size = new System.Drawing.Size(491, 186);
            this.appointmentsDgv.TabIndex = 7;
            this.appointmentsDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataBindingComplete);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "appointmentId";
            this.Column7.HeaderText = "Id";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "title";
            this.Column8.HeaderText = "Title";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "description";
            this.Column9.HeaderText = "Description";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "url";
            this.Column10.HeaderText = "Url";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "start";
            this.Column11.HeaderText = "Start";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 130;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "end";
            this.Column12.HeaderText = "End";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 130;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "customerName";
            this.Column13.HeaderText = "Name";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "phone";
            this.Column14.HeaderText = "Phone";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // exitBtn2
            // 
            this.exitBtn2.Location = new System.Drawing.Point(455, 370);
            this.exitBtn2.Name = "exitBtn2";
            this.exitBtn2.Size = new System.Drawing.Size(77, 31);
            this.exitBtn2.TabIndex = 6;
            this.exitBtn2.Text = "Log out";
            this.exitBtn2.UseVisualStyleBackColor = true;
            this.exitBtn2.Click += new System.EventHandler(this.exit);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.exitBtn);
            this.tabCustomers.Controls.Add(this.deleteCustomerBtn);
            this.tabCustomers.Controls.Add(this.modifyCustomerBtn);
            this.tabCustomers.Controls.Add(this.addCustomerBtn);
            this.tabCustomers.Controls.Add(this.label1);
            this.tabCustomers.Controls.Add(this.customersDgv);
            this.tabCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(571, 422);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(455, 370);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(77, 31);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Log out";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exit);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(207, 271);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(77, 31);
            this.deleteCustomerBtn.TabIndex = 4;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // modifyCustomerBtn
            // 
            this.modifyCustomerBtn.Location = new System.Drawing.Point(124, 271);
            this.modifyCustomerBtn.Name = "modifyCustomerBtn";
            this.modifyCustomerBtn.Size = new System.Drawing.Size(77, 31);
            this.modifyCustomerBtn.TabIndex = 3;
            this.modifyCustomerBtn.Text = "Modify";
            this.modifyCustomerBtn.UseVisualStyleBackColor = true;
            this.modifyCustomerBtn.Click += new System.EventHandler(this.modifyCustomerBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(41, 271);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(77, 31);
            this.addCustomerBtn.TabIndex = 2;
            this.addCustomerBtn.Text = "Add";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "All customers";
            // 
            // customersDgv
            // 
            this.customersDgv.AllowUserToAddRows = false;
            this.customersDgv.AllowUserToResizeRows = false;
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.customersDgv.EnableHeadersVisualStyles = false;
            this.customersDgv.Location = new System.Drawing.Point(41, 66);
            this.customersDgv.MultiSelect = false;
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.ReadOnly = true;
            this.customersDgv.RowHeadersVisible = false;
            this.customersDgv.Size = new System.Drawing.Size(491, 186);
            this.customersDgv.TabIndex = 0;
            this.customersDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "customerName";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "address";
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "city";
            this.Column3.HeaderText = "City";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "country";
            this.Column4.HeaderText = "Country";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "phone";
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "createdDate";
            this.Column6.HeaderText = "Created";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tabCustomers);
            this.tabReport.Controls.Add(this.tabAppointment);
            this.tabReport.Controls.Add(this.tabCalendar);
            this.tabReport.Controls.Add(this.tabReports);
            this.tabReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReport.Location = new System.Drawing.Point(0, 0);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(579, 451);
            this.tabReport.TabIndex = 0;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.schedulePanel);
            this.tabReports.Controls.Add(this.customersReportBtn);
            this.tabReports.Controls.Add(this.scheduleReportBtn);
            this.tabReports.Controls.Add(this.typeReportBtn);
            this.tabReports.Controls.Add(this.typePanel);
            this.tabReports.Controls.Add(this.logoutBtn);
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(571, 422);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // customersReportBtn
            // 
            this.customersReportBtn.Location = new System.Drawing.Point(367, 22);
            this.customersReportBtn.Name = "customersReportBtn";
            this.customersReportBtn.Size = new System.Drawing.Size(164, 34);
            this.customersReportBtn.TabIndex = 10;
            this.customersReportBtn.Text = "View customers";
            this.customersReportBtn.UseVisualStyleBackColor = true;
            this.customersReportBtn.Click += new System.EventHandler(this.customersReportBtn_Click);
            // 
            // scheduleReportBtn
            // 
            this.scheduleReportBtn.Location = new System.Drawing.Point(204, 22);
            this.scheduleReportBtn.Name = "scheduleReportBtn";
            this.scheduleReportBtn.Size = new System.Drawing.Size(164, 34);
            this.scheduleReportBtn.TabIndex = 9;
            this.scheduleReportBtn.Text = "View schedule";
            this.scheduleReportBtn.UseVisualStyleBackColor = true;
            this.scheduleReportBtn.Click += new System.EventHandler(this.scheduleReportBtn_Click);
            // 
            // typeReportBtn
            // 
            this.typeReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.typeReportBtn.Location = new System.Drawing.Point(41, 22);
            this.typeReportBtn.Name = "typeReportBtn";
            this.typeReportBtn.Size = new System.Drawing.Size(164, 34);
            this.typeReportBtn.TabIndex = 8;
            this.typeReportBtn.Text = "View by type";
            this.typeReportBtn.UseVisualStyleBackColor = false;
            this.typeReportBtn.Click += new System.EventHandler(this.typeReportBtn_Click);
            // 
            // typePanel
            // 
            this.typePanel.Controls.Add(this.typeCountLabel);
            this.typePanel.Controls.Add(this.label4);
            this.typePanel.Controls.Add(this.label3);
            this.typePanel.Controls.Add(this.typeBox);
            this.typePanel.Controls.Add(this.monthBox);
            this.typePanel.Location = new System.Drawing.Point(41, 62);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(492, 281);
            this.typePanel.TabIndex = 7;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(455, 370);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(77, 31);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.exit);
            // 
            // monthBox
            // 
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(88, 85);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(121, 24);
            this.monthBox.TabIndex = 1;
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.monthBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(303, 85);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 24);
            this.typeBox.TabIndex = 2;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Month:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type:";
            // 
            // typeCountLabel
            // 
            this.typeCountLabel.AutoSize = true;
            this.typeCountLabel.Location = new System.Drawing.Point(36, 48);
            this.typeCountLabel.Name = "typeCountLabel";
            this.typeCountLabel.Size = new System.Drawing.Size(355, 16);
            this.typeCountLabel.TabIndex = 5;
            this.typeCountLabel.Text = "Number of appointments for the selected month of this type:";
            // 
            // schedulePanel
            // 
            this.schedulePanel.Controls.Add(this.scheduleDgv);
            this.schedulePanel.Location = new System.Drawing.Point(41, 62);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(492, 281);
            this.schedulePanel.TabIndex = 6;
            // 
            // scheduleDgv
            // 
            this.scheduleDgv.AllowUserToAddRows = false;
            this.scheduleDgv.AllowUserToResizeRows = false;
            this.scheduleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
            this.scheduleDgv.EnableHeadersVisualStyles = false;
            this.scheduleDgv.Location = new System.Drawing.Point(-1, 22);
            this.scheduleDgv.MultiSelect = false;
            this.scheduleDgv.Name = "scheduleDgv";
            this.scheduleDgv.ReadOnly = true;
            this.scheduleDgv.RowHeadersVisible = false;
            this.scheduleDgv.Size = new System.Drawing.Size(493, 221);
            this.scheduleDgv.TabIndex = 0;
            this.scheduleDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataBindingComplete);
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "appointmentId";
            this.Column15.FillWeight = 50F;
            this.Column15.HeaderText = "ID";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 50;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "title";
            this.Column16.FillWeight = 80F;
            this.Column16.HeaderText = "Title";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 80;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "start";
            this.Column17.FillWeight = 120F;
            this.Column17.HeaderText = "Start Time";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 120;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "end";
            this.Column18.FillWeight = 120F;
            this.Column18.HeaderText = "End Time";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 120;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "contact";
            this.Column19.HeaderText = "Contact";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "appointmentId";
            this.Column20.FillWeight = 50F;
            this.Column20.HeaderText = "Id";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 50;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "title";
            this.Column21.HeaderText = "Title";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "type";
            this.Column22.HeaderText = "Type";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "contact";
            this.Column23.HeaderText = "Contact";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.DataPropertyName = "start";
            this.Column24.FillWeight = 120F;
            this.Column24.HeaderText = "Date";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Width = 120;
            // 
            // Column25
            // 
            this.Column25.DataPropertyName = "phone";
            this.Column25.HeaderText = "Phone";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.tabReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm";
            this.Text = "User Form";
            this.tabCalendar.ResumeLayout(false);
            this.tabCalendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDgv)).EndInit();
            this.tabAppointment.ResumeLayout(false);
            this.tabAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDgv)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            this.tabReport.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.typePanel.ResumeLayout(false);
            this.typePanel.PerformLayout();
            this.schedulePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.RadioButton viewDayBtn;
        private System.Windows.Forms.RadioButton viewMonthBtn;
        private System.Windows.Forms.RadioButton viewWeekBtn;
        private System.Windows.Forms.RadioButton viewAllBtn;
        private System.Windows.Forms.DataGridView calendarDgv;
        private System.Windows.Forms.Button exitBtn3;
        private System.Windows.Forms.TabPage tabAppointment;
        private System.Windows.Forms.Button deleteAppointmentBtn;
        private System.Windows.Forms.Button updateAppointmentBtn;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView appointmentsDgv;
        private System.Windows.Forms.Button exitBtn2;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button modifyCustomerBtn;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.Button customersReportBtn;
        private System.Windows.Forms.Button scheduleReportBtn;
        private System.Windows.Forms.Button typeReportBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label typeCountLabel;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.DataGridView scheduleDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
    }
}