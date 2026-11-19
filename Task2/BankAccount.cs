using System.Text.RegularExpressions;

namespace Task2;

public class BankAccount
{
    private string _owner = string.Empty;
    private decimal _balance;

    public string Id { get; }                       // лише для читання

    public string Owner                              // з валідацією
    {
        get => _owner;
        set
        {
            ValidateOwner(value);
            _owner = value.Trim();
        }
    }

    public decimal Balance => _balance;             // лише для читання

    public BankAccount(string id, string owner, decimal initialBalance = 0m)
    {
        if (id is null || !Regex.IsMatch(id, @"^UA\d{6}$"))
            throw new ArgumentException("Ідентифікатор: UA + 6 цифр.", nameof(id));
        if (initialBalance < 0)
            throw new ArgumentOutOfRangeException(nameof(initialBalance),
                "Початковий залишок не може бути від’ємним.");

        Id = id;
        Owner = owner;                               // проходить через валідацію
        _balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        ValidateAmount(amount);
        decimal old = _balance;
        _balance += amount;
        OnBalanceChanged(old);
    }

    public void Withdraw(decimal amount)
    {
        ValidateAmount(amount);
        if (amount > _balance)
            throw new InvalidOperationException("Недостатньо коштів на рахунку.");
        decimal old = _balance;
        _balance -= amount;
        OnBalanceChanged(old);
    }

    public bool TryWithdraw(decimal amount)
    {
        if (amount <= 0 || amount > _balance) return false;
        Withdraw(amount);
        return true;
    }

    internal string ToAuditString() => $"{Id}|{Owner}|{_balance}";

    protected virtual void OnBalanceChanged(decimal oldBalance) { }

    private static void ValidateAmount(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Сума має бути додатною.");
    }

    private static void ValidateOwner(string? owner)
    {
        if (string.IsNullOrWhiteSpace(owner) || owner.Trim().Length > 50)
            throw new ArgumentException("Ім’я: 1–50 символів, не лише пробіли.", nameof(owner));
    }
}
