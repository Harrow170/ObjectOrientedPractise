namespace ObjectOrientedPractise.View.Tabs
{
    partial class CustomersTab
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
            Address address1 = new Address();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            CustomersListBox = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Add = new Button();
            Remove = new Button();
            groupBox2 = new GroupBox();
            addressControl1 = new Controls.AddressControl();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(818, 776);
            splitContainer1.SplitterDistance = 271;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CustomersListBox);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 776);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(6, 26);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(239, 604);
            CustomersListBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Add, 0, 0);
            tableLayoutPanel1.Controls.Add(Remove, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 697);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(265, 76);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Add
            // 
            Add.Dock = DockStyle.Fill;
            Add.Location = new Point(3, 3);
            Add.Name = "Add";
            Add.Size = new Size(126, 70);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.Dock = DockStyle.Fill;
            Remove.Location = new Point(135, 3);
            Remove.Name = "Remove";
            Remove.Size = new Size(127, 70);
            Remove.TabIndex = 1;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(addressControl1);
            groupBox2.Controls.Add(FullNameTextBox);
            groupBox2.Controls.Add(IdTextBox);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(543, 776);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected_Customer";
            // 
            // addressControl1
            // 
            address1.Apartment = " ";
            address1.Building = " ";
            address1.City = " ";
            address1.Country = " ";
            address1.Index = 100000;
            address1.Street = " ";
            addressControl1.Address = address1;
            addressControl1.Location = new Point(-4, 157);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(676, 292);
            addressControl1.TabIndex = 5;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(101, 94);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(393, 27);
            FullNameTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(101, 33);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(127, 27);
            IdTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Full name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomersTab";
            Size = new Size(818, 776);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ListBox CustomersListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Add;
        private Button Remove;
        private GroupBox groupBox2;
        private TextBox FullNameTextBox;
        private TextBox IdTextBox;
        private Label label2;
        private Label label1;
        private Controls.AddressControl addressControl1;
    }
}
