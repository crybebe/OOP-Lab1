namespace Task4;

// Версія А: публічні поля, без перевірок
public class ProductA
{
    public string Name = "";
    public int Quantity;
    public decimal Price;

    public decimal Total() => Quantity * Price;
}
