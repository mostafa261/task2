using System.Security.Principal;

namespace task_inhert_acc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<SavingsAccount>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 2000));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.DisplaySa(savAccounts);
            AccountUtil.DepositSa(savAccounts, 1000);
            AccountUtil.WithdrawSa(savAccounts, 2000);

            // Checking 
            var checAccounts = new List<CheckingAccount>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.DisplayChk(checAccounts);
            AccountUtil.DepositChk(checAccounts, 1000);
            AccountUtil.WithdrawChk(checAccounts, 2000);
            AccountUtil.WithdrawChk(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<TrustAccount>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.DisplayTu(trustAccounts);
            AccountUtil.DepositTu(trustAccounts, 1000);
            AccountUtil.DepositTu(trustAccounts, 6000);
            AccountUtil.WithdrawTu(trustAccounts, 2000);
            AccountUtil.WithdrawTu(trustAccounts, 3000);
            AccountUtil.WithdrawTu(trustAccounts, 500);

            Console.WriteLine();
        }
    }
}
