namespace task_inhert_acc
{
    public class AccountUtil
    {
       
        // Utility helper functions for Account class
        public static void Display(List<Account> accounts)
        {
            Console.WriteLine("\n=== Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }
        public static void DisplayTu(List<TrustAccount> trustAccounts)
        {
            Console.WriteLine("\n=== TrustAccount ==========================================");
            foreach (var acc in trustAccounts)
            {
                Console.WriteLine(acc);
            }
        }
        public static void DisplaySa(List<SavingsAccount> savAccounts)
        {
            Console.WriteLine("\n=== SavingAccount ==========================================");
            foreach (var acc in savAccounts)
            {
                Console.WriteLine(acc);
            }
        }
        public static void DisplayChk(List<CheckingAccount> checAccounts)
        {
            Console.WriteLine("\n=== checking Account ==========================================");
            foreach (var acc in checAccounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }
        public static void DepositSa(List<SavingsAccount> savAccounts, double amount)
        {
            Console.WriteLine("\n=== Saving Deposite to Accounts =================================");
            foreach (var acc in savAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }
        public static void DepositTu(List<TrustAccount> trustAccounts, double amount)
        {
            Console.WriteLine("\n=== Turested Deposite to Accounts =================================");
            foreach (var acc in trustAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }
        public static void WithdrawTu(List<TrustAccount> trustAccounts, double amount)
        {
            Console.WriteLine("\n=== Turested Withdraw to Accounts =================================");
            foreach (var acc in trustAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"withdrawed {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Withdrawed of {amount} to {acc}");
            }
        }
        public static void WithdrawSa(List<SavingsAccount> savAccounts, double amount)
        {
            Console.WriteLine("\n=== Saving Withdraw to Accounts =================================");
            foreach (var acc in savAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrawed {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Withdrawed of {amount} to {acc}");
            }
        }
        public static void WithdrawChk(List<CheckingAccount> checAccounts, double amount)
        {
            double Fee = 1.50;
            Console.WriteLine("\n=== checking Withdraw to Accounts =================================");
            foreach (var acc in checAccounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrawed {amount} to {acc} Fee is  {Fee}");
                else
                    Console.WriteLine($"Failed Withdrawed of {amount} to {acc} Fee is  {Fee}");
            }
        }
        public static void DepositChk(List<CheckingAccount> checAccounts, double amount)
        {
          // const double Fee = 1.50;
            Console.WriteLine("\n=== checking Deposite to Accounts =================================");
            foreach (var acc in checAccounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc} ");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }
        public static void Withdraw(List<Account> accounts, double amount)
        {

            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
       
    }
}