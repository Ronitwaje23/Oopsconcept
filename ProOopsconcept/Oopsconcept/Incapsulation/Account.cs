using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsconcept.Incapsulation
{
    internal class Account
    {
        private double balance = 2000;
        public void setbalance(Double balance)
        {
            if (balance < 0)
                Console.WriteLine("please enter valid amount like more than 100 rs");
            else
                this.balance = this.balance + balance;
        }
        public void Getbalance()
        {
            Console.WriteLine(balance);

        }
    }
}
