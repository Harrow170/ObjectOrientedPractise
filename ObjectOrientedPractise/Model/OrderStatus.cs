/// <summary>
/// Перечисление, представляющее статус заказа.
/// </summary>
public enum OrderStatus
{
    New,
    Processing,
    Assembly,
    Sent,
    Delivered,
    returned,
    Abandoned
}