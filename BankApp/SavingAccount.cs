using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingAccount : BankAccount
    {
        private const int MINBALANCE = 100;

        public SavingAccount(string _firstname, string _lastname, double _balance) : base(_firstname, _lastname, _balance)
        {
            if(_balance  < MINBALANCE)
            {
                throw new Exception("The minimum balance Required to open Bank account is " + MINBALANCE);
            }
        }

        public int minBalance
        {
            get
            {
                return MINBALANCE;
            }
        }

        new public string toString()
        {
            return "Name : " + Firstname + Lastname + " | Balance : " + Balance ;

        }
    }
}
