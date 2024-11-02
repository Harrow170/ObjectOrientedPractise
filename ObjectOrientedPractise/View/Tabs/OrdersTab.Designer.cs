namespace ObjectOrientedPractise.View.Tabs
{
    partial class OrdersTab
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
            Address address2 = new Address();
            groupBox1 = new GroupBox();
            OrdersDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            OrderStatusColumn = new DataGridViewTextBoxColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            label1 = new Label();
            IdTextBox = new TextBox();
            label2 = new Label();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            label3 = new Label();
            AddressControl = new Controls.AddressControl();
            label4 = new Label();
            OrderItemsListBox = new ListBox();
            label5 = new Label();
            AmountCost = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdersDataGridView);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 793);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orders";
            // 
            // dataGridView1
            // 
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CreatedColumn, OrderStatusColumn, FullNameColumn });
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.Location = new Point(3, 23);
            OrdersDataGridView.Name = "dataGridView1";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(411, 767);
            OrdersDataGridView.TabIndex = 0;
           // OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // Column1
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "Column1";
            IdColumn.Width = 125;
            // 
            // Column2
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 6;
            CreatedColumn.Name = "Column2";
            CreatedColumn.Width = 125;
            // 
            // Column3
            // 
            OrderStatusColumn.HeaderText = "Order Status";
            OrderStatusColumn.MinimumWidth = 6;
            OrderStatusColumn.Name = "Column3";
            OrderStatusColumn.Width = 125;
            // 
            // Column4
            // 
            FullNameColumn.HeaderText = "Customer Full name";
            FullNameColumn.MinimumWidth = 6;
            FullNameColumn.Name = "Column4";
            FullNameColumn.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AmountCost);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(OrderItemsListBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(AddressControl);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(StatusComboBox);
            groupBox2.Controls.Add(CreatedTextBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(IdTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(417, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 790);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // textBox1
            // 
            IdTextBox.Location = new Point(82, 33);
            IdTextBox.Name = "textBox1";
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Created:";
            // 
            // textBox2
            // 
            CreatedTextBox.Location = new Point(82, 66);
            CreatedTextBox.Name = "textBox2";
            CreatedTextBox.Size = new Size(151, 27);
            CreatedTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(82, 99);
            StatusComboBox.Name = "comboBox1";
            StatusComboBox.Size = new Size(151, 28);
            StatusComboBox.TabIndex = 4;
            StatusComboBox.SelectedIndexChanged += StatusCombobox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 102);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Status:";
            // 
            // addressControl1
            // 
            address2.Apartment = " ";
            address2.Building = " ";
            address2.City = " ";
            address2.Country = " ";
            address2.Index = 100000;
            address2.Street = " ";
            AddressControl.Address = address2;
            AddressControl.Location = new Point(6, 149);
            AddressControl.Name = "addressControl1";
            AddressControl.Size = new Size(676, 292);
            AddressControl.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 444);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Order Items";
            // 
            // listBox1
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.Location = new Point(6, 467);
            OrderItemsListBox.Name = "listBox1";
            OrderItemsListBox.Size = new Size(461, 104);
            OrderItemsListBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 586);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "Amount:";
            // 
            // label6
            // 
            AmountCost.AutoSize = true;
            AmountCost.Location = new Point(450, 618);
            AmountCost.Name = "label6";
            AmountCost.Size = new Size(17, 20);
            AmountCost.TabIndex = 10;
            AmountCost.Text = "0";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OrdersTab";
            Size = new Size(890, 793);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView OrdersDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn OrderStatusColumn;
        private DataGridViewTextBoxColumn FullNameColumn;
        private Label label4;
        private Controls.AddressControl AddressControl;
        private Label label3;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private Label label2;
        private TextBox IdTextBox;
        private Label label1;
        private Label AmountCost;
        private Label label5;
        private ListBox OrderItemsListBox;
    }
}
