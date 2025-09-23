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

namespace scheduleApp.CustomerForms
{
    public partial class ModifyCustomer : Form
    {
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

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
