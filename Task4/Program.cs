using Task4;

Console.OutputEncoding = System.Text.Encoding.UTF8;

static void Try(string title, Action action)
{
    try { action(); }
    catch (Exception ex) { Console.WriteLine($"{title} -> {ex.GetType().Name}"); }
}

Console.WriteLine("=== Версія А (публічні поля) ===");
var a = new ProductA();
a.Name = "";
a.Quantity = -5;
a.Price = 100;
Console.WriteLine($"Name = '{a.Name}', Quantity = {a.Quantity}, Price = {a.Price}");
Console.WriteLine($"Total = {a.Total()}");

Console.WriteLine("=== Версія Б (властивості) ===");
var b = new ProductB();
Try("Name = ''", () => b.Name = "");
Try("Quantity = -5", () => b.Quantity = -5);
Try("Price = -100", () => b.Price = -100);
b.Name = "Ноутбук";
b.Quantity = 3;
b.Price = 100;
Console.WriteLine($"Name = '{b.Name}', Quantity = {b.Quantity}, Price = {b.Price}");
Console.WriteLine($"Total = {b.Total()}");
