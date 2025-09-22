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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.modifyCustomerBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customersDgv = new System.Windows.Forms.DataGridView();
            this.tabAppointment = new System.Windows.Forms.TabPage();
            this.deleteAppointmentBtn = new System.Windows.Forms.Button();
            this.updateAppointmentBtn = new System.Windows.Forms.Button();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appointmentsDgv = new System.Windows.Forms.DataGridView();
            this.exitBtn2 = new System.Windows.Forms.Button();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.viewDayBtn = new System.Windows.Forms.RadioButton();
            this.viewMonthBtn = new System.Windows.Forms.RadioButton();
            this.viewWeekBtn = new System.Windows.Forms.RadioButton();
            this.viewAllBtn = new System.Windows.Forms.RadioButton();
            this.calendarDgv = new System.Windows.Forms.DataGridView();
            this.exitBtn3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            this.tabAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDgv)).BeginInit();
            this.tabCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCustomers);
            this.tabControl1.Controls.Add(this.tabAppointment);
            this.tabControl1.Controls.Add(this.tabCalendar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 451);
            this.tabControl1.TabIndex = 0;
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
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDgv.Location = new System.Drawing.Point(41, 66);
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.Size = new System.Drawing.Size(491, 186);
            this.customersDgv.TabIndex = 0;
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
            this.appointmentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDgv.Location = new System.Drawing.Point(41, 66);
            this.appointmentsDgv.Name = "appointmentsDgv";
            this.appointmentsDgv.Size = new System.Drawing.Size(491, 186);
            this.appointmentsDgv.TabIndex = 7;
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
            // 
            // calendarDgv
            // 
            this.calendarDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDgv.Location = new System.Drawing.Point(41, 211);
            this.calendarDgv.Name = "calendarDgv";
            this.calendarDgv.Size = new System.Drawing.Size(491, 122);
            this.calendarDgv.TabIndex = 8;
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.tabControl1.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            this.tabAppointment.ResumeLayout(false);
            this.tabAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDgv)).EndInit();
            this.tabCalendar.ResumeLayout(false);
            this.tabCalendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabAppointment;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button exitBtn2;
        private System.Windows.Forms.Button exitBtn3;
        private System.Windows.Forms.DataGridView appointmentsDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.Button deleteAppointmentBtn;
        private System.Windows.Forms.Button updateAppointmentBtn;
        private System.Windows.Forms.DataGridView calendarDgv;
        private System.Windows.Forms.RadioButton viewAllBtn;
        private System.Windows.Forms.RadioButton viewMonthBtn;
        private System.Windows.Forms.RadioButton viewWeekBtn;
        private System.Windows.Forms.RadioButton viewDayBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}