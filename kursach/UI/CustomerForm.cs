using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confectionery.Models;
using Confectionery.Core;

namespace Confectionery.UI
{
    partial class CustomerForm : Form
    {
        private Customer _customer;
        public CustomerForm(Customer customer = null)
        {
            InitializeComponent();
            if (customer == null)
            {
                return;
            }
            _customer = customer;
            firstNameInput.Text = customer.FirstName;
            lastNameInput.Text = customer.LastName;
            middleNameInput.Text = customer.MiddleName;
            emailInput.Text = customer.Email;
        }

        public event EventHandler<CustomerEventArgs> Submit;

        private void submitBtn_Click(object sender, EventArgs e)
        {
            CustomerEventArgs args;
            if (_customer == null)
            {
                args = new CustomerEventArgs(CustomerEventType.Create, firstNameInput.Text,
                    lastNameInput.Text, middleNameInput.Text, emailInput.Text);
            }
            else
            {
                args = new CustomerEventArgs(CustomerEventType.Create, _customer.ID,
                    firstNameInput.Text, lastNameInput.Text,
                    middleNameInput.Text, emailInput.Text);
            }
            Submit?.Invoke(this, args);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
