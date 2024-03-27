using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task_inhert_acc
{
    public class CheckingAccount : Account
    {
        double Fee = 1.50;
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) :base(name, balance)
        {
            
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee); //هنا انا مش عارف الفوس هتتخصم من الرصيد الاساسي ولامن الفلوس الي انا سحبتها بس هتعمل علي انها من الفلوس الي انا سحبتها 
        }
        public override string ToString()
        {
            return $"[Account: {name} : {balance}]";
        }
    }
}
