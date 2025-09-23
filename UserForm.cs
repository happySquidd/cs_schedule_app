using scheduleApp.AppointmentForms;
using scheduleApp.CustomerForms;
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

namespace scheduleApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            
            // customers page
            customersDgv.DataSource = Customer.allCustomers;
            customersDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = customersDgv.ColumnHeadersDefaultCellStyle.BackColor;
            customersDgv.Columns["addressId"].Visible = false;
            customersDgv.Columns["createdBy"].Visible = false;
            customersDgv.Columns["lastUpdated"].Visible = false;
            customersDgv.Columns["lastUpdatedBy"].Visible = false;
            

        }
        private void dataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customersDgv.ClearSelection();
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
