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
            customersDgv.AutoGenerateColumns = false;
            customersDgv.DataSource = Customer.allCustomers;
            customersDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = customersDgv.ColumnHeadersDefaultCellStyle.BackColor;
            

        }
        private void dataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customersDgv.ClearSelection();
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        // customer
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void modifyCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersDgv.CurrentRow == null)
            {
                MessageBox.Show("Nothing is selected");
                return;
            }
            Customer selected = customersDgv.CurrentRow.DataBoundItem as Customer;
            ModifyCustomer modifyCustomer = new ModifyCustomer(selected);
            modifyCustomer.ShowDialog();
        }

        // appointment
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
