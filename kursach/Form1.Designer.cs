
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
            this.customerFirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerMiddleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrdersTotalCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOrdersTotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.mainTabsControl.SuspendLayout();
            this.productsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
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
            this.productsTable.Name = "productsTable";
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(552, 208);
            this.productsTable.TabIndex = 4;
            this.productsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsTable_CellDoubleClick);
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
            this.productSearchButton.Location = new System.Drawing.Point(464, 6);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(108, 29);
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
            this.productSearchBox.Size = new System.Drawing.Size(248, 26);
            this.productSearchBox.TabIndex = 2;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(6, 48);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(108, 36);
            this.deleteProductButton.TabIndex = 1;
            this.deleteProductButton.Text = "Удалить продукт";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(6, 6);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(108, 36);
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
            this.searchCustomerBtn.Location = new System.Drawing.Point(438, 6);
            this.searchCustomerBtn.Name = "searchCustomerBtn";
            this.searchCustomerBtn.Size = new System.Drawing.Size(102, 26);
            this.searchCustomerBtn.TabIndex = 4;
            this.searchCustomerBtn.Text = "Найти заказчика";
            this.searchCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // searchCustomerBox
            // 
            this.searchCustomerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCustomerBox.Location = new System.Drawing.Point(134, 6);
            this.searchCustomerBox.Name = "searchCustomerBox";
            this.searchCustomerBox.Size = new System.Drawing.Size(298, 26);
            this.searchCustomerBox.TabIndex = 3;
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(6, 51);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(122, 39);
            this.deleteCustomerBtn.TabIndex = 2;
            this.deleteCustomerBtn.Text = "Удалить заказчика";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(6, 6);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(122, 39);
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
            this.customerFirstNameColumn,
            this.customerLastNameColumn,
            this.customerMiddleNameColumn,
            this.customerEmailColumn,
            this.customerOrdersTotalCountColumn,
            this.customerOrdersTotalPriceColumn});
            this.customersTable.Location = new System.Drawing.Point(134, 38);
            this.customersTable.Name = "customersTable";
            this.customersTable.ReadOnly = true;
            this.customersTable.Size = new System.Drawing.Size(628, 188);
            this.customersTable.TabIndex = 0;
            this.customersTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersTable_CellDoubleClick);
            // 
            // customerFirstNameColumn
            // 
            this.customerFirstNameColumn.DataPropertyName = "FirstName";
            this.customerFirstNameColumn.HeaderText = "Имя";
            this.customerFirstNameColumn.Name = "customerFirstNameColumn";
            this.customerFirstNameColumn.ReadOnly = true;
            // 
            // customerLastNameColumn
            // 
            this.customerLastNameColumn.DataPropertyName = "LastName";
            this.customerLastNameColumn.HeaderText = "Фамилия";
            this.customerLastNameColumn.Name = "customerLastNameColumn";
            this.customerLastNameColumn.ReadOnly = true;
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
            this.ordersTab.Location = new System.Drawing.Point(4, 22);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(768, 400);
            this.ordersTab.TabIndex = 2;
            this.ordersTab.Text = "Заказы";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabsControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabsControl.ResumeLayout(false);
            this.productsTab.ResumeLayout(false);
            this.productsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerMiddleNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrdersTotalCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOrdersTotalPriceColumn;
        private System.Windows.Forms.Button searchCustomerBtn;
        private System.Windows.Forms.TextBox searchCustomerBox;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button addCustomerBtn;
    }
}

