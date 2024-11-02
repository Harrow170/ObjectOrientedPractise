using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractise.View.Controls
{
    /// <summary>
    /// Пользовательский элемент управления, представляющий адрес с полями для ввода и отображения.
    /// Позволяет управлять данными адреса и обновлять их отображение на основе ввода пользователя.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Поле, которое хранит адресс.
        /// </summary>
        Address _address;

        /// <summary>
        /// Флаг для корректного обновления полей адреса.
        /// </summary>
        public bool IsUpdatingFieldFlag = false;

        /// <summary>
        /// Хранит данные нового адресса.
        /// </summary>
        public AddressControl NewAddress;

        /// <summary>
        /// Возвращает и задает объект <see cref="Address"/>.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }



        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>
        /// и устанавливает начальное значение для <see cref="Address"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }
        /// <summary>
        /// Updates information in TextBoxes.
        /// </summary>
        public void SelelctedTextBoxs()
        {
            postIndextextBox.Text = Address.Index.ToString();
            countryTextBox.Text = Address.Country.ToString();
            cityTextBox.Text = Address.City.ToString();
            streetTextBox.Text = Address.Street.ToString();
            buildingTextBox.Text = Address.Building.ToString();
            apartmentTextBox.Text = Address.Apartment.ToString();
        }

        private void postIndextextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(postIndextextBox.Text, out int index) || index < 100000 || index > 999999)
            {
                postIndextextBox.BackColor = Color.Blue;
                return;
            }

            try
            {
                postIndextextBox.BackColor = Color.White;
                NewAddress.Address.Index = index;
            }
            catch (ArgumentException error)
            {
                postIndextextBox.BackColor = Color.Red;
            }
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag ==  false)
            {
                try
                {
                    countryTextBox.BackColor = Color.White;
                    NewAddress.Address.Country = countryTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    countryTextBox.BackColor = Color.Red;
                }
            }
        }

        private void cityTextBox_TextChanged(Object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    cityTextBox.BackColor = Color.White;
                    NewAddress.Address.City = cityTextBox.Text;
                }
                catch ( ArgumentException error)
                {
                    cityTextBox.BackColor = Color.Red;
                }
            }
        }

        private void streetTextBox_TextChanged(Object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    streetTextBox.BackColor = Color.White;
                    NewAddress.Address.Street = streetTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    streetTextBox.BackColor = Color.Red;
                }
            }
            
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    buildingTextBox.BackColor = Color.White;
                    NewAddress.Address.Building = buildingTextBox.Text;
                }
                catch ( ArgumentException error)
                {
                    buildingTextBox.BackColor = Color.Red;
                }
            }
        }

        private void apartmentTextBox_TextChanged( object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    apartmentTextBox.BackColor = Color.White;
                    NewAddress.Address.Apartment = apartmentTextBox.Text;
                }
                catch( ArgumentException error)
                {
                    apartmentTextBox.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Очистка текстовых полей.
        /// </summary>
        public void ClearTextBox()
        {
            postIndextextBox.Clear();
            countryTextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            buildingTextBox.Clear();
            apartmentTextBox.Clear();
            postIndextextBox.BackColor = Color.White;
        }

        /// <summary>
        /// При выборе обьекта в листбокс показывает текстбоксы <see cref="Address"/>.
        /// </summary>
        public void UpdateData(Address Address)
        {
            NewAddress.Address = Address;
            postIndextextBox.Text = NewAddress.Address.Index.ToString();
            countryTextBox.Text = NewAddress.Address.Country.ToString();
            cityTextBox.Text = NewAddress.Address.City.ToString();
            streetTextBox.Text = NewAddress.Address.Street.ToString();
            buildingTextBox.Text = NewAddress.Address.Building.ToString();
            apartmentTextBox.Text = NewAddress .Address.Apartment.ToString();
        }

        /// <summary>
        /// Инициализируем обьект адресс на основе текущих значениях TextBox/
        /// </summary>
        public Address Givevalues()
        {
            return new Address(int.Parse(postIndextextBox.Text), countryTextBox.Text, cityTextBox.Text, streetTextBox.Text, buildingTextBox.Text, apartmentTextBox.Text);
        }

        public bool AddressIsNullOrempty()
        {
            if (string.IsNullOrEmpty(postIndextextBox.Text) ||
                string.IsNullOrEmpty(countryTextBox.Text) ||
                string.IsNullOrEmpty(cityTextBox.Text) ||
                string.IsNullOrEmpty(streetTextBox.Text) ||
                string.IsNullOrEmpty(buildingTextBox.Text) ||
                string.IsNullOrEmpty(apartmentTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {
            NewAddress = new AddressControl();
        }

        private void postIdexTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(postIndextextBox.Text, out int postIndexValue))
            {
                try
                {
                    ValueValidator.AssertNumberOnValue(postIndexValue, 100000, 999999, "PostIndex");
                    postIndextextBox.BackColor = System.Drawing.Color.White;
                }
                catch (ArgumentException ex)
                {
                    postIndextextBox.BackColor = System.Drawing.Color.Red;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                postIndextextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Пожалуйста, введите корректное числовое значение для индекса");
            }
        }

        private void countryTextBox_Leave(Object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(countryTextBox.Text, 50, "Country");
                countryTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                countryTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(cityTextBox.Text, 50, "City");
                cityTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                cityTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void streetTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(streetTextBox.Text, 100, "Street");
                streetTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                streetTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void buildingTextBox_Leave(Object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(buildingTextBox.Text, 10, "Building");
                buildingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                buildingTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void apartmentTextBox_Leave(object obj, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(apartmentTextBox.Text, 10, "Apartment");
                apartmentTextBox.BackColor = System.Drawing.Color.White;
            }
            catch ( ArgumentException ex)
            {
                apartmentTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }
    }
}
