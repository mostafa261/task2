using System.Xml.Linq;

namespace task_inhert_acc
{
    public class SavingsAccount : Account
    {

        double rate;
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double rate = 0) : base(name, balance)
        {
            this.rate = rate;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + rate);
        }
        public override string ToString()
        {
            return $"[Account: {name} : {balance}: {rate} ]";
        }
    }
}