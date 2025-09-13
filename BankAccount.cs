class BankAccount
{
    public string Owner;
    public string AccountNumber;
    public decimal Balance;
    public string AccountType;
    public BankAccount(string Owner, string AccountNumber, decimal Balance, string AccountType)
    {
        this.Owner = Owner;
        this.AccountNumber = AccountNumber;
        this.Balance = Balance;
        this.AccountType = AccountType;
    }
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"{Owner} пополнил счёт на {amount}. Новый баланс: {Balance}");
    }
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{Owner} снял {amount}. Остаток: {Balance}");
        }
        else
        {
            Console.WriteLine($"{Owner} пытался снять {amount}, но недостаточно средств! Баланс: {Balance}");
        }
    }
    public void TransferTo(BankAccount target, decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            target.Balance += amount;
            Console.WriteLine($"Перевод: {amount} от {Owner} к {target.Owner}. Баланс: {Owner} – {Balance}, {target.Owner} – {target.Balance}");
        }
        else
        {
            Console.WriteLine($"{Owner} не может перевести {amount}, недостаточно средств.");
        }
    }
    public void PrintStatement()
    {
        Console.WriteLine($"Владелец: {Owner}, Счёт: {AccountNumber}, Тип: {AccountType}, Баланс: {Balance}");
    }
}
