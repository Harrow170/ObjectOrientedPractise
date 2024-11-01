namespace ObjectOrientedPractise.View.Controls
{
    partial class AddressControl
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
            apartmentTextBox = new TextBox();
            buildingTextBox = new TextBox();
            streetTextBox = new TextBox();
            cityTextBox = new TextBox();
            countryTextBox = new TextBox();
            postIndextextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(apartmentTextBox);
            groupBox1.Controls.Add(buildingTextBox);
            groupBox1.Controls.Add(streetTextBox);
            groupBox1.Controls.Add(cityTextBox);
            groupBox1.Controls.Add(countryTextBox);
            groupBox1.Controls.Add(postIndextextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delivery Address";
            // 
            // textBox6
            // 
            apartmentTextBox.Location = new Point(362, 181);
            apartmentTextBox.Name = "textBox6";
            apartmentTextBox.Size = new Size(172, 27);
            apartmentTextBox.TabIndex = 11;
            // 
            // textBox5
            // 
            buildingTextBox.Location = new Point(91, 181);
            buildingTextBox.Name = "textBox5";
            buildingTextBox.Size = new Size(176, 27);
            buildingTextBox.TabIndex = 10;
            // 
            // textBox4
            // 
            streetTextBox.Location = new Point(91, 127);
            streetTextBox.Name = "textBox4";
            streetTextBox.Size = new Size(443, 27);
            streetTextBox.TabIndex = 9;
            // 
            // textBox3
            // 
            cityTextBox.Location = new Point(316, 85);
            cityTextBox.Name = "textBox3";
            cityTextBox.Size = new Size(218, 27);
            cityTextBox.TabIndex = 8;
            // 
            // textBox2
            // 
            countryTextBox.Location = new Point(91, 85);
            countryTextBox.Name = "textBox2";
            countryTextBox.Size = new Size(176, 27);
            countryTextBox.TabIndex = 7;
            // 
            // textBox1
            // 
            postIndextextBox.Location = new Point(91, 40);
            postIndextextBox.Name = "textBox1";
            postIndextextBox.Size = new Size(125, 27);
            postIndextextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 184);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 5;
            label6.Text = "Apartment:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 184);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Building:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 130);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Street:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 88);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 88);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Country:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "AddressControl";
            Size = new Size(541, 234);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox apartmentTextBox;
        private TextBox buildingTextBox;
        private TextBox streetTextBox;
        private TextBox cityTextBox;
        private TextBox countryTextBox;
        private TextBox postIndextextBox;
        private Label label6;
        private Label label5;
    }
}
