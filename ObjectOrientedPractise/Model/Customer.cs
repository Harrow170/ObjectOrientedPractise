//using ObjectOrientedPractise.Services;

/// <summary>
/// Хранит данные о покупателях.
/// </summary>
class Customer
{
    /// <summary>
    /// Уникальный идентификвтор для всех объектов данного класса
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Уникальное имя покупателя(customer).
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Уникальное поле с адресом доставки для покупателя.
    /// </summary>
    private string _address;

    /// <summary>
    /// Возвращает и задает полное имя покупателя.
    /// </summary>
    public string FullName
    {
        get
        {
            return _fullname;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(value));
            _fullname = value;
        }
    }

    /// <summary>
    /// Возвращает и задает адрес доставки.
    /// </summary>
    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 500, nameof(value));
            _address = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullName">Полное имя покупателя. Должно состоять только из
    ///букв.</param>
    /// <param name="adress">Адрес доставки. Должен состоять только из
    ///букв.</param>
    public Customer(string fullname, string address)
    {
        _id = IdGenerator.GetNextId();
        FullName = fullname;
        Address = address;
    }
}
