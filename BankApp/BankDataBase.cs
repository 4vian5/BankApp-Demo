using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class BankDataBase
    {
        private static IDictionary<string, SavingAccount> savingAccounts = new Dictionary<string, SavingAccount>();
        private static IDictionary<string, CheckingAccount> checkingAccounts = new Dictionary<string, CheckingAccount>();

        public BankDataBase(){
            if(savingAccounts.Count < 1)
            {
                checkingAccounts.Add("A000", new CheckingAccount("Abhiyan", "Chhetri", 220));
                savingAccounts.Add("A000", new SavingAccount("Ram", "Shah", 220));
            }
        }

        public IDictionary<string, SavingAccount> saving
        {
            get
            {
                return savingAccounts;
            }

            set
            {
                savingAccounts = value;
            }
        }

        public IDictionary<string, CheckingAccount> checking
        {
            get
            {
                return checkingAccounts;
            }
            set
            {
                checkingAccounts = value;
            }
        }
    }
}
 