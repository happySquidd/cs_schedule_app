using scheduleApp.Database;
using scheduleApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleApp.CustomerForms
{
    public partial class ModifyCustomer : Form
    {

        bool name = true;
        bool address = true;
        bool address2 = false;
        bool city = true;
        bool country = true;
        bool postal = true;
        bool phone = true;

        public ModifyCustomer(Customer customer)
        {
            InitializeComponent();
            this.MaximizeBox = false;

            idBox.Text = Convert.ToString(customer.customerId);
            nameBox.Text = customer.customerName;
            addressBox.Text = customer.address;
            address2Box.Text = customer.address2;
            cityBox.Text = customer.city;
            countryBox.Text = customer.country;
            postalBox.Text = customer.postalCode;
            phoneBox.Text = customer.phone;
            saveBtn.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                nameBox.BackColor = Color.Salmon;
                saveBtn.Enabled = false;
                name = false;
            }
            else
            {
                name = true;
                nameBox.BackColor = Color.White;
                saveBtn.Enabled = canSave();
            }
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressBox.Text))
            {
                addressBox.BackColor = Color.Salmon;
                saveBtn.Enabled = false;
                address = false;
            }
            else
            {
                address = true;
                addressBox.BackColor = Color.White;
                saveBtn.Enabled = canSave();
            }
        }

        private void address2Box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address2Box.Text))
            {
                address2Box.BackColor = Color.Salmon;
                saveBtn.Enabled = false;
                address2 = false;
            }
            else
            {
                address2 = true;
                address2Box.BackColor = Color.White;
                saveBtn.Enabled = canSave();
            }
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityBox.Text))
            {
                cityBox.BackColor = Color.Salmon;
                saveBtn.Enabled = false;
                city = false;
            }
            else
            {
                city = true;
                cityBox.BackColor = Color.White;
                saveBtn.Enabled = canSave();
            }
        }

        private void countryBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(countryBox.Text))
            {
                countryBox.BackColor = Color.Salmon;
                saveBtn.Enabled = false;
                country = false;
            }
            else
            {
                country = true;
                countryBox.BackColor = Color.White;
                saveBtn.Enabled = canSave();
            }
        }

        private void postalBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(postalBox.Text))
            {
                postalBox.BackColor = Color.Salmon;
                saveBtn.Enabled = false;
                postal = false;
            }
            else
            {
                postal = true;
                postalBox.BackColor = Color.White;
                saveBtn.Enabled = canSave();
            }
        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneBox.Text) || !Regex.IsMatch(phoneBox.Text, @"^\d{3}-\d{3}-\d{4}$"))
            {
                phoneBox.BackColor = Color.Salmon;
                saveBtn.Enabled = false;
                phone = false;
            }
            else
            {
                phone = true;
                phoneBox.BackColor = Color.White;
                saveBtn.Enabled = canSave();
            }
        }

        private bool canSave()
        {
            if (name && address && address2 && city && country && postal && phone)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (DBconnection.UpdateCustomer(Convert.ToInt32(idBox.Text), countryBox.Text, cityBox.Text, addressBox.Text, address2Box.Text, postalBox.Text, phoneBox.Text, nameBox.Text))
            {
                Console.WriteLine("update customer success");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Something went wrong updating customer,\nPlease check your boxes and try again.");
                return;
            }
            this.Close();
        }
    }
}
