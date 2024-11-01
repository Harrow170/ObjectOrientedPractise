namespace ObjectOrientedPractise.View.Tabs
{
    partial class CartsTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            CartItemsListBox = new ListBox();
            ClearCartButton = new Button();
            RemoveItem = new Button();
            CreateOrder = new Button();
            AmountLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            CustomerComboBox = new ComboBox();
            label1 = new Label();
            AddToCart = new Button();
            ItemsListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CartItemsListBox);
            groupBox1.Controls.Add(ClearCartButton);
            groupBox1.Controls.Add(RemoveItem);
            groupBox1.Controls.Add(CreateOrder);
            groupBox1.Controls.Add(AmountLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(CustomerComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(AddToCart);
            groupBox1.Controls.Add(ItemsListBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 768);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // CartItemsListBox
            // 
            CartItemsListBox.FormattingEnabled = true;
            CartItemsListBox.Location = new Point(292, 120);
            CartItemsListBox.Name = "CartItemsListBox";
            CartItemsListBox.Size = new Size(478, 184);
            CartItemsListBox.TabIndex = 12;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(656, 393);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(114, 38);
            ClearCartButton.TabIndex = 11;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItem
            // 
            RemoveItem.Location = new Point(519, 393);
            RemoveItem.Name = "RemoveItem";
            RemoveItem.Size = new Size(106, 38);
            RemoveItem.TabIndex = 10;
            RemoveItem.Text = "Remove Item";
            RemoveItem.UseVisualStyleBackColor = true;
            RemoveItem.Click += RemoveItem_Click;
            // 
            // CreateOrder
            // 
            CreateOrder.Location = new Point(292, 393);
            CreateOrder.Name = "CreateOrder";
            CreateOrder.Size = new Size(109, 38);
            CreateOrder.TabIndex = 9;
            CreateOrder.Text = "Create Order";
            CreateOrder.UseVisualStyleBackColor = true;
            CreateOrder.Click += CreateOrder_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(720, 353);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(50, 20);
            AmountLabel.TabIndex = 8;
            AmountLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(705, 321);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "Cart:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(373, 32);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(397, 28);
            CustomerComboBox.TabIndex = 4;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Customer;";
            // 
            // AddToCart
            // 
            AddToCart.Location = new Point(3, 658);
            AddToCart.Name = "AddToCart";
            AddToCart.Size = new Size(98, 40);
            AddToCart.TabIndex = 2;
            AddToCart.Text = "Add to cart";
            AddToCart.UseVisualStyleBackColor = true;
            AddToCart.Click += AddToCart_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(0, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(259, 604);
            ItemsListBox.TabIndex = 1;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "CartsTab";
            Size = new Size(776, 768);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button AddToCart;
        private ListBox ItemsListBox;
        private Label label3;
        private Label label2;
        private ComboBox CustomerComboBox;
        private Button CreateOrder;
        private Label AmountLabel;
        private Button ClearCartButton;
        private Button RemoveItem;
        private ListBox CartItemsListBox;
    }
}
