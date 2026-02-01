using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Pamoka5_object_programavimas
{
    internal class BankAccount
    {



        public decimal BankBalance { get; private set; }
        public string BankAccNr { get; private set; }

        public List <decimal> History { get; private set; }


        public BankAccount(decimal bankBalance, string bankAccNr)
        {
            History = new List<decimal> { };
            BankBalance = bankBalance;
            BankAccNr = bankAccNr;
        }
        

            public decimal ShowBankBalance()
        {
        
            return BankBalance;
        }

        public string ShowBankAccNr()
        {
            return BankAccNr;
        }

        public void Withdraw(decimal suma)
        {
            if (suma > BankBalance || suma <= 0)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                BankBalance -= suma;
                History.Add(-1 * suma);
                Console.WriteLine($"Amount withdrawn:{suma} bank balance: {BankBalance}");
            }
        }

        public void Deposit(decimal suma)
        {
            if (suma > 0)
            {
                BankBalance += suma;
                History.Add( suma);
                Console.WriteLine($"Amount deposit {suma}");
            }
            else {

                Console.WriteLine("Deposit amount cannot be negative.");
            
            }
        }

        public void GetStatement()
        {
            foreach (var statement in History) {
                if (statement > 0)
                {
                    Console.WriteLine($"Deposit: {statement}");
                }
                else {
                    Console.WriteLine($"Withdraw: {statement}");
                }
            }

         
        }
    }
}
