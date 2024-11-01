using ObjectOrientedPractise.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractise.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список элементов класса <see cref="Customer"/>
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Данные о текущем клиенте
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список строк для отображения в списке клиентов.
        /// </summary>
        private List<string> CustomersListBoxItems = new List<string>();

        public CustomersTab()
        {
            InitializeComponent();
            IdTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Получает или задает список клиентов.
        /// При установке значения добавляет клиентов в ListBox.
        /// </summary>
        /// <value>Список объектов <see cref="Customer"/>, представляющий клиентов.</value>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                _customers = value;
                CustomersListBox.Items.AddRange(value.ToArray());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(FullNameTextBox.Text) || addressControl1.AddressIsNullOrempty())
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (ValueValidator.IsNumeric(FullNameTextBox.Text))
            {
                MessageBox.Show("FullName должен состоять из букв");
                return;
            }

            Customer NewCustomer = new Customer();
            NewCustomer.FullName = FullNameTextBox.Text;
            NewCustomer.Address = addressControl1.Givevalues();

            Customers.Add(NewCustomer);
            CustomersListBoxItems.Add($"ID: {NewCustomer.Id}, Name: {NewCustomer.FullName}");
            CustomersListBox.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);

            ClearInfo();
        }

        /// <summary>
        /// Очищает все текстовые поля и сбрасывает цвет фона.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            addressControl1.ClearTextBox();
            FullNameTextBox.BackColor = Color.White;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
                _currentCustomer = null;
                ClearInfo();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || CustomersListBox.Items.Count == 0)
            {
                addressControl1.IsUpdatingFieldFlag = true;
                Add.Enabled = true;
                ClearInfo();
            }
            else
            {
                addressControl1.IsUpdatingFieldFlag = false;
                Add.Enabled = false;
                int selectedIndex = CustomersListBox.SelectedIndex;
                if (selectedIndex == -1) return;
                _currentCustomer = Customers[selectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;

                addressControl1.UpdateData(_currentCustomer.Address);

            }
        }

        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
                addressControl1.IsUpdatingFieldFlag = false;
                CustomersListBox.ClearSelected();
                ClearInfo();
            }
        }
    }
}
