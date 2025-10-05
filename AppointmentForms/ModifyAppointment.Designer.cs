namespace scheduleApp.AppointmentForms
{
    partial class ModifyAppointment
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.customerIdBox = new System.Windows.Forms.TextBox();
            this.startTimeBox = new System.Windows.Forms.DateTimePicker();
            this.endTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.localTimeLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.overlapStartLabel = new System.Windows.Forms.Label();
            this.overlapEndLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(310, 372);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(79, 28);
            this.cancelBtn.TabIndex = 49;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(225, 372);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(79, 28);
            this.saveBtn.TabIndex = 48;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(143, 264);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(161, 20);
            this.urlBox.TabIndex = 45;
            this.urlBox.TextChanged += new System.EventHandler(this.urlBox_TextChanged);
            // 
            // contactBox
            // 
            this.contactBox.Location = new System.Drawing.Point(143, 204);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(161, 20);
            this.contactBox.TabIndex = 43;
            this.contactBox.TextChanged += new System.EventHandler(this.contactBox_TextChanged);
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(143, 174);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(161, 20);
            this.locationBox.TabIndex = 42;
            this.locationBox.TextChanged += new System.EventHandler(this.locationBox_TextChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(143, 144);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(161, 20);
            this.descriptionBox.TabIndex = 41;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(143, 114);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(161, 20);
            this.titleBox.TabIndex = 40;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(143, 54);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(61, 20);
            this.idBox.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "End time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Start time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Url:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Customer ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Contact:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Appointment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Modify appointment";
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(143, 234);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(161, 21);
            this.typeBox.TabIndex = 50;
            // 
            // customerIdBox
            // 
            this.customerIdBox.Enabled = false;
            this.customerIdBox.Location = new System.Drawing.Point(296, 54);
            this.customerIdBox.Name = "customerIdBox";
            this.customerIdBox.Size = new System.Drawing.Size(61, 20);
            this.customerIdBox.TabIndex = 51;
            // 
            // startTimeBox
            // 
            this.startTimeBox.Location = new System.Drawing.Point(143, 294);
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(161, 20);
            this.startTimeBox.TabIndex = 52;
            this.startTimeBox.ValueChanged += new System.EventHandler(this.startTimeBox_ValueChanged);
            // 
            // endTimeBox
            // 
            this.endTimeBox.Location = new System.Drawing.Point(143, 324);
            this.endTimeBox.Name = "endTimeBox";
            this.endTimeBox.Size = new System.Drawing.Size(161, 20);
            this.endTimeBox.TabIndex = 53;
            this.endTimeBox.ValueChanged += new System.EventHandler(this.endTimeBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(42, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "Note: This business is open Mon-Fri\r\n9:00-17:00 EST";
            // 
            // localTimeLabel
            // 
            this.localTimeLabel.AutoSize = true;
            this.localTimeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.localTimeLabel.Location = new System.Drawing.Point(42, 386);
            this.localTimeLabel.Name = "localTimeLabel";
            this.localTimeLabel.Size = new System.Drawing.Size(57, 13);
            this.localTimeLabel.TabIndex = 55;
            this.localTimeLabel.Text = "[local time]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(42, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Choose your local time";
            // 
            // overlapStartLabel
            // 
            this.overlapStartLabel.AutoSize = true;
            this.overlapStartLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.overlapStartLabel.Location = new System.Drawing.Point(310, 297);
            this.overlapStartLabel.Name = "overlapStartLabel";
            this.overlapStartLabel.Size = new System.Drawing.Size(44, 13);
            this.overlapStartLabel.TabIndex = 57;
            this.overlapStartLabel.Text = "Overlap";
            this.overlapStartLabel.Visible = false;
            // 
            // overlapEndLabel
            // 
            this.overlapEndLabel.AutoSize = true;
            this.overlapEndLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.overlapEndLabel.Location = new System.Drawing.Point(310, 327);
            this.overlapEndLabel.Name = "overlapEndLabel";
            this.overlapEndLabel.Size = new System.Drawing.Size(44, 13);
            this.overlapEndLabel.TabIndex = 58;
            this.overlapEndLabel.Text = "Overlap";
            this.overlapEndLabel.Visible = false;
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 419);
            this.Controls.Add(this.overlapEndLabel);
            this.Controls.Add(this.overlapStartLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.localTimeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTimeBox);
            this.Controls.Add(this.startTimeBox);
            this.Controls.Add(this.customerIdBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyAppointment";
            this.Text = "Modify Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox contactBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox customerIdBox;
        private System.Windows.Forms.DateTimePicker startTimeBox;
        private System.Windows.Forms.DateTimePicker endTimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label localTimeLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label overlapStartLabel;
        private System.Windows.Forms.Label overlapEndLabel;
    }
}