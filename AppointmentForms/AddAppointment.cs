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
    public partial class AddAppointment : Form
    {
        private bool title = false;
        private bool description = false;
        private bool location = false;
        private bool contact = false;
        private bool url = false;
        private bool start = false;
        private bool end = false;

        private BindingList<Customer> customers = Customer.allCustomers;
        private List<string> types = Appointment.types;

        public AddAppointment()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            saveBtn.Enabled = false;

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
            if (title && description && location && contact && url && start && end)
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

            this.Close();
        }
    }
}
