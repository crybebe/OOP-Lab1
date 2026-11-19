using Task2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

static void Run(string title, Action action)
{
    try { action(); Console.WriteLine($"[OK]       {title}"); }
    catch (Exception ex)
    { Console.WriteLine($"[ВИНЯТОК]  {title} -> {ex.GetType().Name}"); }
}

var acc = new BankAccount("UA123456", "Іван Петренко", 100m);

Run("С1 Коректне створення", () => new BankAccount("UA000001", "Олена", 0));
Run("С2 Deposit(50)", () => acc.Deposit(50));
Console.WriteLine($"           Баланс: {acc.Balance}");
Run("С3 Withdraw(30)", () => acc.Withdraw(30));
Console.WriteLine($"           Баланс: {acc.Balance}");
Run("С4 Невірний Id", () => new BankAccount("12345", "Олена"));
Run("С5 Порожнє ім’я", () => new BankAccount("UA000002", "   "));
Run("С6 Від’ємний початковий залишок", () => new BankAccount("UA000003", "Олена", -1));
Run("С7 Deposit(-10)", () => acc.Deposit(-10));
Run("С8 Withdraw(1000)", () => acc.Withdraw(1000));
Console.WriteLine($"С9 TryWithdraw(1000): {acc.TryWithdraw(1000)}");
Console.WriteLine($"Баланс після невдалих операцій: {acc.Balance}");

// acc.Balance = 1_000_000;   // CS0200
// acc.Id = "UA999999";       // CS0200
// acc._balance = -5;         // CS0122
