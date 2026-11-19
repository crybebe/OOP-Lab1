namespace Task4;

// Версія Б: приватні поля + властивості з валідацією
public class ProductB
{
    private string _name = "Unnamed";
    private int _quantity;
    private decimal _price;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Назва не може бути порожньою.", nameof(value));
            _name = value.Trim();
        }
    }

    public int Quantity
    {
        get => _quantity;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Кількість не може бути від’ємною.");
            _quantity = value;
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Ціна не може бути від’ємною.");
            _price = value;
        }
    }

    public decimal Total() => _quantity * _price;
}
