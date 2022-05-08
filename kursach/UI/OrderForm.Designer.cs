
namespace Confectionery.UI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchCustomerInput = new System.Windows.Forms.TextBox();
            this.searchCustomerBtn = new System.Windows.Forms.Button();
            this.customerSelectBox = new System.Windows.Forms.ComboBox();
            this.searchProductInput = new System.Windows.Forms.TextBox();
            this.searchProductBtn = new System.Windows.Forms.Button();
            this.selectAddProductBox = new System.Windows.Forms.ComboBox();
            this.orderProductsBox = new System.Windows.Forms.ListBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productExpiryLabel = new System.Windows.Forms.Label();
            this.orderProductQuantityLabel = new System.Windows.Forms.Label();
            this.orderProductQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductQuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказчик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Продукты";
            // 
            // searchCustomerInput
            // 
            this.searchCustomerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCustomerInput.Location = new System.Drawing.Point(15, 28);
            this.searchCustomerInput.Name = "searchCustomerInput";
            this.searchCustomerInput.Size = new System.Drawing.Size(165, 22);
            this.searchCustomerInput.TabIndex = 2;
            this.searchCustomerInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchCustomerInput_KeyUp);
            // 
            // searchCustomerBtn
            // 
            this.searchCustomerBtn.Location = new System.Drawing.Point(186, 28);
            this.searchCustomerBtn.Name = "searchCustomerBtn";
            this.searchCustomerBtn.Size = new System.Drawing.Size(119, 22);
            this.searchCustomerBtn.TabIndex = 3;
            this.searchCustomerBtn.Text = "Найти заказчика";
            this.searchCustomerBtn.UseVisualStyleBackColor = true;
            this.searchCustomerBtn.Click += new System.EventHandler(this.searchCustomerBtn_Click);
            // 
            // customerSelectBox
            // 
            this.customerSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerSelectBox.FormattingEnabled = true;
            this.customerSelectBox.Location = new System.Drawing.Point(15, 56);
            this.customerSelectBox.Name = "customerSelectBox";
            this.customerSelectBox.Size = new System.Drawing.Size(290, 21);
            this.customerSelectBox.TabIndex = 4;
            this.customerSelectBox.SelectedIndexChanged += new System.EventHandler(this.customerSelectBox_SelectedIndexChanged);
            // 
            // searchProductInput
            // 
            this.searchProductInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchProductInput.Location = new System.Drawing.Point(15, 110);
            this.searchProductInput.Name = "searchProductInput";
            this.searchProductInput.Size = new System.Drawing.Size(165, 22);
            this.searchProductInput.TabIndex = 5;
            this.searchProductInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchProductInput_KeyUp);
            // 
            // searchProductBtn
            // 
            this.searchProductBtn.Location = new System.Drawing.Point(189, 110);
            this.searchProductBtn.Name = "searchProductBtn";
            this.searchProductBtn.Size = new System.Drawing.Size(116, 22);
            this.searchProductBtn.TabIndex = 6;
            this.searchProductBtn.Text = "Найти продукты";
            this.searchProductBtn.UseVisualStyleBackColor = true;
            this.searchProductBtn.Click += new System.EventHandler(this.searchProductBtn_Click);
            // 
            // selectAddProductBox
            // 
            this.selectAddProductBox.FormattingEnabled = true;
            this.selectAddProductBox.Location = new System.Drawing.Point(15, 138);
            this.selectAddProductBox.Name = "selectAddProductBox";
            this.selectAddProductBox.Size = new System.Drawing.Size(290, 21);
            this.selectAddProductBox.TabIndex = 7;
            this.selectAddProductBox.SelectedIndexChanged += new System.EventHandler(this.selectAddProductBox_SelectedIndexChanged);
            // 
            // orderProductsBox
            // 
            this.orderProductsBox.FormattingEnabled = true;
            this.orderProductsBox.Location = new System.Drawing.Point(342, 134);
            this.orderProductsBox.Name = "orderProductsBox";
            this.orderProductsBox.Size = new System.Drawing.Size(143, 212);
            this.orderProductsBox.TabIndex = 8;
            this.orderProductsBox.SelectedIndexChanged += new System.EventHandler(this.orderProductsBox_SelectedIndexChanged);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.Location = new System.Drawing.Point(12, 179);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(80, 16);
            this.productNameLabel.TabIndex = 9;
            this.productNameLabel.Text = "Название: ";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPriceLabel.Location = new System.Drawing.Point(12, 205);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(47, 16);
            this.productPriceLabel.TabIndex = 10;
            this.productPriceLabel.Text = "Цена: ";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQuantityLabel.Location = new System.Drawing.Point(12, 232);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(160, 16);
            this.productQuantityLabel.TabIndex = 11;
            this.productQuantityLabel.Text = "Количество на складе: ";
            // 
            // productExpiryLabel
            // 
            this.productExpiryLabel.AutoSize = true;
            this.productExpiryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productExpiryLabel.Location = new System.Drawing.Point(12, 259);
            this.productExpiryLabel.Name = "productExpiryLabel";
            this.productExpiryLabel.Size = new System.Drawing.Size(110, 16);
            this.productExpiryLabel.TabIndex = 12;
            this.productExpiryLabel.Text = "Срок хранения: ";
            // 
            // orderProductQuantityLabel
            // 
            this.orderProductQuantityLabel.AutoSize = true;
            this.orderProductQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderProductQuantityLabel.Location = new System.Drawing.Point(12, 285);
            this.orderProductQuantityLabel.Name = "orderProductQuantityLabel";
            this.orderProductQuantityLabel.Size = new System.Drawing.Size(153, 16);
            this.orderProductQuantityLabel.TabIndex = 13;
            this.orderProductQuantityLabel.Text = "Количество в заказе: ";
            // 
            // orderProductQuantityInput
            // 
            this.orderProductQuantityInput.Location = new System.Drawing.Point(171, 285);
            this.orderProductQuantityInput.Name = "orderProductQuantityInput";
            this.orderProductQuantityInput.Size = new System.Drawing.Size(89, 20);
            this.orderProductQuantityInput.TabIndex = 14;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(15, 319);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(133, 27);
            this.addProductBtn.TabIndex = 15;
            this.addProductBtn.Text = "Добавить в заказ";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.Location = new System.Drawing.Point(154, 319);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(133, 27);
            this.removeProductBtn.TabIndex = 16;
            this.removeProductBtn.Text = "Убрать из заказа";
            this.removeProductBtn.UseVisualStyleBackColor = true;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceLabel.Location = new System.Drawing.Point(339, 110);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(50, 16);
            this.totalPriceLabel.TabIndex = 17;
            this.totalPriceLabel.Text = "Итого:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(438, 373);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(134, 26);
            this.submitBtn.TabIndex = 18;
            this.submitBtn.Text = "Сохранить";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(298, 373);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(134, 26);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.removeProductBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.orderProductQuantityInput);
            this.Controls.Add(this.orderProductQuantityLabel);
            this.Controls.Add(this.productExpiryLabel);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.orderProductsBox);
            this.Controls.Add(this.selectAddProductBox);
            this.Controls.Add(this.searchProductBtn);
            this.Controls.Add(this.searchProductInput);
            this.Controls.Add(this.customerSelectBox);
            this.Controls.Add(this.searchCustomerBtn);
            this.Controls.Add(this.searchCustomerInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderProductQuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchCustomerInput;
        private System.Windows.Forms.Button searchCustomerBtn;
        private System.Windows.Forms.ComboBox customerSelectBox;
        private System.Windows.Forms.TextBox searchProductInput;
        private System.Windows.Forms.Button searchProductBtn;
        private System.Windows.Forms.ComboBox selectAddProductBox;
        private System.Windows.Forms.ListBox orderProductsBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.Label productExpiryLabel;
        private System.Windows.Forms.Label orderProductQuantityLabel;
        private System.Windows.Forms.NumericUpDown orderProductQuantityInput;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button removeProductBtn;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}