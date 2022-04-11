using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private BankAccount user;
        private string accType;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void retrieveData(Object objPassedFromParent, string account)
        {
            user = (BankAccount)objPassedFromParent;
            accType = account;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for Using our Bank");
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double funds = double.Parse(fundsBox.Text);
                if(accType == "Checking")
                {
                    if(((CheckingAccount)user).TotalTans > ((CheckingAccount)user).noOfFreeTransactions) {
                        MessageBox.Show(user.Firstname + " has used the maximum number of allowed free transactions.\n" + "Now the monthly banking fee is: " + ((CheckingAccount)user).MonthlyFee);
                    }
                    ((CheckingAccount)user).doWithdraw(funds);
                }
                else
                {
                    user.doWithdraw(funds);
                }
                
                MessageBox.Show("Withdraw Successful : " + funds + "\nRemaining Balance: " + user.Balance);
                balanceLabel.Text = "Balance : " + user.Balance;
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameLabel.Text = "Account Holder Name : " + user.Firstname + " " + user.Lastname;
            balanceLabel.Text = "Balance : " + user.Balance;
            accTypeLabel.Text = "Account Type : " + accType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double funds = double.Parse(fundsBox.Text);
                user.doDeposit(funds);
                balanceLabel.Text = "Balance : " + user.Balance;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

    }
}
