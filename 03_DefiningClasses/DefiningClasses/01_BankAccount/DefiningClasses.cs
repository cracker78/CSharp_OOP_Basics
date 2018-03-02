using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

class DefiningClasses
{
    static void Main()
    {
        BankAccount acc=new BankAccount();

        acc.Id = 1;
        acc.Balance = 15;

        Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
    }
}


