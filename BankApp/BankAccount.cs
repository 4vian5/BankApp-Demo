using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    abstract class BankAccount
    {
        private string firstName;
        private string lastName;
        private double balance;

        protected BankAccount(string _firstName, string _lastName, double _balance)
        {
            firstName = _firstName;
            lastName = _lastName;
            balance = _balance;
        }

        public string Firstname
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public void doDeposit(double funds)
        {
            balance += funds;
        }

        public double doWithdraw(double funds)
        {
            if(balance < funds)
            {
                throw new Exception(firstName + " doesn't have enough balance in bank Account");
            }

            balance -= funds;
            return balance;
        }

        public string toString()
        {
            return firstName + lastName + "has balance of " + balance + "in his bank account";
        }

    }
}
