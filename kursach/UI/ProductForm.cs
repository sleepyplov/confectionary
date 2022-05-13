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
    internal partial class ProductForm : Form
    {
        Product _product;
        public ProductForm(Product product)
        {
            InitializeComponent();
            expiryCalendar.MinDate = DateTime.Today;
            expiryCalendar.MaxDate = DateTime.Today.AddYears(1);
            if (product == null)
            {
                Text = "Новый продукт";
                return;
            }
            _product = product;
            Text = product.Name;
            nameInput.Text = product.Name;
            nameInput.Enabled = false;
            priceInput.Value = product.Price;
            quantityInput.Value = product.Quantity;
            expiryCalendar.SetDate(product.ExpiryDate);
            contentsBox.Items.AddRange(product.Contents.ToArray());
            expiryCalendar.Enabled = false;
        }

        public event EventHandler<ProductEventArgs> Submit;

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (nameInput.Text.Length == 0)
            {
                MessageBox.Show("Название не может быть пустым");
                return;
            }
            if (priceInput.Value < 1)
            {
                MessageBox.Show("Цена должна быть хотя бы 1 рубль");
                return;
            }
            if (quantityInput.Value < 0)
            {
                MessageBox.Show("Количество не может быть отрицательным");
                return;
            }
            if (contentsBox.Items.Count == 0)
            {
                MessageBox.Show("Состав не может быть пустым");
                return;
            }
            ProductEventArgs args;
            if (_product == null)
            {
                args = new ProductEventArgs(ProductEventType.Create, nameInput.Text,
                    contentsBox.Items.Cast<string>().ToList(), priceInput.Value,
                    Convert.ToUInt32(quantityInput.Value), expiryCalendar.SelectionEnd);
            }
            else
            {
                args = new ProductEventArgs(ProductEventType.Update, _product.ID,
                    nameInput.Text, contentsBox.Items.Cast<string>().ToList(), priceInput.Value,
                    Convert.ToUInt32(quantityInput.Value), expiryCalendar.SelectionEnd);
            }
            Submit?.Invoke(this, args);
        }

        private void addContentBtn_Click(object sender, EventArgs e)
        {
            if (contentItemInput.Text.Length > 0)
            {
                contentsBox.Items.Add(contentItemInput.Text);
            }
            contentItemInput.Clear();
            contentItemInput.Visible = true;
            contentItemInput.Focus();
        }

        private void removeContentBtn_Click(object sender, EventArgs e)
        {
            if (contentsBox.SelectedIndex >= 0)
            {
                contentsBox.Items.RemoveAt(contentsBox.SelectedIndex);
            }
        }

        private void contentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeContentBtn.Visible = contentsBox.SelectedIndex >= 0;
        }

        private void contentItemInput_Leave(object sender, EventArgs e)
        {
            contentItemInput.Visible = false;
        }

        private void contentItemInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var textBox = (TextBox)sender;
                contentsBox.Items.Add(textBox.Text);
                textBox.Clear();
            }
        }
    }
}
