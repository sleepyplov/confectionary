
namespace Confectionery.UI
{
    partial class ProductForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.expiryCalendar = new System.Windows.Forms.MonthCalendar();
            this.priceInput = new System.Windows.Forms.NumericUpDown();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.contentsBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.addContentBtn = new System.Windows.Forms.Button();
            this.removeContentBtn = new System.Windows.Forms.Button();
            this.contentItemInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(310, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Состав";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Срок хранения";
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(104, 71);
            this.quantityInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(83, 20);
            this.quantityInput.TabIndex = 5;
            // 
            // expiryCalendar
            // 
            this.expiryCalendar.Location = new System.Drawing.Point(15, 130);
            this.expiryCalendar.MaxSelectionCount = 1;
            this.expiryCalendar.MinDate = new System.DateTime(2022, 5, 5, 0, 0, 0, 0);
            this.expiryCalendar.Name = "expiryCalendar";
            this.expiryCalendar.ShowToday = false;
            this.expiryCalendar.TabIndex = 6;
            this.expiryCalendar.TodayDate = new System.DateTime(2022, 5, 5, 0, 0, 0, 0);
            // 
            // priceInput
            // 
            this.priceInput.DecimalPlaces = 2;
            this.priceInput.Location = new System.Drawing.Point(104, 40);
            this.priceInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(83, 20);
            this.priceInput.TabIndex = 7;
            this.priceInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(104, 9);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(137, 20);
            this.nameInput.TabIndex = 8;
            // 
            // contentsBox
            // 
            this.contentsBox.FormattingEnabled = true;
            this.contentsBox.Location = new System.Drawing.Point(313, 28);
            this.contentsBox.Name = "contentsBox";
            this.contentsBox.Size = new System.Drawing.Size(159, 173);
            this.contentsBox.TabIndex = 9;
            this.contentsBox.SelectedIndexChanged += new System.EventHandler(this.contentsBox_SelectedIndexChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(221, 309);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(113, 25);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(340, 309);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(113, 25);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Сохранить";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // addContentBtn
            // 
            this.addContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addContentBtn.Location = new System.Drawing.Point(313, 207);
            this.addContentBtn.Name = "addContentBtn";
            this.addContentBtn.Size = new System.Drawing.Size(85, 28);
            this.addContentBtn.TabIndex = 12;
            this.addContentBtn.Text = "Добавить";
            this.addContentBtn.UseVisualStyleBackColor = true;
            this.addContentBtn.Click += new System.EventHandler(this.addContentBtn_Click);
            // 
            // removeContentBtn
            // 
            this.removeContentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeContentBtn.Location = new System.Drawing.Point(404, 207);
            this.removeContentBtn.Name = "removeContentBtn";
            this.removeContentBtn.Size = new System.Drawing.Size(68, 28);
            this.removeContentBtn.TabIndex = 13;
            this.removeContentBtn.Text = "Убрать";
            this.removeContentBtn.UseVisualStyleBackColor = true;
            this.removeContentBtn.Visible = false;
            this.removeContentBtn.Click += new System.EventHandler(this.removeContentBtn_Click);
            // 
            // contentItemInput
            // 
            this.contentItemInput.Location = new System.Drawing.Point(313, 241);
            this.contentItemInput.Name = "contentItemInput";
            this.contentItemInput.Size = new System.Drawing.Size(159, 20);
            this.contentItemInput.TabIndex = 14;
            this.contentItemInput.Visible = false;
            this.contentItemInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.contentItemInput_KeyUp);
            this.contentItemInput.Leave += new System.EventHandler(this.contentItemInput_Leave);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.contentItemInput);
            this.Controls.Add(this.removeContentBtn);
            this.Controls.Add(this.addContentBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.contentsBox);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.expiryCalendar);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.MonthCalendar expiryCalendar;
        private System.Windows.Forms.NumericUpDown priceInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ListBox contentsBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button addContentBtn;
        private System.Windows.Forms.Button removeContentBtn;
        private System.Windows.Forms.TextBox contentItemInput;
    }
}