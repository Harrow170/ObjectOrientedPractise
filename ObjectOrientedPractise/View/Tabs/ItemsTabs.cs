using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractise.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы со списком товаров.
    /// Позволяет добавлять, удалять и отображать товары.
    /// </summary>
    public partial class ItemsTabs : UserControl
    {
        private List<Item> _items = new List<Item>();

        public ItemsTabs()
        {
            InitializeComponent();
            IDfield.ReadOnly = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string info = descriptionField.Text;
            double cost = double.Parse(costField.Text);
            Item newItem = new Item(name, info, cost);
            _items.Add(newItem);
            UpdateListBox();
            ClearFields();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item selectedItem)
            {
                _items.Remove(selectedItem);
                UpdateListBox();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Выберите тoвар для удаления:");
            }
        }

        private void ItemsListBox_SelectedIdexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item selectedItem)
            {
                IDfield.Text = selectedItem.Id.ToString();
                nameField.Text = selectedItem.Name;
                descriptionField.Text = selectedItem.Info;
                costField.Text = selectedItem.Cost.ToString();
            }
        }

        private void UpdateListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Display";
        }

        private void ClearFields()
        {
            IDfield.Clear();
            nameField.Clear();
            descriptionField.Clear();
            costField.Clear();
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            ValidateName();
        }

        private void descriptionField_Leave(Object sender, EventArgs e)
        {
            ValidateInfo();
        }

        private void costField_Leave(object sender, EventArgs e)
        {
            ValidateCost();
        }

        private void ValidateName()
        {
            try
            {
                ValueValidator.AssertStringOnLength(nameField.Text, 200, nameof(nameField));
                nameField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                nameField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidateInfo()
        {
            try
            {
                ValueValidator.AssertStringOnLength(descriptionField.Text, 1000, nameof(descriptionField));
                descriptionField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                descriptionField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidateCost()
        {
            try
            {
                double costValue;
                if (!double.TryParse(costField.Text, out costValue) || !IsCostValid(costValue))
                {
                    throw new ArgumentException("Стоимость должна быть больше 0 и меньше 100000.");
                }
                costField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                costField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsCostValid(double value)
        {
            return value > 0.0 && value < 100000;
        }
    }
}
