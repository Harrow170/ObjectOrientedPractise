//using ObjectOrientedPractise.Services;

using ObjectOrientedPractise.Model;

/// <summary>
/// Хранит данные о покупателях.
/// </summary>
public class Customer
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
    public Address Address { get; set;}

    /// <summary>
    /// Уникальное поле с корзиной доставки для покупателя.
    /// </summary>
    public Cart Cart { get; set;}

    /// <summary>
    /// Список заказов.
    /// </summary>
    public List<Order> _orders;

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
    /// Возвращает идентификатор.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }

    /// <summary>
    /// Возвращает или меняет список заказов.
    /// </summary>
    public List<Order> Orders
    {
        get
        {
            return _orders;
        }
        set
        {
            _orders = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullName">Полное имя покупателя. Должно состоять только из
    ///букв.</param>
    /// <param name="address">Адрес доставки. Должен состоять только из
    ///букв.</param>
    public Customer(string fullname)
    {
        _id = IdGenerator.GetNextId();
        FullName = fullname;
        Address = new Address();
        Cart = new Cart();
        Orders = new List<Order>();
    }

    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>
    public Customer()
    {
        _id = IdGenerator.GetNextId();
        FullName = string.Empty;
        Address = new Address();
        Cart = new Cart();
        Orders = new List<Order>();
    }
}
