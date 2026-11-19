using Task3;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var e = new Employee("Іван", "Петренко", 1000m)
{
    Email = "ivan@example.com",          // init-only: дозволено в ініціалізаторі
    HiredAt = new DateOnly(2024, 9, 1)
};

e.Position = "Middle";                   // відкритий set
e.RaiseSalary(10);                       // зміна Salary лише через метод

Console.WriteLine($"{e.FullName} | {e.Position} | {e.Salary} | {e.Email} | {e.HiredAt:yyyy-MM-dd}");

// e.Salary = 5000m;                     // CS0272
// e.FirstName = "Петро";                // CS0200
// e.FullName = "Петро Іванов";          // CS0200
// e.Email = "new@example.com";          // CS8852
// e.HiredAt = new DateOnly(2020, 1, 1); // CS8852
