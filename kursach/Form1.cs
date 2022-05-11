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
        private OrderStatus _selectedOrderStatus = OrderStatus.Created;

        public Form1()
        {
            InitializeComponent();
            _store = new Store();
            _store.Error += _store_Error;
            _store.OrderCreated += _store_OrderCreated;
            productsTable.AutoGenerateColumns = false;
            customersTable.AutoGenerateColumns = false;
            ordersTable.AutoGenerateColumns = false;
            productsTable.DataSource = _store.GetProductsTable();
            customersTable.DataSource = _store.GetCustomersTable();
            ordersTable.DataSource = _store.GetOrdersTable();
        }

        private void _store_OrderCreated(object sender, EventArgs e)
        {
            productsTable.DataSource = _store.GetProductsTable(productSearchBox.Text);
            customersTable.DataSource = _store.GetCustomersTable(searchCustomerBox.Text);
            ordersTable.DataSource = _store.GetOrdersTable(searchOrderBox.Text, _selectedOrderStatus);
        }

        private void _store_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Message);
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

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукт для удаления");
                return;
            }
            var rowIndex = productsTable.SelectedRows[0].Index;
            var rowItem = (ProductTableItem)productsTable.Rows[rowIndex].DataBoundItem;
            var result = _store.DeleteProduct(rowItem.ID);
            if (result)
            {
                productsTable.DataSource = _store.GetProductsTable(productSearchBox.Text);
            }
        }

        private void productsTable_SelectionChanged(object sender, EventArgs e)
        {
            deleteProductButton.Enabled = productsTable.SelectedRows.Count > 0;
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

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказчика для удаления");
                return;
            }
            var rowIndex = ordersTable.SelectedRows[0].Index;
            var rowItem = (OrderTableItem)ordersTable.Rows[rowIndex].DataBoundItem;
            var result = _store.DeleteCustomer(rowItem.ID);
            if (result)
            {
                ordersTable.DataSource = _store.GetProductsTable(searchCustomerBox.Text);
            }
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

        private void customersTable_SelectionChanged(object sender, EventArgs e)
        {
            deleteCustomerBtn.Enabled = customersTable.SelectedRows.Count > 0;
        }

        private void searchCustomerBtn_Click(object sender, EventArgs e)
        {
            customersTable.DataSource = _store.GetCustomersTable(searchCustomerBox.Text);
        }

        private void createOrderBtn_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(_store);
            form.ShowDialog();
        }

        private void ordersTable_SelectionChanged(object sender, EventArgs e)
        {
            confirmOrderBtn.Enabled = ordersTable.SelectedRows.Count > 0;
            cancelOrderBtn.Enabled = _selectedOrderStatus == OrderStatus.Created &&
                ordersTable.SelectedRows.Count > 0;
        }

        private void confirmOrderBtn_Click(object sender, EventArgs e)
        {
            if (ordersTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }
            var rowIndex = ordersTable.SelectedRows[0].Index;
            var rowItem = (OrderTableItem)ordersTable.Rows[rowIndex].DataBoundItem;
            bool result;
            if (rowItem.Status == OrderStatus.Created)
            {
                result = _store.ConfirmOrder(rowItem.ID);
            }
            else
            {
                result = _store.DeleteOrder(rowItem.ID);
            }
            if (result)
            {
                productsTable.DataSource = _store.GetProductsTable(productSearchBox.Text);
                customersTable.DataSource = _store.GetCustomersTable(searchCustomerBox.Text);
                ordersTable.DataSource = _store.GetOrdersTable(
                    searchOrderBox.Text, _selectedOrderStatus);
            }
        }

        private void searchOrderBtn_Click(object sender, EventArgs e)
        {
            ordersTable.DataSource = _store.GetOrdersTable(searchOrderBox.Text, _selectedOrderStatus);
        }

        private void showCreatedOrdersBtn_Click(object sender, EventArgs e)
        {
            _selectedOrderStatus = OrderStatus.Created;
            showCreatedOrdersBtn.Enabled = false;
            showDeliveredOrdersBtn.Enabled = true;
            showCanceledOrdersBtn.Enabled = true;
            cancelOrderBtn.Enabled = true;
            confirmOrderBtn.Text = "Подтвердить доставку";
            ordersTable.DataSource = _store.GetOrdersTable(searchOrderBox.Text,
                _selectedOrderStatus);
        }

        private void showDeliveredOrdersBtn_Click(object sender, EventArgs e)
        {
            _selectedOrderStatus = OrderStatus.Delivered;
            showCreatedOrdersBtn.Enabled = true;
            showDeliveredOrdersBtn.Enabled = false;
            showCanceledOrdersBtn.Enabled = true;
            cancelOrderBtn.Enabled = false;
            confirmOrderBtn.Text = "Удалить заказ";
            ordersTable.DataSource = _store.GetOrdersTable(searchOrderBox.Text,
                _selectedOrderStatus);
        }

        private void showCanceledOrdersBtn_Click(object sender, EventArgs e)
        {
            _selectedOrderStatus = OrderStatus.Canceled;
            showCreatedOrdersBtn.Enabled = true;
            showDeliveredOrdersBtn.Enabled = false;
            showCanceledOrdersBtn.Enabled = false;
            cancelOrderBtn.Enabled = false;
            confirmOrderBtn.Text = "Удалить заказ";
            ordersTable.DataSource = _store.GetOrdersTable(searchOrderBox.Text,
                _selectedOrderStatus);
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (ordersTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }
            var rowIndex = ordersTable.SelectedRows[0].Index;
            var rowItem = (OrderTableItem)ordersTable.Rows[rowIndex].DataBoundItem;
            var result = _store.CancelOrder(rowItem.ID);
            if (result)
            {
                productsTable.DataSource = _store.GetProductsTable(productSearchBox.Text);
                ordersTable.DataSource = _store.GetOrdersTable(
                    searchOrderBox.Text, _selectedOrderStatus);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
