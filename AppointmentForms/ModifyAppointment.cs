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
        public ModifyAppointment(Appointment appointment)
        {
            InitializeComponent();
            this.MaximizeBox = false;

            // fill all fields
            idBox.Text = Convert.ToString(appointment.appointmentId);
            userIdBox.Text = Convert.ToString(appointment.userId);
            nameBox.Text = appointment.customerName;
            titleBox.Text = appointment.title;
            descriptionBox.Text = appointment.description;
            locationBox.Text = appointment.location;
            contactBox.Text = appointment.contact;
            typeBox.Text = appointment.type;
            urlBox.Text = appointment.url;
            startBox.Text = appointment.start;
            endBox.Text = appointment.end;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
