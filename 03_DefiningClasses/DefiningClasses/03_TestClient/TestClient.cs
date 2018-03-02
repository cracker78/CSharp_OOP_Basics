using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

public class TestClient
{
    static void Main()
    {
        string commandInput = Console.ReadLine();

        Dictionary<int, BankAccount> accounts=new Dictionary<int, BankAccount>();

        while (commandInput != "End")
        {

            string[] commandArg = commandInput.Split().ToArray();
            string command = commandArg[0];

            switch (command)
            {
                case "Create":
                    Create(commandArg, accounts);
                    break;
                case "Deposit":
                    Deposit(commandArg, accounts);
                    break;
                case "Withdraw":
                    Withdraw(commandArg, accounts);
                    break;
                case "Print":
                    Print(commandArg, accounts);
                    break;

            }

            commandInput = Console.ReadLine();
        }
    }

    private static void Print(string[] commandArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commandArg[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
           

        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] commandArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commandArg[1]);
        decimal ammount = decimal.Parse(commandArg[2]);
        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance<ammount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(ammount);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] commandArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commandArg[1]);
        decimal ammount = decimal.Parse(commandArg[2]);

        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(ammount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] commandArg, Dictionary<int, BankAccount> accounts)
    {
        int id = int.Parse(commandArg[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            BankAccount acc = new BankAccount();
            acc.Id = id;
            accounts.Add(id, acc);
        }
    }
}

