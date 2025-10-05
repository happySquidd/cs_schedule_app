using scheduleApp.Database;
using scheduleApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp.AppointmentForms
{
    public partial class AddAppointment : Form
    {
        private bool title = false;
        private bool description = false;
        private bool location = false;
        private bool contact = false;
        private bool url = false;

        private BindingList<Customer> customers = Customer.allCustomers;
        private List<string> types = Appointment.types;

        public AddAppointment()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            saveBtn.Enabled = false;
            startTimeBox.Format = DateTimePickerFormat.Custom;
            startTimeBox.CustomFormat = "yyyy-MM-dd  HH:mm";
            endTimeBox.Format = DateTimePickerFormat.Custom;
            endTimeBox.CustomFormat = "yyyy-MM-dd  HH:mm";

            // populate customer ids
            assignCustomerBox.BeginUpdate();

            for (int i = 0; i < customers.Count; i++)
            {
                assignCustomerBox.Items.Add($"{customers[i].customerId}  ({customers[i].customerName})");
            }
            assignCustomerBox.EndUpdate();

            // populate type fields
            typeBox.BeginUpdate();
            for (int i = 0; i < types.Count; i++)
            {
                typeBox.Items.Add(types[i].ToString());
            }
            typeBox.EndUpdate();

            // helpful time conversion label from EST to local time
            DateTime timeAm = new DateTime(2000, 01, 01, 09, 00, 00);
            DateTime timePm = new DateTime(2000, 01, 01, 17, 00, 00);
            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime localAm = TimeZoneInfo.ConvertTime(timeAm, estZone, TimeZoneInfo.Local);
            DateTime localPm = TimeZoneInfo.ConvertTime(timePm, estZone, TimeZoneInfo.Local);
            localTimeLabel.Text = $"{localAm.Hour}:00-{localPm.Hour}:00 local time";
        }

        private void assignCustomerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text))
            {
                titleBox.BackColor = Color.Salmon;
                title = false;
            }
            else
            {
                titleBox.BackColor = Color.White;
                title = true;
            }
            saveBtn.Enabled = canSave();
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionBox.Text))
            {
                descriptionBox.BackColor = Color.Salmon;
                description = false;
            }
            else
            {
                descriptionBox.BackColor = Color.White;
                description = true;
            }
            saveBtn.Enabled = canSave();
        }

        private void locationBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationBox.Text))
            {
                locationBox.BackColor = Color.Salmon;
                location = false;
            }
            else
            {
                locationBox.BackColor = Color.White;
                location = true;
            }
            saveBtn.Enabled = canSave();
        }

        private void contactBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactBox.Text))
            {
                contactBox.BackColor = Color.Salmon;
                contact = false;
            }
            else
            {
                contactBox.BackColor = Color.White;
                contact = true;
            }
            saveBtn.Enabled = canSave();
        }


        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urlBox.Text))
            {
                urlBox.BackColor = Color.Salmon;
                url = false;
            }
            else
            {
                urlBox.BackColor = Color.White;
                url = true;
            }
            saveBtn.Enabled = canSave();
        }

        private bool canSave()
        {
            if (title && description && location && contact && url)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // debug
            //Console.WriteLine("debug from add appointment: " + typeBox.Text);

            // input validation
            // -1 means nothing was selected, return to form
            if (assignCustomerBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer for this appointment");
                return;
            }
            if (typeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the type of appointment");
                return;
            }
            if (startTimeBox.Value >= endTimeBox.Value)
            {
                MessageBox.Show("The end time should be after the start time");
                return;
            }
            if (startTimeBox.Value.DayOfWeek == DayOfWeek.Saturday || startTimeBox.Value.DayOfWeek == DayOfWeek.Sunday ||
                endTimeBox.Value.DayOfWeek == DayOfWeek.Saturday || endTimeBox.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Business is not open on weekends, please adjust your time");
                return;
            }

            //validate time by comparing it to datetime hours 9am and 5pm
            DateTime am = DateTime.Parse("1/1/2000 09:00:00");
            DateTime pm = DateTime.Parse("1/1/2000 17:00:00");
            // we have to change the selected time to eastern time to ensure appointments are made within EST business hours
            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime estStart = TimeZoneInfo.ConvertTime(startTimeBox.Value, estZone);
            DateTime estEnd = TimeZoneInfo.ConvertTime(endTimeBox.Value, estZone);
            if (estStart.TimeOfDay < am.TimeOfDay || estStart.TimeOfDay >= pm.TimeOfDay || 
                estEnd.TimeOfDay < am.TimeOfDay || estEnd.TimeOfDay > pm.TimeOfDay)
            {
                MessageBox.Show("Business hours are between 9:00am. and 5:00pm. EST, \nPlease adjust your time");
                return;
            }

            // check for overlap
            if (CheckOverlap())
            {
                MessageBox.Show("There is an overlap with appointments,\nChange your time and try again");
                return;
            }

            // get customer id from the selected box
            string[] customerString = assignCustomerBox.Text.Split(' ');
            int customerId = Convert.ToInt32(customerString[0]);

            // create the appointment
            bool add = DBconnection.CreateAppointment(customerId, titleBox.Text, descriptionBox.Text, locationBox.Text, contactBox.Text, typeBox.Text, urlBox.Text, Convert.ToDateTime(startTimeBox.Text), Convert.ToDateTime(endTimeBox.Text));
            if (!add)
            {
                MessageBox.Show("There was a problem inserting into\nthe database, please check your fields");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private bool CheckOverlap()
        {
            DateTime startTime = Convert.ToDateTime(startTimeBox.Text);
            DateTime endTime = Convert.ToDateTime(endTimeBox.Text);
            Appointment.allAppointments = DBconnection.GetAppointments();
            Console.WriteLine("startTime: " + startTime.ToString());
            Console.WriteLine("endTime: " + endTime.ToString());

            foreach (Appointment appointment in Appointment.allAppointments) 
            {
                DateTime apStart = Convert.ToDateTime(appointment.start);
                DateTime apEnd = Convert.ToDateTime(appointment.end);
                Console.WriteLine("appointment start time: " + apStart.ToString());
                Console.WriteLine("appointment end time: " + apEnd.ToString());

                if (IsOverlap(startTime, apStart, endTime, apEnd))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsOverlap(DateTime startTime, DateTime apStart, DateTime endTime, DateTime apEnd)
        {
            //false = no overlap, true = overlap
            if (startTime < apStart)
            {
                // start is before appointment
                if (endTime >= apStart)
                {
                    // start is before, end is after, overlaps!
                    return true;
                }
                else
                {
                    // startTime < apStart && endTime < startTime, no overlap
                    return false;
                }
            }
            else
            {
                // startTime >= apStart
                if (startTime <= apEnd || startTime == apStart)
                {
                    // startTime >= apStart && startTime <= apEnd, overlaps!
                    return true;
                }
                else
                {
                    // startTime > apStart && startTime > apEnd, no overlap
                    return false;
                }
            }
        }
    }
}
