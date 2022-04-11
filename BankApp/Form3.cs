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
    public partial class Form3 : Form
    {
        BankDataBase data = new BankDataBase();

        public Form3()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text == "admin" && passwordTextBox.Text == "password")
            {
                hideLogin();
            }
            else
            {
                MessageBox.Show("Please enter correct username and password");
            }
        }

        private void hideLogin()
        {
            infoLabel.Visible = false;
            info2.Visible = false;
            infoPanel.Visible = true;
            usernameTextBox.Visible = false;
            usernameLabel.Visible = false;
            passwordLabel.Visible = false;
            passwordTextBox.Visible = false;
            loginBtn.Visible = false;
            returnBtn.Visible = false;
            checkingBtn.Visible = true;
            savingBtn.Visible = true;
            accListBox.Visible = true;
            logoutBtn.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void checkingBtn_Click(object sender, EventArgs e)
        {
            accListBox.Items.Clear();
            foreach(var acc in data.checking)
            {
                accListBox.Items.Add(acc.Key + " => " + acc.Value.toString());
            }
        }

        private void savingBtn_Click(object sender, EventArgs e)
        {
            accListBox.Items.Clear();
            foreach (var acc in data.saving)
            {
                accListBox.Items.Add(acc.Key + " => " + acc.Value.toString());
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }
    }
}
