using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreinodeExeception.Modelos.Exceptions;
using System.Threading.Tasks;

namespace TreinodeExeception.Modelos
{
    internal class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {




            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposito(double amount)
        {
            Balance += amount;
           
        }
        public void Withdraw(double amount)
        {

            if (Balance == 0) { throw new DomainException("Você não possui valor para retirar"); }
            if (amount > WithdrawLimit && amount >Balance ) { throw new DomainException("Seu saque é maior do que o saque limite e maior do seu saldo "); }
            if (amount > WithdrawLimit) { throw new DomainException("Seu saque é maior do seu limite"); }
            if (amount > Balance) { throw new DomainException("Seu saque é maior do seu saldo"); }
            else { Balance -= amount; }

        }


        public override string ToString()
        {
            return "Seu saldo " + Balance;
        }
    }



}
