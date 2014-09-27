using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class BankInfoUI : Form
    {
        public BankInfoUI()
        {
            InitializeComponent();
        }
        Account anAccount = new Account();
        private double amount;

        private void createButton_Click(object sender, EventArgs e)
        {

            anAccount.number = accountNumberTextBox.Text;
            anAccount.name = customerNameTextBox.Text;

            MessageBox.Show(@"Account has been created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                amount = Convert.ToDouble(accountNumberTextBox.Text);
                anAccount.Deposit(amount);
            }
            else
            {
                MessageBox.Show("Create An Account! Thank You!!");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                amount = Convert.ToDouble(accountNumberTextBox.Text);
                anAccount.Withdarw(amount);
            }
            else
            {
                MessageBox.Show("Create An Account! Thank You!!");
            }
        }
    }
}
