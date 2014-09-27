using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Account
    {
        
        private string number
        {
            set
            {
                this.number = value;
            }
            get
            {
                return this.number;
            }
        }

        private string name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        private double balance
        {
            get
            {
                return this.balance;
            }
        }


     
        public void Deposit(double amount)
        {
            balance += amount;

        }

        public void Withdarw(double amount)
        {
            balance -=  amount;
        }

     }
}
