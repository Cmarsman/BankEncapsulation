﻿namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            account.Deposit(100);

            var balance = account.GetBalance();
            Console.WriteLine(balance);

        }
    }
}
