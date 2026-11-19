using Lab2.Task1;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var b = new AccessBase();
var d = new AccessDerived();

Console.WriteLine("=== Клієнт (та сама збірка) ===");
Console.WriteLine($"public             : {b.PublicField}");
Console.WriteLine($"internal           : {b.InternalField}");
Console.WriteLine($"protected internal : {b.ProtectedInternalField}");

// Console.WriteLine(b.PrivateField);
// Console.WriteLine(b.ProtectedField);
// Console.WriteLine(b.PrivateProtectedField);

Console.WriteLine("=== Метод базового класу ===");
Console.WriteLine(b.ReadAllFromBase());
Console.WriteLine("=== Метод похідного класу ===");
Console.WriteLine(d.ReadFromDerived());
