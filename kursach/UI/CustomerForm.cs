using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Confectionery.Models;
using Confectionery.Core;

namespace Confectionery.UI
{
    partial class CustomerForm : Form
    {
        private readonly Regex _nameRegex = new Regex(@"^[А-Я]{1}[а-я]*([-]{1}[А-Я]{1}[а-я]*)?$");
        private readonly Regex _emailRegex =new Regex(@"^(?:(?:(?:(?:[a-zA-Z]|\d|[!#$%&'*+\-/=?^_`{|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(?:\.([a-zA-Z]|\d|[!#$%&'*+\-/=?^_`{|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|(?:(?:\x22)(?:(?:(?:(?:\x20|\x09)*(?:\x0D\x0A))?(?:\x20|\x09)+)?(?:(?:[\x01-\x08\x0B\x0C\x0E-\x1F\x7F]|\x21|[\x23-\x5B]|[\x5D-\x7E]|[\x00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(?:(?:[\x01-\x09\x0B\x0C\x0D-\x7F]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(?:(?:(?:\x20|\x09)*(?:\x0D\x0A))?(\x20|\x09)+)?(?:\x22))))@(?:(?:(?:[a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(?:(?:[a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])(?:[a-zA-Z]|\d|-|\.|~|[\x00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*(?:[a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(?:(?:[a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(?:(?:[a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])(?:[a-zA-Z]|\d|-|\.|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*(?:[a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$");

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
            if (!_nameRegex.IsMatch(firstNameInput.Text))
            {
                MessageBox.Show("Введите корректное имя");
                return;
            }
            if (!_nameRegex.IsMatch(lastNameInput.Text))
            {
                MessageBox.Show("Введите корректную фамилию");
                return;
            }
            if (middleNameInput.Text.Length > 0)
            {
                if (!_nameRegex.IsMatch(middleNameInput.Text))
                {
                    MessageBox.Show("Введите корректное отчество");
                    return;
                }
            }
            if (!_emailRegex.IsMatch(emailInput.Text))
            {
                MessageBox.Show("Введите корректный email");
                return;
            }
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
