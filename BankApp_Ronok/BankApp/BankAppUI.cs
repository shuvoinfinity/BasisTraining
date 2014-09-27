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
    public partial class BankAppUI : Form
    {
        public BankAppUI()
        {
            InitializeComponent();
        }

        Account anAccount=new Account();

        private double Balance = 0;

        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.AccountNumber = Convert.ToInt32(accountNumberTextBox.Text);
            anAccount.CustomerName = customerNameTextBox.Text;
          

            MessageBox.Show(anAccount.CustomerName+",Account Created Successfully!!!!!"+Environment.NewLine+ " and Account number: "+anAccount.AccountNumber);

            //ClearTextBoxes();
        }

       

        private void depositButton_Click(object sender, EventArgs e)
        {
            anAccount.Amount = Convert.ToDouble(amountTextBox.Text);
            Balance += anAccount.Amount;
        
            MessageBox.Show("Your A/C has been credited Successfully","Message");
            amountTextBox.Text = string.Empty;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            anAccount.Amount = Convert.ToDouble(amountTextBox.Text);
            Balance -= anAccount.Amount;
           MessageBox.Show("Your A/C has been debited Successfully", "Message");
           amountTextBox.Text = string.Empty;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Current balance is:"+Balance,"Message");

        }
        //private void ClearTextBoxes()
        //{
        //    accountNumberTextBox.Text = string.Empty;
        //    customerNameTextBox.Text = string.Empty;
        //}
    }
}
