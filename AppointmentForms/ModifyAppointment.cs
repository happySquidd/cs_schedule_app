using scheduleApp.Database;
using scheduleApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp.AppointmentForms
{
    public partial class ModifyAppointment : Form
    {
        private bool title = true;
        private bool description = true;
        private bool location = true;
        private bool contact = true;
        private bool url = true;
        private bool timeChanged = false;

        public ModifyAppointment(Appointment appointment)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            saveBtn.Enabled = false;

            // fill all fields
            idBox.Text = Convert.ToString(appointment.appointmentId);
            customerIdBox.Text = Convert.ToString(appointment.customerId);
            titleBox.Text = appointment.title;
            descriptionBox.Text = appointment.description;
            locationBox.Text = appointment.location;
            contactBox.Text = appointment.contact;
            urlBox.Text = appointment.url;

            startTimeBox.Value = Convert.ToDateTime(appointment.start);
            endTimeBox.Value = Convert.ToDateTime(appointment.end);
            startTimeBox.Format = DateTimePickerFormat.Custom;
            startTimeBox.CustomFormat = "yyyy/MM/dd  HH:mm";
            endTimeBox.Format = DateTimePickerFormat.Custom;
            endTimeBox.CustomFormat = "yyyy/MM/dd  HH:mm";

            // fill type box
            typeBox.BeginUpdate();
            for (int i = 0; i < Appointment.types.Count; i++)
            {
                typeBox.Items.Add(Appointment.types[i].ToString());
            }
            if (!Appointment.types.Contains(appointment.type))
            {
                typeBox.Items.Add(appointment.type);
            }
            typeBox.SelectedItem = appointment.type;

            typeBox.EndUpdate();

            // helpful time conversion label from EST to local time
            DateTime timeAm = new DateTime(2000, 01, 01, 09, 00, 00);
            DateTime timePm = new DateTime(2000, 01, 01, 17, 00, 00);
            TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime localAm = TimeZoneInfo.ConvertTime(timeAm, estZone, TimeZoneInfo.Local);
            DateTime localPm = TimeZoneInfo.ConvertTime(timePm, estZone, TimeZoneInfo.Local);
            localTimeLabel.Text = $"{localAm.Hour}:00-{localPm.Hour}:00 local time";
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
        private void startTimeBox_ValueChanged(object sender, EventArgs e)
        {
            // change bool value to then validate new times
            timeChanged = true;
        }

        private void endTimeBox_ValueChanged(object sender, EventArgs e)
        {
            timeChanged = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // -1 means nothing was selected, return to form
            if (typeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type for this appointment");
                return;
            }

            // validate time only if the user changed it
            if (timeChanged)
            {
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
            }

            // get appointment id
            int appId = Convert.ToInt32(idBox.Text);
            // pass the data to update row
            bool modify = DBconnection.UpdateAppointment(appId, titleBox.Text, descriptionBox.Text, locationBox.Text, contactBox.Text, typeBox.Text, urlBox.Text, startTimeBox.Value, endTimeBox.Value);
            if (!modify)
            {
                MessageBox.Show("There was an error updating this appointment,\nPlease check your boxes and try again");
                return;
            }
            else
            {
                // TODO: check for time overlap
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
    }
}
