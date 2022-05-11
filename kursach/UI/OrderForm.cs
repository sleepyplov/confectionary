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

namespace Confectionery.UI
{
    partial class OrderForm : Form
    {
        private Store _store;
        private List<Customer> _customers = new List<Customer>();
        private Customer _selectedCustomer;
        private List<Product> _products = new List<Product>();
        private Product _selectedProduct;
        private List<OrderProduct> _orderProducts = new List<OrderProduct>();
        private OrderProduct _selectedOrderProduct;
        public OrderForm(Store store)
        {
            InitializeComponent();
            _store = store;
            deliveryDateCalendar.MinDate = DateTime.Today.AddDays(1);
            deliveryDateCalendar.MaxDate = DateTime.Today.AddDays(14);
            deliveryDateCalendar.SetDate(DateTime.Today.AddDays(1));
        }

        private void SearchCustomers()
        {
            var search = searchCustomerInput.Text;
            _customers = _store.FindCustomers(search).ToList();
            customerSelectBox.DataSource = _customers.Select(c => c.GetListBoxString()).ToList();
        }

        private void searchCustomerBtn_Click(object sender, EventArgs e)
        {
            SearchCustomers();
        }

        private void searchCustomerInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchCustomers();
            }
        }

        private void customerSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerSelectBox.SelectedIndex != -1 &&
                customerSelectBox.SelectedIndex < _customers.Count)
            {
                _selectedCustomer = _customers[customerSelectBox.SelectedIndex];
            }
            else
            {
                _selectedCustomer = null;
            }
        }

        private void SearchProducts()
        {
            var search = searchProductInput.Text;
            _products = _store.FindProducts(search).Where(p => p.Quantity > 0).ToList();
            selectAddProductBox.DataSource = _products.Select(p => p.GetListBoxString()).ToList();
        }

        private void searchProductBtn_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void searchProductInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchProducts();
            }
        }

        private void HideCurrentProduct()
        {
            //_selectedProduct = null;
            //_selectedOrderProduct = null;
            productNameLabel.Text = "";
            productPriceLabel.Text = "";
            productQuantityLabel.Text = "";
            productExpiryLabel.Text = "";
            orderProductQuantityLabel.Visible = false;
            orderProductQuantityInput.Value = 1;
            orderProductQuantityInput.Visible = false;
            addProductBtn.Visible = false;
            removeProductBtn.Visible = false;
        }

        private void selectAddProductBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectAddProductBox.SelectedIndex == -1 ||
                selectAddProductBox.SelectedIndex >= _products.Count)
            {
                HideCurrentProduct();
            }
            else
            {
                _selectedProduct = _products[selectAddProductBox.SelectedIndex];
                _selectedOrderProduct = _orderProducts.Find(op =>
                    op.Product.ID == _selectedProduct.ID);
                productNameLabel.Text = "Название: " + _selectedProduct.Name;
                productPriceLabel.Text = "Цена: " + _selectedProduct.Price.ToString();
                productQuantityLabel.Text = "Количество на складе: " + _selectedProduct.Quantity.ToString();
                productExpiryLabel.Text = "Срок хранения: " + _selectedProduct.ExpiryDate.ToString();
                orderProductQuantityLabel.Visible = true;
                orderProductQuantityInput.Visible = true;
                if (_selectedOrderProduct != null)
                {
                    orderProductQuantityInput.Value = _selectedOrderProduct.Count;
                    addProductBtn.Visible = false;
                    removeProductBtn.Visible = true;
                }
                else
                {
                    orderProductQuantityInput.Value = 1;
                    addProductBtn.Visible = true;
                    removeProductBtn.Visible = false;
                }
            }
            orderProductQuantityInput.Maximum = _selectedProduct.Quantity;
        }

        private void updateTotalPrice()
        {
            var total = _orderProducts.Aggregate(0m, (ac, op) => ac + op.Product.Price * op.Count);
            totalPriceLabel.Text = $"Итого: {total}";
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            var orderProduct = new OrderProduct(_selectedProduct,
                (uint)orderProductQuantityInput.Value);
            _orderProducts.Add(orderProduct);
            orderProductsBox.Items.Add(orderProduct.GetListBoxString());
            var minDeliveryDate = _orderProducts.Min(op => op.Product.ExpiryDate);
            if (deliveryDateCalendar.SelectionEnd > minDeliveryDate)
            {
                deliveryDateCalendar.SetDate(minDeliveryDate);
            }
            deliveryDateCalendar.MaxDate = minDeliveryDate;
            addProductBtn.Visible = false;
            removeProductBtn.Visible = true;
            updateTotalPrice();
        }

        private void removeProductBtn_Click(object sender, EventArgs e)
        {
            _orderProducts.RemoveAt(orderProductsBox.SelectedIndex);
            orderProductsBox.Items.RemoveAt(orderProductsBox.SelectedIndex);
            updateTotalPrice();
        }

        private void orderProductsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderProductsBox.SelectedIndex >= 0 &&
                orderProductsBox.SelectedIndex < _orderProducts.Count)
            {
                _selectedOrderProduct = _orderProducts[orderProductsBox.SelectedIndex];
                _selectedProduct = _selectedOrderProduct.Product;
                productNameLabel.Text = "Название: " + _selectedProduct.Name;
                productPriceLabel.Text = "Цена: " + _selectedProduct.Price.ToString();
                productQuantityLabel.Text = "Количество на складе: " + _selectedProduct.Quantity.ToString();
                productExpiryLabel.Text = "Срок хранения: " + _selectedProduct.ExpiryDate.ToString();
                orderProductQuantityLabel.Visible = true;
                orderProductQuantityInput.Visible = true;
                orderProductQuantityInput.Value = _selectedOrderProduct.Count;
                orderProductQuantityInput.Maximum = _selectedProduct.Quantity;
                addProductBtn.Visible = false;
                removeProductBtn.Visible = true;
            }
            else
            {
                HideCurrentProduct();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                MessageBox.Show("Выберите заказчика");
                return;
            }
            if (_orderProducts.Count == 0)
            {
                MessageBox.Show("Нельзя создать заказ без продуктов");
                return;
            }
            if (deliveryAddressInput.Text.Length == 0)
            {
                MessageBox.Show("Адрес доставки не может быть пустым");
            }
            foreach (var op in _orderProducts)
            {
                if (op.Count > op.Product.Quantity)
                {
                    MessageBox.Show($"Для продукта \"{ op.Product.Name}\" выбрано количество больше, чем на складе ");
                    return;
                }
                if (deliveryDateCalendar.SelectionEnd > op.Product.ExpiryDate)
                {
                    MessageBox.Show($"Выбрана дата доставки позже, чем срок хранения продукта \"{op.Product.Name}\"");
                    return;
                }
            }
            var result = _store.CreateOrder(_selectedCustomer.ID, _orderProducts,
                deliveryDateCalendar.SelectionStart, deliveryAddressInput.Text);
            if (result)
            {
                Close();
            }
        }

        private void orderProductQuantityInput_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedOrderProduct == null)
            {
                if (orderProductQuantityInput.Value > _selectedProduct.Quantity)
                {
                    orderProductQuantityInput.Value = _selectedProduct.Quantity;
                }
                return;
            }
            else
            {
                if (orderProductQuantityInput.Value > _selectedOrderProduct.Product.Quantity)
                {
                    orderProductQuantityInput.Value = _selectedOrderProduct.Product.Quantity;
                }
            }
            var index = _orderProducts.FindIndex(op =>
                op.Product.ID == _selectedOrderProduct.Product.ID);
            _orderProducts[index].Count =
                (uint)orderProductQuantityInput.Value;
            orderProductsBox.Items[index] =
                _orderProducts[index].GetListBoxString();
            updateTotalPrice();
        }
    }
}
