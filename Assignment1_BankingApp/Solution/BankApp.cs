//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Assignment1_BankingApp.Solution
//{
//    class BankApp
//    {
//        public string Number {​​​​ get; }​​​​
 
//        public string Owner {​​​​ get; set; }​​​​
 
//        public decimal Balance
//        {​​​​ get
//            {​​​​
//                decimal balance = 0;

//                foreach (var item in allTransactions)
//                {​​​​
//                    balance = balance + item.Amount;
//                }​​​​
 
//                return balance;
//            }​​​​
//        }​​​​
 
//        private static long initialAccountNumber = 9170000000;

//        private List<Transaction> allTransactions = new List<Transaction>();

//        public BankApp(string name, decimal initialDeposit)
//        {​​​​
//            this.Owner = name;

//            MakeDeposits(initialDeposit, DateTime.Now, "Initial deposit");

//            Number = $"OBC-{​​​​initialAccountNumber.ToString()}​​​​";

//            initialAccountNumber++;

//        }​​​​
 
//        public string GetTransactionHistory()
//        {​​​​
 
//            StringBuilder inReader = new StringBuilder();

//            foreach (var item in allTransactions)
//            {​​​​
//                inReader.AppendLine($"Date: {​​​​item.date}​​​​ a transcation of amount : {​​​​item.Amount}​​​​ was done, reason : {​​​​item.Notes}​​​​");
//            }​​​​
 
//            return inReader.ToString();

//        }​​​​
 
//        public void MakeDeposits(decimal amount, DateTime date, string notes)
//        {​​​​
//            if (amount <= 0)
//            {​​​​
//                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
//            }​​​​
 
//            var deposit = new Transaction(amount, date, notes);
//            allTransactions.Add(deposit);

//        }​​​​
 
//        public void MakeWithdrawals(decimal amount, DateTime date, string notes)
//        {​​​​
//            if (amount <= 0)
//            {​​​​
//                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
//            }​​​​
//            if (Balance - amount < 0)
//            {​​​​
//                throw new InvalidOperationException("Not sufficient funds to withdraw");
//            }​​​​
 
//            var withdrawal = new Transaction(-amount, date, notes);
//            allTransactions.Add(withdrawal);

//        }​​​​
//    }​​​​
//}​​​​
