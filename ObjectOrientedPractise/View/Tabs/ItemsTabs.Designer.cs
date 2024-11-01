namespace ObjectOrientedPractise.View.Tabs
{
    partial class ItemsTabs
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Add = new Button();
            Remove = new Button();
            ItemsListBox = new ListBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            descriptionField = new TextBox();
            nameField = new TextBox();
            label3 = new Label();
            label2 = new Label();
            costField = new TextBox();
            IDfield = new TextBox();
            label1 = new Label();
            label5 = new Label();
            comboBoxCategories = new ComboBox();
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
            splitContainer1.Size = new Size(689, 735);
            splitContainer1.SplitterDistance = 229;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(ItemsListBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 735);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Add, 0, 0);
            tableLayoutPanel1.Controls.Add(Remove, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 665);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(223, 67);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Add
            // 
            Add.Dock = DockStyle.Fill;
            Add.Location = new Point(3, 3);
            Add.Name = "Add";
            Add.Size = new Size(105, 61);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.Dock = DockStyle.Fill;
            Remove.Location = new Point(114, 3);
            Remove.Name = "Remove";
            Remove.Size = new Size(106, 61);
            Remove.TabIndex = 1;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 23);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(220, 624);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIdexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxCategories);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(descriptionField);
            groupBox2.Controls.Add(nameField);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(costField);
            groupBox2.Controls.Add(IDfield);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 735);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected_Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 370);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 7;
            label4.Text = "Description:";
            // 
            // descriptionField
            // 
            descriptionField.Location = new Point(6, 393);
            descriptionField.Multiline = true;
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(444, 220);
            descriptionField.TabIndex = 6;
            // 
            // nameField
            // 
            nameField.Location = new Point(2, 217);
            nameField.Multiline = true;
            nameField.Name = "nameField";
            nameField.Size = new Size(444, 150);
            nameField.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 194);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Cost:";
            // 
            // costField
            // 
            costField.Location = new Point(77, 84);
            costField.Name = "costField";
            costField.Size = new Size(125, 27);
            costField.TabIndex = 2;
            // 
            // IDfield
            // 
            IDfield.Location = new Point(77, 32);
            IDfield.Name = "IDfield";
            IDfield.Size = new Size(125, 27);
            IDfield.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 137);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "Category:";
            // 
            // comboBox1
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(77, 134);
            comboBoxCategories.Name = "comboBox1";
            comboBoxCategories.Size = new Size(151, 28);
            comboBoxCategories.TabIndex = 9;
            // 
            // ItemsTabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ItemsTabs";
            Size = new Size(689, 735);
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
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox ItemsListBox;
        private GroupBox groupBox2;
        private Button Add;
        private Button Remove;
        private Label label4;
        private TextBox descriptionField;
        private TextBox nameField;
        private Label label3;
        private Label label2;
        private TextBox costField;
        private TextBox IDfield;
        private Label label1;
        private ComboBox comboBoxCategories;
        private Label label5;
    }
}
