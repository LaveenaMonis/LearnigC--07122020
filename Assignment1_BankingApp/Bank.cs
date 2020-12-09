using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_BankingApp
{
    //Create a Bank Account Application which has following properties, methods and rules --
    //1. It has a 10-digit number that uniquely identifies the bank account.
    //2. It has a string that stores the name or names of the owners.
    //3. The balance can be retrieved.
    //4. It accepts deposits.
    //5. It accepts withdrawals.
    //6. The initial balance must be positive.
    //7. Withdrawals cannot result in a negative balance.

    public class Bank
    {
        //private List<int> Accounts = new List<int>();
        public static List<int> Acc { get; set; }
        private int AccNum { get; set; }

        public List<string> OwnerName { get; set; }

        public double Balance { get; set; }

        private Bank(int accNum, List<string> ownerName, double amount)
        {
            AccNum = accNum;
            OwnerName = ownerName;
            Balance = amount;
           
        }
        public static Bank CreateInstance(int accNum, List<string> ownerName, double amount)
        {
            if (accNum.ToString().Length != 10 || ownerName.Count < 1 || amount < 1 )
            {
                return null;
            }

            return new Bank(accNum, ownerName, amount);
        }
             

        public string Depoit(double amount)
        {
            Balance = Balance + amount;
            return "Amount deposited successfully ! Current balance : " + Balance;
        }

        public string Withdraw(double amount)
        {
            if(Balance - amount < 0)
            {
                return "Amount cannot be withdrawn as it results in negative balance";
            }

            Balance = Balance - amount;
            return "Amount withdrawn successfully! Current balance : " + Balance;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Current Balance : " + Balance);
        }

        

    }
}
