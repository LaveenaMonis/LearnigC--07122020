using System;
using System.Collections.Generic;

namespace Assignment1_BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bankCustomer;
            bankCustomer = Bank.CreateInstance(1234567890,new List<string> {"Laveena"},25);
            if(bankCustomer != null)
            {
                bankCustomer.DisplayBalance();
                Console.WriteLine(bankCustomer.Withdraw(50));
                Console.WriteLine(bankCustomer.Depoit(100));
                Console.WriteLine(bankCustomer.Withdraw(500));
                Console.WriteLine(bankCustomer.Withdraw(50));

            }
            else
            {
                Console.WriteLine("Cannot create bank object");
            }
            
        }

    }
}
