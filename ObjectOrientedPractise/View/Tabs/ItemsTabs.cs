﻿using System;
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
    /// Элемент управления для работы со списком товаров.
    /// Позволяет добавлять, удалять и отображать товары.
    /// </summary>
    public partial class ItemsTabs : UserControl
    {
        private List<Item> _items = new List<Item>();

        private Item _currentItem;

        private List<string> ItemsListBoxItems = new List<string>();

        public ItemsTabs()
        {
            InitializeComponent();
            IDfield.ReadOnly = true;
            comboBoxCategories.DataSource = Enum.GetValues(typeof(Category));
            comboBoxCategories.SelectedIndex = -1;

            nameField.Leave += nameField_Leave;
            descriptionField.Leave += descriptionField_Leave;
            costField.Leave += costField_Leave;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIdexChanged;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
        }

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                _items = value;
                ItemsListBox.Items.AddRange(value.ToArray());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string info = descriptionField.Text;
            Category category = (Category)comboBoxCategories.SelectedItem;
            Item newItem = new Item(name, info, double.Parse(costField.Text), category);
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
                comboBoxCategories.SelectedItem = selectedItem.Category;
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
            comboBoxCategories.SelectedIndex = -1;
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

        /// <summary>
        /// Проверяет корректность введенного имени товара.
        /// </summary>
        private void ValidateName()
        {
            try
            {
                ValueValidator.AssertStringOnLength(nameField.Text, 200, "Name");
                nameField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                nameField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Проверяет корректность введенной информации о товаре(описании).
        /// </summary>
        private void ValidateInfo()
        {
            try
            {
                ValueValidator.AssertStringOnLength(descriptionField.Text, 1000, "Description");
                descriptionField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                descriptionField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Проверяет корректность введенной стоимости товара.
        /// </summary>
        private void ValidateCost()
        {
           if (double.TryParse(costField.Text, out double costValue))
            {
                try
                {
                    ValueValidator.AssertNumberOnValue(costValue, 0, 100000, "Cost");
                    costField.BackColor = System.Drawing.Color.White;
                }
                catch (ArgumentException ex)
                {
                    costField.BackColor= System.Drawing.Color.Red;
                    MessageBox.Show(ex.Message);
                }
            }
           else
            {
                costField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Пожалуйста, введите корректное числовое значение для стоимости.");
            }
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item selectedItem && comboBoxCategories.SelectedItem is Category selectedCategory)
            {
                selectedItem.Category = selectedCategory;
            }
        }

        private void ItemsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ItemsListBox.IndexFromPoint(e.Location) == -1)
            {
                ItemsListBox.ClearSelected();
                ItemsListBox.SelectedIndex = -1;
            }
        }
    }
}
