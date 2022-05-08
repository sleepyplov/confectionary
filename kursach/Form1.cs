using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confectionery.Core;
using Confectionery.Models;
using Confectionery.UI;

namespace Confectionery
{
    public partial class Form1 : Form
    {
        private Store _store;

        public Form1()
        {
            InitializeComponent();
            _store = new Store();
            _store.Error += _store_Error;
            productsTable.AutoGenerateColumns = false;
            customersTable.AutoGenerateColumns = false;
            ordersTable.AutoGenerateColumns = false;
            productsTable.DataSource = _store.GetProductsTable();
            customersTable.DataSource = _store.GetCustomersTable();
            ordersTable.DataSource = _store.GetOrdersTable();
        }

        private void _store_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Message, "Инсульт жопы");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showProductForm(Product product)
        {
            var productForm = new ProductForm(product);
            productForm.Submit += productForm_Submit;
            productForm.ShowDialog();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            showProductForm(null);
        }

        private void productsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowItem = (ProductTableItem)productsTable.Rows[e.RowIndex].DataBoundItem;
            var product = _store.GetProduct(rowItem.ID);
            showProductForm(product);
        }

        private void productForm_Submit(object sender, ProductEventArgs e)
        {
            var result = _store.HandleProductEvent(e);
            if (result)
            {
                ((ProductForm)sender).Close();
            }
            productsTable.DataSource = _store.GetProductsTable();
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            productsTable.DataSource = _store.GetProductsTable(productSearchBox.Text);
        }

        private void showCustomerForm(Customer customer)
        {
            var customerForm = new CustomerForm(customer);
            customerForm.Submit += customerForm_Submit;
            customerForm.ShowDialog();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            showCustomerForm(null);
        }

        private void customerForm_Submit(object sender, CustomerEventArgs e)
        {
            var result = _store.HandleCustomerEvent(e);
            if (result)
            {
                ((CustomerForm)sender).Close();
            }
            customersTable.DataSource = _store.GetCustomersTable();
        }

        private void customersTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowItem = (CustomerTableItem)customersTable.Rows[e.RowIndex].DataBoundItem;
            var customer = _store.GetCustomer(rowItem.ID);
            showCustomerForm(customer);
        }

        private void createOrderBtn_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(_store);
            form.ShowDialog();
        }
    }
}
