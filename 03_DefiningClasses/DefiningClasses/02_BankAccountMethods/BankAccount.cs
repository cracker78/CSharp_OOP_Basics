using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    private int id;
    private decimal balance;
    private decimal deposit;
    private decimal withdraw;

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        this.Balance -= amount;
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }


    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public override string ToString()
    {
        return $"Account {this.Id}, balance {this.Balance}";
    }
}

