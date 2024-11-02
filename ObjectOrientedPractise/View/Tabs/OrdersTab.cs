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
    /// <summary>
    /// Представляет вкладку управления заказами.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список клиентов.
        /// </summary>
        public List<Customer> _customers;

        /// <summary>
        /// выбор индексаt.
        /// </summary>
        private int _selectedOrderIndex;

        /// <summary>
        ///список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// выбранный заказ.
        /// </summary>
        private Order _selectedOrder = new Order();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        
        /// <summary>
        /// Получает или задает список клиентов.
        /// При установке значения вызывает метод обновления заказов.
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
                if (value == null) return;
                _customers = value;
                UpdateOrders();
            }
        }
        public OrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновление данных на вкладке.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrders();
            UpdateComboBox();
        }

        /// <summary>
        /// обновляет заказы в таблице.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();
            OrdersDataGridView.Rows.Clear();
            foreach (var customer in Customers)
            {
                var address = $"{customer.Address.Country}, {customer.Address.City}";
                address += $"{customer.Address.Street}, {customer.Address.Building}";
                address += $"{customer.Address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id, order.Date, order.Status, /*order.FullName,*/ order.Amount);
                }
            }
        }

        private void UpdateComboBox()
        {
            StatusComboBox.Items.Clear();
            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
        }

        private void OrderItemsListBox_Add()
        {
            OrderItemsListBox.Items.Clear();
            foreach (Item item in _orders[_selectedOrderIndex].Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
        }

        private void OrdersDataGridView_SelectionChanged()
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                _selectedOrderIndex = OrdersDataGridView.SelectedRows[0].Index;
                _selectedOrder = _orders[_selectedOrderIndex];
                AddressControl.Address = _orders[_selectedOrderIndex].Address;
                //AddressControl.SelectedTextBoxs();
                IdTextBox.Text = _selectedOrder.Id.ToString();
                CreatedTextBox.Text = _selectedOrder.Date.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.Status;
                AmountCost.Text = _selectedOrder.Amount.ToString();
                OrderItemsListBox_Add();
            }
        }

        private void StatusCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ourStatus = StatusComboBox.Text;
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), ourStatus);
                _selectedOrder.Status = orderStatus;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
