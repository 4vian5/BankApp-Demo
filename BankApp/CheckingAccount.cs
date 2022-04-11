using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class CheckingAccount : BankAccount
    {
        private const double MONTHLYCHARGE = 12.65;
        private const int NOOFFREETRANSACTIONS = 5;
        private int totalTrans = 0;

        public CheckingAccount(string _firstName, string _lastName, double _balance) : base(_firstName, _lastName, _balance)
        {

        }

        new public double doWithdraw(double funds)
        {
            base.doWithdraw(funds);
            totalTrans++;
            return Balance;
        }

        public int TotalTans
        {
            get
            {
                return totalTrans;
            }
        }

        public int noOfFreeTransactions {

            get
            {
                return NOOFFREETRANSACTIONS;
            }
        }

        public double MonthlyFee {

            get
            {
                return MONTHLYCHARGE;
            }
        }

        new public String toString()
        {
            return "Name : " + Firstname + " " + Lastname + " | Balance: " + Balance.ToString();
        }


    }
}
