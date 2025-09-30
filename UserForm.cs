using MySql.Data.MySqlClient;
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
            this.MaximizeBox = false;

            // customers page
            customersDgv.AutoGenerateColumns = false;
            customersDgv.DataSource = Customer.allCustomers;
            customersDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = customersDgv.ColumnHeadersDefaultCellStyle.BackColor;

            // appointments
            appointmentsDgv.AutoGenerateColumns = false;
            appointmentsDgv.DataSource = Appointment.allAppointments;
            appointmentsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = appointmentsDgv.ColumnHeadersDefaultCellStyle.BackColor;


            // calendar 
            calendarDgv.AutoGenerateColumns = false;
            calendarDgv.DataSource = Appointment.allAppointments;
            calendarDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            calendarDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            calendarDgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = calendarDgv.ColumnHeadersDefaultCellStyle.BackColor;
            var currentDay = DateTime.Now;
            monthCalendar.AddBoldedDate(currentDay);
            viewAllBtn.Checked = true;
        }
        private void dataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customersDgv.ClearSelection();
            appointmentsDgv.ClearSelection();
            calendarDgv.ClearSelection();
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
            if (appointmentsDgv.CurrentRow == null)
            {
                MessageBox.Show("Nothing is selected");
                return;
            }
            Appointment appointment = appointmentsDgv.CurrentRow.DataBoundItem as Appointment;
            ModifyAppointment modifyAppointment = new ModifyAppointment(appointment);
            modifyAppointment.ShowDialog();
        }

        private void viewAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar.RemoveAllBoldedDates();
            monthCalendar.UpdateBoldedDates();
            calendarDgv.DataSource = Appointment.allAppointments;
        }

        private void viewMonthBtn_CheckedChanged(object sender, EventArgs e)
        {
            Calendar.DisplayMonth(monthCalendar);
        }

        private void viewWeekBtn_CheckedChanged(object sender, EventArgs e)
        {
            Calendar.DisplayWeek(monthCalendar);
        }

        private void viewDayBtn_CheckedChanged(object sender, EventArgs e)
        {
            Calendar.DisplayDay(monthCalendar);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (viewAllBtn.Checked)
            {
                monthCalendar.RemoveAllBoldedDates();
                monthCalendar.UpdateBoldedDates();
                calendarDgv.DataSource = Appointment.allAppointments;
            }
            else if (viewMonthBtn.Checked)
            {
                calendarDgv.DataSource = Calendar.DisplayMonth(monthCalendar);
            }
            else if (viewWeekBtn.Checked)
            {
                calendarDgv.DataSource = Calendar.DisplayWeek(monthCalendar);
            }
            else // radio to display day is chosen
            {
                calendarDgv.DataSource = Calendar.DisplayDay(monthCalendar);
            }
        }

    }
}
