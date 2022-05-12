
namespace Confectionery
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabsControl = new System.Windows.Forms.TabControl();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.productNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productContentsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productExpiryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.searchCustomerBtn = new System.Windows.Forms.Button();
            this.searchCustomerBox = new System.Windows.Forms.TextBox();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.customerLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMiddleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrdersTotalCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrdersTotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.showCreatedOrdersBtn = new System.Windows.Forms.Button();
            this.showCanceledOrdersBtn = new System.Windows.Forms.Button();
            this.showDeliveredOrdersBtn = new System.Windows.Forms.Button();
            this.confirmOrderBtn = new System.Windows.Forms.Button();
            this.searchOrderBtn = new System.Windows.Forms.Button();
            this.searchOrderBox = new System.Windows.Forms.TextBox();
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.orderIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCustomerEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDeliveryAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDeliveryDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainTabsControl.SuspendLayout();
            this.productsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabsControl
            // 
            this.mainTabsControl.Controls.Add(this.productsTab);
            this.mainTabsControl.Controls.Add(this.customersTab);
            this.mainTabsControl.Controls.Add(this.ordersTab);
            this.mainTabsControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabsControl.Name = "mainTabsControl";
            this.mainTabsControl.SelectedIndex = 0;
            this.mainTabsControl.Size = new System.Drawing.Size(776, 426);
            this.mainTabsControl.TabIndex = 0;
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.productsTable);
            this.productsTab.Controls.Add(this.productSearchButton);
            this.productsTab.Controls.Add(this.productSearchBox);
            this.productsTab.Controls.Add(this.deleteProductButton);
            this.productsTab.Controls.Add(this.addProductButton);
            this.productsTab.Location = new System.Drawing.Point(4, 22);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(3);
            this.productsTab.Size = new System.Drawing.Size(768, 400);
            this.productsTab.TabIndex = 0;
            this.productsTab.Text = "Продукты";
            this.productsTab.UseVisualStyleBackColor = true;
            // 
            // productsTable
            // 
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameColumn,
            this.productContentsColumn,
            this.productPriceColumn,
            this.productQuantityColumn,
            this.productExpiryDateColumn});
            this.productsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.productsTable.Location = new System.Drawing.Point(210, 41);
            this.productsTable.MultiSelect = false;
            this.productsTable.Name = "productsTable";
            this.productsTable.RowHeadersVisible = false;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(555, 356);
            this.productsTable.TabIndex = 4;
            this.productsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsTable_CellDoubleClick);
            this.productsTable.SelectionChanged += new System.EventHandler(this.productsTable_SelectionChanged);
            // 
            // productNameColumn
            // 
            this.productNameColumn.DataPropertyName = "Name";
            this.productNameColumn.HeaderText = "Название";
            this.productNameColumn.Name = "productNameColumn";
            // 
            // productContentsColumn
            // 
            this.productContentsColumn.DataPropertyName = "Contents";
            this.productContentsColumn.HeaderText = "Состав";
            this.productContentsColumn.Name = "productContentsColumn";
            // 
            // productPriceColumn
            // 
            this.productPriceColumn.DataPropertyName = "Price";
            this.productPriceColumn.HeaderText = "Цена";
            this.productPriceColumn.Name = "productPriceColumn";
            // 
            // productQuantityColumn
            // 
            this.productQuantityColumn.DataPropertyName = "Quantity";
            this.productQuantityColumn.HeaderText = "Количество";
            this.productQuantityColumn.Name = "productQuantityColumn";
            // 
            // productExpiryDateColumn
            // 
            this.productExpiryDateColumn.DataPropertyName = "ExpiryDate";
            this.productExpiryDateColumn.HeaderText = "Срок хранения";
            this.productExpiryDateColumn.Name = "productExpiryDateColumn";
            // 
            // productSearchButton
            // 
            this.productSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.productSearchButton.Location = new System.Drawing.Point(516, 6);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(125, 29);
            this.productSearchButton.TabIndex = 3;
            this.productSearchButton.Text = "Найти продукт";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // productSearchBox
            // 
            this.productSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productSearchBox.Location = new System.Drawing.Point(210, 6);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(300, 26);
            this.productSearchBox.TabIndex = 2;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(6, 47);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(125, 35);
            this.deleteProductButton.TabIndex = 1;
            this.deleteProductButton.Text = "Удалить продукт";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(6, 6);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(125, 35);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Добавить продукт";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.searchCustomerBtn);
            this.customersTab.Controls.Add(this.searchCustomerBox);
            this.customersTab.Controls.Add(this.deleteCustomerBtn);
            this.customersTab.Controls.Add(this.addCustomerBtn);
            this.customersTab.Controls.Add(this.customersTable);
            this.customersTab.Location = new System.Drawing.Point(4, 22);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(768, 400);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Заказчики";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // searchCustomerBtn
            // 
            this.searchCustomerBtn.Location = new System.Drawing.Point(443, 6);
            this.searchCustomerBtn.Name = "searchCustomerBtn";
            this.searchCustomerBtn.Size = new System.Drawing.Size(125, 29);
            this.searchCustomerBtn.TabIndex = 4;
            this.searchCustomerBtn.Text = "Найти заказчика";
            this.searchCustomerBtn.UseVisualStyleBackColor = true;
            this.searchCustomerBtn.Click += new System.EventHandler(this.searchCustomerBtn_Click);
            // 
            // searchCustomerBox
            // 
            this.searchCustomerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCustomerBox.Location = new System.Drawing.Point(137, 6);
            this.searchCustomerBox.Name = "searchCustomerBox";
            this.searchCustomerBox.Size = new System.Drawing.Size(300, 26);
            this.searchCustomerBox.TabIndex = 3;
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(6, 47);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(125, 35);
            this.deleteCustomerBtn.TabIndex = 2;
            this.deleteCustomerBtn.Text = "Удалить заказчика";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(6, 6);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(125, 35);
            this.addCustomerBtn.TabIndex = 1;
            this.addCustomerBtn.Text = "Добавить заказчика";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // customersTable
            // 
            this.customersTable.AllowUserToAddRows = false;
            this.customersTable.AllowUserToDeleteRows = false;
            this.customersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerLastNameColumn,
            this.customerFirstNameColumn,
            this.customerMiddleNameColumn,
            this.customerEmailColumn,
            this.customerOrdersTotalCountColumn,
            this.customerOrdersTotalPriceColumn});
            this.customersTable.Location = new System.Drawing.Point(137, 41);
            this.customersTable.MultiSelect = false;
            this.customersTable.Name = "customersTable";
            this.customersTable.ReadOnly = true;
            this.customersTable.RowHeadersVisible = false;
            this.customersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersTable.Size = new System.Drawing.Size(628, 356);
            this.customersTable.TabIndex = 0;
            this.customersTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersTable_CellDoubleClick);
            this.customersTable.SelectionChanged += new System.EventHandler(this.customersTable_SelectionChanged);
            // 
            // customerLastNameColumn
            // 
            this.customerLastNameColumn.DataPropertyName = "LastName";
            this.customerLastNameColumn.HeaderText = "Фамилия";
            this.customerLastNameColumn.Name = "customerLastNameColumn";
            this.customerLastNameColumn.ReadOnly = true;
            // 
            // customerFirstNameColumn
            // 
            this.customerFirstNameColumn.DataPropertyName = "FirstName";
            this.customerFirstNameColumn.HeaderText = "Имя";
            this.customerFirstNameColumn.Name = "customerFirstNameColumn";
            this.customerFirstNameColumn.ReadOnly = true;
            // 
            // customerMiddleNameColumn
            // 
            this.customerMiddleNameColumn.DataPropertyName = "MiddleName";
            this.customerMiddleNameColumn.HeaderText = "Отчество";
            this.customerMiddleNameColumn.Name = "customerMiddleNameColumn";
            this.customerMiddleNameColumn.ReadOnly = true;
            // 
            // customerEmailColumn
            // 
            this.customerEmailColumn.DataPropertyName = "Email";
            this.customerEmailColumn.HeaderText = "Email";
            this.customerEmailColumn.Name = "customerEmailColumn";
            this.customerEmailColumn.ReadOnly = true;
            // 
            // customerOrdersTotalCountColumn
            // 
            this.customerOrdersTotalCountColumn.DataPropertyName = "OrdersTotalCount";
            this.customerOrdersTotalCountColumn.HeaderText = "Количество заказов";
            this.customerOrdersTotalCountColumn.Name = "customerOrdersTotalCountColumn";
            this.customerOrdersTotalCountColumn.ReadOnly = true;
            // 
            // customerOrdersTotalPriceColumn
            // 
            this.customerOrdersTotalPriceColumn.DataPropertyName = "OrdersTotalPrice";
            this.customerOrdersTotalPriceColumn.HeaderText = "Сумма заказов";
            this.customerOrdersTotalPriceColumn.Name = "customerOrdersTotalPriceColumn";
            this.customerOrdersTotalPriceColumn.ReadOnly = true;
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.cancelOrderBtn);
            this.ordersTab.Controls.Add(this.showCreatedOrdersBtn);
            this.ordersTab.Controls.Add(this.showCanceledOrdersBtn);
            this.ordersTab.Controls.Add(this.showDeliveredOrdersBtn);
            this.ordersTab.Controls.Add(this.confirmOrderBtn);
            this.ordersTab.Controls.Add(this.searchOrderBtn);
            this.ordersTab.Controls.Add(this.searchOrderBox);
            this.ordersTab.Controls.Add(this.createOrderBtn);
            this.ordersTab.Controls.Add(this.ordersTable);
            this.ordersTab.Location = new System.Drawing.Point(4, 22);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(768, 400);
            this.ordersTab.TabIndex = 2;
            this.ordersTab.Text = "Заказы";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Location = new System.Drawing.Point(5, 211);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(125, 35);
            this.cancelOrderBtn.TabIndex = 8;
            this.cancelOrderBtn.Text = "Отменить";
            this.cancelOrderBtn.UseVisualStyleBackColor = true;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // showCreatedOrdersBtn
            // 
            this.showCreatedOrdersBtn.Enabled = false;
            this.showCreatedOrdersBtn.Location = new System.Drawing.Point(5, 88);
            this.showCreatedOrdersBtn.Name = "showCreatedOrdersBtn";
            this.showCreatedOrdersBtn.Size = new System.Drawing.Size(125, 35);
            this.showCreatedOrdersBtn.TabIndex = 7;
            this.showCreatedOrdersBtn.Text = "Показать созданные";
            this.showCreatedOrdersBtn.UseVisualStyleBackColor = true;
            this.showCreatedOrdersBtn.Click += new System.EventHandler(this.showCreatedOrdersBtn_Click);
            // 
            // showCanceledOrdersBtn
            // 
            this.showCanceledOrdersBtn.Location = new System.Drawing.Point(5, 170);
            this.showCanceledOrdersBtn.Name = "showCanceledOrdersBtn";
            this.showCanceledOrdersBtn.Size = new System.Drawing.Size(125, 35);
            this.showCanceledOrdersBtn.TabIndex = 6;
            this.showCanceledOrdersBtn.Text = "Показать отмененные";
            this.showCanceledOrdersBtn.UseVisualStyleBackColor = true;
            this.showCanceledOrdersBtn.Click += new System.EventHandler(this.showCanceledOrdersBtn_Click);
            // 
            // showDeliveredOrdersBtn
            // 
            this.showDeliveredOrdersBtn.Location = new System.Drawing.Point(5, 129);
            this.showDeliveredOrdersBtn.Name = "showDeliveredOrdersBtn";
            this.showDeliveredOrdersBtn.Size = new System.Drawing.Size(125, 35);
            this.showDeliveredOrdersBtn.TabIndex = 5;
            this.showDeliveredOrdersBtn.Text = "Показать доставленные";
            this.showDeliveredOrdersBtn.UseVisualStyleBackColor = true;
            this.showDeliveredOrdersBtn.Click += new System.EventHandler(this.showDeliveredOrdersBtn_Click);
            // 
            // confirmOrderBtn
            // 
            this.confirmOrderBtn.Location = new System.Drawing.Point(5, 47);
            this.confirmOrderBtn.Name = "confirmOrderBtn";
            this.confirmOrderBtn.Size = new System.Drawing.Size(125, 35);
            this.confirmOrderBtn.TabIndex = 4;
            this.confirmOrderBtn.Text = "Подтвердить доставку";
            this.confirmOrderBtn.UseVisualStyleBackColor = true;
            this.confirmOrderBtn.Click += new System.EventHandler(this.confirmOrderBtn_Click);
            // 
            // searchOrderBtn
            // 
            this.searchOrderBtn.Location = new System.Drawing.Point(442, 6);
            this.searchOrderBtn.Name = "searchOrderBtn";
            this.searchOrderBtn.Size = new System.Drawing.Size(125, 29);
            this.searchOrderBtn.TabIndex = 3;
            this.searchOrderBtn.Text = "Найти заказ";
            this.searchOrderBtn.UseVisualStyleBackColor = true;
            this.searchOrderBtn.Click += new System.EventHandler(this.searchOrderBtn_Click);
            // 
            // searchOrderBox
            // 
            this.searchOrderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchOrderBox.Location = new System.Drawing.Point(136, 6);
            this.searchOrderBox.Name = "searchOrderBox";
            this.searchOrderBox.Size = new System.Drawing.Size(300, 26);
            this.searchOrderBox.TabIndex = 2;
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.Location = new System.Drawing.Point(5, 6);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(125, 35);
            this.createOrderBtn.TabIndex = 1;
            this.createOrderBtn.Text = "Создать заказ";
            this.createOrderBtn.UseVisualStyleBackColor = true;
            this.createOrderBtn.Click += new System.EventHandler(this.createOrderBtn_Click);
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            this.ordersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDColumn,
            this.orderCustomerEmailColumn,
            this.orderTotalPriceColumn,
            this.orderDeliveryAddressColumn,
            this.orderDeliveryDateColumn});
            this.ordersTable.Location = new System.Drawing.Point(136, 41);
            this.ordersTable.MultiSelect = false;
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.ReadOnly = true;
            this.ordersTable.RowHeadersVisible = false;
            this.ordersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersTable.Size = new System.Drawing.Size(629, 356);
            this.ordersTable.TabIndex = 0;
            this.ordersTable.SelectionChanged += new System.EventHandler(this.ordersTable_SelectionChanged);
            // 
            // orderIDColumn
            // 
            this.orderIDColumn.DataPropertyName = "ID";
            this.orderIDColumn.HeaderText = "Трек-номер";
            this.orderIDColumn.Name = "orderIDColumn";
            this.orderIDColumn.ReadOnly = true;
            // 
            // orderCustomerEmailColumn
            // 
            this.orderCustomerEmailColumn.DataPropertyName = "CustomerEmail";
            this.orderCustomerEmailColumn.HeaderText = "Email заказчика";
            this.orderCustomerEmailColumn.Name = "orderCustomerEmailColumn";
            this.orderCustomerEmailColumn.ReadOnly = true;
            // 
            // orderTotalPriceColumn
            // 
            this.orderTotalPriceColumn.DataPropertyName = "TotalPrice";
            this.orderTotalPriceColumn.HeaderText = "Сумма";
            this.orderTotalPriceColumn.Name = "orderTotalPriceColumn";
            this.orderTotalPriceColumn.ReadOnly = true;
            // 
            // orderDeliveryAddressColumn
            // 
            this.orderDeliveryAddressColumn.DataPropertyName = "DeliveryAddress";
            this.orderDeliveryAddressColumn.HeaderText = "Адрес доставки";
            this.orderDeliveryAddressColumn.Name = "orderDeliveryAddressColumn";
            this.orderDeliveryAddressColumn.ReadOnly = true;
            // 
            // orderDeliveryDateColumn
            // 
            this.orderDeliveryDateColumn.DataPropertyName = "DeliveryDate";
            this.orderDeliveryDateColumn.HeaderText = "Дата доставки";
            this.orderDeliveryDateColumn.Name = "orderDeliveryDateColumn";
            this.orderDeliveryDateColumn.ReadOnly = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(657, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 26);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Сохранить и выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.mainTabsControl);
            this.Name = "Form1";
            this.Text = "Кондитерская фабрика";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabsControl.ResumeLayout(false);
            this.productsTab.ResumeLayout(false);
            this.productsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.ordersTab.ResumeLayout(false);
            this.ordersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabsControl;
        private System.Windows.Forms.TabPage productsTab;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TabPage ordersTab;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productContentsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productExpiryDateColumn;
        private System.Windows.Forms.DataGridView customersTable;
        private System.Windows.Forms.Button searchCustomerBtn;
        private System.Windows.Forms.TextBox searchCustomerBox;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.Button createOrderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMiddleNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrdersTotalCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrdersTotalPriceColumn;
        private System.Windows.Forms.Button confirmOrderBtn;
        private System.Windows.Forms.Button searchOrderBtn;
        private System.Windows.Forms.TextBox searchOrderBox;
        private System.Windows.Forms.Button showCreatedOrdersBtn;
        private System.Windows.Forms.Button showCanceledOrdersBtn;
        private System.Windows.Forms.Button showDeliveredOrdersBtn;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCustomerEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDeliveryAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDeliveryDateColumn;
        private System.Windows.Forms.Button exitBtn;
    }
}

