namespace Task3;

public class Employee
{
    // 1. Автовластивість з відкритими get і set
    public string Position { get; set; } = "Junior";

    // 2. Обмежений запис: змінюється лише всередині класу
    public decimal Salary { get; private set; }

    // 3. Лише get: значення задається тільки в конструкторі
    public string FirstName { get; }
    public string LastName { get; }

    // 4. Обчислювана властивість без власного сховища
    public string FullName => $"{FirstName} {LastName}";

    // 5. Init-only: лише в ініціалізаторі об’єкта / конструкторі
    public string Email { get; init; } = string.Empty;
    public DateOnly HiredAt { get; init; }

    public Employee(string firstName, string lastName, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public void RaiseSalary(decimal percent)
    {
        if (percent <= 0 || percent > 100)
            throw new ArgumentOutOfRangeException(nameof(percent));
        Salary += Salary * percent / 100m;
    }
}
