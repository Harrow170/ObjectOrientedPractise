using System.Runtime.InteropServices.Marshalling;

/// <summary>
/// Класс, представляющий заказ.
/// </summary>
public class Order
{
    /// <summary>
    /// Уникальный идентификатор заказа.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Дата и время изменения статуса заказа.
    /// </summary>
    private readonly DateTime _date = DateTime.Now;

    /// <summary>
    /// Адрес доставки заказа.
    /// </summary>
    public Address _address;

    /// <summary>
    /// Список товаров в заказе.
    /// </summary>
    public List<Item> _items;

    /// <summary>
    /// Получает уникальный идентификатор заказа.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }

    /// <summary>
    /// Получает дату и время создания заказа.
    /// </summary>
    public DateTime Date
    {
        get
        {
            return _date;
        }
    }

    /// <summary>
    /// Получает или задает адрес доставки заказа.
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
    /// Получает или задает список товаров в заказе.
    /// </summary>
    public List<Item> Items
    {
        get
        {
            return _items;
        }
        set
        {
            _items = value;
        }
    }

    public OrderStatus Status { get; set; } = OrderStatus.New;

    /// <summary>
    /// Получает общую сумму заказа.
    /// </summary>
    public double Amount
    {
        get
        {
            double sum = 0.0;
            Items.ForEach(x => { sum += x.Cost; });
            return Math.Round(sum, 2);
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр заказа.
    /// </summary>
    /// <param name="id">Идентификатор заказа.</param>
    /// <param name="createdAt">Дата создания.</param>
    /// <param name="status">Статус заказа.</param>
    /// <param name="address">Адрес доставки.</param>
    /// <param name="items">Список товаров в заказе.</param>
    public Order(Address address, List<Item> items)
    {
        _id = IdGenerator.GetNextId();
        Status = new OrderStatus();
        Address = address;
        _date = DateTime.Now;
        foreach (Item item in items)
        {
            Items.Add(item);
        }
    }

    /// <summary>
    /// Creates a sample of a class <see cref="Order"/>.
    /// </summary>
    public Order()
    {
        _id = IdGenerator.GetNextId();
        _date = DateTime.Now;
        Status = new OrderStatus();
        Items = new List<Item>();
    }
}
