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
        private bool type = true;
        private bool url = true;
        private bool start = true;
        private bool end = true;

        public ModifyAppointment(Appointment appointment)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            saveBtn.Enabled = false;

            // fill all fields
            idBox.Text = Convert.ToString(appointment.appointmentId);
            userIdBox.Text = Convert.ToString(appointment.userId);
            titleBox.Text = appointment.title;
            descriptionBox.Text = appointment.description;
            locationBox.Text = appointment.location;
            contactBox.Text = appointment.contact;
            typeBox.Text = appointment.type;
            urlBox.Text = appointment.url;
            startBox.Text = appointment.start;
            endBox.Text = appointment.end;
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

        private void typeBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeBox.Text))
            {
                typeBox.BackColor = Color.Salmon;
                type = false;
            }
            else
            {
                typeBox.BackColor = Color.White;
                type = true;
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

        private void startBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(startBox.Text))
            {
                startBox.BackColor = Color.Salmon;
                start = false;
            }
            else
            {
                startBox.BackColor = Color.White;
                start = true;
            }
            saveBtn.Enabled = canSave();
        }

        private void endBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(endBox.Text))
            {
                endBox.BackColor = Color.Salmon;
                end = false;
            }
            else
            {
                endBox.BackColor = Color.White;
                end = true;
            }
            saveBtn.Enabled = canSave();
        }

        private bool canSave()
        {
            if (title && description && location && contact && type && url && start && end)
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
    }
}
