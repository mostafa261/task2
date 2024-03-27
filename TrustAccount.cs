using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_inhert_acc
{
    public class TrustAccount:Account
    {
        double rate ;
        const double bouns= 50.00;
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double rate = 0) : base(name, balance)
        {
            this.rate = rate;
        }
        public override bool Deposit(double amount)
        {
            if (amount>= 5000.00)
                return base.Deposit(balance+bouns);
            else 
             return base.Deposit(amount);
            
            
        }
        public override string ToString()
        {
            return  $"[Account : {name} : {balance} : {rate} ]";
        }

    }
}
