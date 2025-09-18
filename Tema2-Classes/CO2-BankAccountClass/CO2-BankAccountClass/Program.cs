using System;
class Program
{
    static void Main()
    {
        var acc = new BankAccount("BG11AAAA1234567890", 1000m);
        acc.Deposit(250.50m);
        acc.Withdraw(100m);
        Console.WriteLine(acc);
    }
}