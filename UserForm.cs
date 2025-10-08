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
        // lists for reports tab
        private readonly List<string> months = Appointment.months;
        private readonly List<string> types = Appointment.types;

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

            // reports
            monthBox.BeginUpdate();
            for (int i = 0; i < 12; i++)
            {
                monthBox.Items.Add(months[i]);
            }
            monthBox.EndUpdate();
            typeBox.BeginUpdate();
            for (int i = 0; i < types.Count; i++)
            {
                typeBox.Items.Add(types[i]);
            }
            typeBox.EndUpdate();
            
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
            if (addCustomer.ShowDialog() == DialogResult.OK) 
            {
                UpdateCustomersDgv();
            }
            ;
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
            if (modifyCustomer.ShowDialog() == DialogResult.OK)
            {
                UpdateCustomersDgv();
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersDgv.CurrentRow == null)
            {
                MessageBox.Show("Nothing is selected");
                return;
            }
            var confirm = MessageBox.Show("Are you sure you want to delete this customer?\nThis will delete any related appointments", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                return;
            }

            Customer selected = customersDgv.CurrentRow.DataBoundItem as Customer;
            int customerId = selected.customerId;
            if (!DBconnection.DeleteCustomer(customerId)) {
                MessageBox.Show("Something went wrong please try agian.");
                return;
            } 
            else
            {
                UpdateCustomersDgv();
                UpdateAppointmentsDgv();
            }
        }

        // appointment tab
        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment();
            if (addAppointment.ShowDialog() == DialogResult.OK)
            {
                UpdateAppointmentsDgv();
            }
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
            if (modifyAppointment.ShowDialog() == DialogResult.OK)
            {
                UpdateAppointmentsDgv();
            }
            
        }

        private void deleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (appointmentsDgv.CurrentRow == null)
            {
                MessageBox.Show("Nothing is selected");
                return;
            }
            Appointment appointment = appointmentsDgv.CurrentRow.DataBoundItem as Appointment;

            var confirm = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                return;
            }

            // delete from database and update tables
            if (!DBconnection.DeleteAppointment(appointment.appointmentId))
            {
                MessageBox.Show("There was an error deleting the appointment\nPlease try again.");
                return;
            }
            else
            {
                UpdateAppointmentsDgv();
            }
            
        }

        // calendar tab
        private void viewAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar.RemoveAllBoldedDates();
            monthCalendar.UpdateBoldedDates();
            calendarDgv.DataSource = Appointment.allAppointments;
        }

        private void viewMonthBtn_CheckedChanged(object sender, EventArgs e)
        {
            calendarDgv.DataSource = Calendar.DisplayMonth(monthCalendar);
        }

        private void viewWeekBtn_CheckedChanged(object sender, EventArgs e)
        {
            calendarDgv.DataSource = Calendar.DisplayWeek(monthCalendar);
        }

        private void viewDayBtn_CheckedChanged(object sender, EventArgs e)
        {
            calendarDgv.DataSource = Calendar.DisplayDay(monthCalendar);
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

        private void UpdateAppointmentsDgv()
        {
            Appointment.allAppointments = DBconnection.GetAppointments();
            appointmentsDgv.DataSource = Appointment.allAppointments;
            calendarDgv.DataSource = Appointment.allAppointments;
        }
        private void UpdateCustomersDgv()
        {
            Customer.allCustomers = DBconnection.getCustomers();
            customersDgv.DataSource = Customer.allCustomers;
        }

        // reports tab
        // -> report by type of appointment tab
        private void typeReportBtn_Click(object sender, EventArgs e)
        {
            typePanel.BringToFront();
            typeReportBtn.BackColor = Color.FromArgb(224, 238, 249);
            scheduleReportBtn.BackColor = Color.Transparent;
            customersReportBtn.BackColor = Color.Transparent;
        }

        private void scheduleReportBtn_Click(object sender, EventArgs e)
        {

            typeReportBtn.BackColor = Color.Transparent;
            scheduleReportBtn.BackColor = Color.FromArgb(224, 238, 249);
            customersReportBtn.BackColor = Color.Transparent;
        }

        private void customersReportBtn_Click(object sender, EventArgs e)
        {

            typeReportBtn.BackColor = Color.Transparent;
            scheduleReportBtn.BackColor = Color.Transparent;
            customersReportBtn.BackColor = Color.FromArgb(224, 238, 249);
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeCountLabel.Text = Reports.GetMonthReport(monthBox.SelectedIndex, typeBox.Text);
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeCountLabel.Text = Reports.GetMonthReport(monthBox.SelectedIndex, typeBox.Text);
        }
    }
}
