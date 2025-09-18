using scheduleApp.AppointmentForms;
using scheduleApp.CustomerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void modifyCustomerBtn_Click(object sender, EventArgs e)
        {
            ModifyCustomer modifyCustomer = new ModifyCustomer();
            modifyCustomer.ShowDialog();
        }

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
        }

        private void updateAppointmentBtn_Click(object sender, EventArgs e)
        {
            ModifyAppointment modifyAppointment = new ModifyAppointment();
            modifyAppointment.ShowDialog();
        }
    }
}
