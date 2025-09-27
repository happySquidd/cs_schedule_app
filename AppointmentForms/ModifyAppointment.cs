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
            startTimeBox.Format = DateTimePickerFormat.Custom;
            startTimeBox.CustomFormat = "yyyy-MM-dd  HH:mm";
            endTimeBox.Format = DateTimePickerFormat.Custom;
            endTimeBox.CustomFormat = "yyyy-MM-dd  HH:mm";

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
            if (typeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type for this appointment");
                return;
            }
            this.Close();
        }
    }
}
