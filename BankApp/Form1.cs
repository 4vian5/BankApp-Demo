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

    public partial class Form1 : Form
    {

        BankDataBase data = new BankDataBase();

        public delegate void delPassDataToFrom(Object obj, string acc);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accnoBox.Visible = true;
            adminBtn.Visible = false;
            LoginBtn.Visible = false;
            registerBtn.Visible = false;
            loginLabel.Visible = true;
            loginButton.Visible = true;
            checkingRadio.Visible = true;
            savingRadio.Visible = true;
            exitLoginButton.Visible = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkingRadio.Checked)
                {
                    CheckingAccount user = data.checking[accnoBox.Text];
                    this.Hide();
                    Form2 form2 = new Form2();
                    delPassDataToFrom del = new delPassDataToFrom(form2.retrieveData);
                    del(user, "Checking");
                    form2.Show();
                }

                else if (savingRadio.Checked)
                {
                    SavingAccount user = data.saving[accnoBox.Text];
                    this.Hide();
                    Form2 form2 = new Form2();
                    delPassDataToFrom del = new delPassDataToFrom(form2.retrieveData);
                    del(user, "Saving");
                    form2.Show();
                }

                else
                {
                    MessageBox.Show("Please Select Checking or Saving Account");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Account not found.\nPlease check your username.");
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            LoginBtn.Visible = false;
            registerBtn.Visible = false;
            adminBtn.Visible = false;
            registerLabel.Visible = true;
            firstnameBox.Visible = true;
            firstnameLabel.Visible = true;
            LastNameBox.Visible = true;
            lastnameLabel.Visible = true;
            balanceBox.Visible = true;
            balanceLabel.Visible = true;
            SavingRegisterBtn.Visible = true;
            checkingRegisterBtn.Visible = true;
            createAccBtn.Visible = true;
            registerExit.Visible = true;
        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            string firstname = firstnameBox.Text;
            string lastname = LastNameBox.Text;
            try
            {
                if(firstnameBox.Text == "" || LastNameBox.Text == "")
                {
                    throw new Exception("Please enter Firstname and Lastname Correctly!");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
                return;
            }
            double balance = 0;
            try {
                balance = double.Parse(balanceBox.Text);
            }
            catch (Exception exe)
            {
                MessageBox.Show("Please enter the balance correctly");
                return;
            }
            string accID = "";
            if ( checkingRegisterBtn.Checked)
            {
                CheckingAccount user = new CheckingAccount(firstname, lastname, balance);
                accID = "A00" + (data.checking.Count + 1).ToString();
                data.checking.Add(accID, user);
            }
            else if (SavingRegisterBtn.Checked)
            {
                try
                {
                    SavingAccount user = new SavingAccount(firstname, lastname, balance);
                    accID = "A00" + (data.saving.Count + 1).ToString();
                    data.saving.Add(accID, user);
                }
                catch(Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }

            }
            else
            {
                MessageBox.Show("Please select Checking or Saving account");
                return;
            }
            MessageBox.Show("Account created with username: " + accID);
            LoginBtn.Visible = true;
            registerBtn.Visible = true;
            adminBtn.Visible = true;
            registerLabel.Visible = false;
            firstnameBox.Visible = false;
            firstnameLabel.Visible = false;
            LastNameBox.Visible = false;
            lastnameLabel.Visible = false;
            balanceBox.Visible = false;
            balanceLabel.Visible = false;
            SavingRegisterBtn.Visible = false;
            checkingRegisterBtn.Visible = false;
            createAccBtn.Visible = false;
            registerExit.Visible = false;
        }

        private void exit()
        {
            Application.Exit();
        }

        private void exitLoginButton_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void registerExit_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.Show();
        }
    }
}
