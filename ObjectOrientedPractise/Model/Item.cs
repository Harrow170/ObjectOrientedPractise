//using ObjectOrientedPractise.Services;

using System.ComponentModel;

/// <summary>
/// Хранит данные о товаре.
/// </summary>
public class Item
{
    /// <summary>
    /// Уникальный идентификатор для всех объектов данного класса.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Уникальное имя товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Информация о товаре.
    /// </summary>
    private string _info;

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private double _cost;

    /// <summary>
    /// Категория товара.
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Возвращает отображение товара в меню.
    /// </summary>
    public string Display
    {
        get
        {
            return $"ID: {_id}, Name: {_name}, Cost: {_cost}";
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
    /// Возвращает и задает название предмета(товара).
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(value));
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задает информацию о товаре.
    /// </summary>
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 1000, nameof(value));
            _info = value;
        }
    }

    /// <summary>
    /// Возвращает и задает стоимость товара.
    /// </summary>
    public double Cost
    {
        get
        {
            return _cost;
        }
        set
        {
            if (!IsCostValid(value))
            {
                throw new ArgumentException($"{value} должно быть большк чeм 0 и меньше 100000");
            }
            _cost = value;
        }
    }

    /// <summary>
    /// Проверяет, находится ли стоимость в допустимых пределах (больше 0 и меньше 100000).
    /// </summary>
    /// <param name="value">Стоимость для проверки.</param>
    /// <returns>True, если стоимость допустима; иначе False.</returns>
    public bool IsCostValid(double value)
    {
        return value > 0.0 && value < 100000;
    }

    /// <summary>
    /// Переменная класса, хранящего метод валидации строк
    /// </summary> 
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    /// <param name="name">Имя Должно состоять только из
    ///букв.</param>
    /// <param name="info">Информация. Должна состоять только из
    ///букв.</param>
    /// <param name="cost">Стоимость. Должна быть вещественным числом.
    /// </param>
    /// <param name ="category"> Rатегория. Является перечислением Category. </param>
    public Item(string name, string info, double cost, Category category)
    {
        _id = IdGenerator.GetNextId();

        Name = name;

        Info = info;

        Cost = cost;

        Category = category;
    }

    public Item()
    {

    }
}