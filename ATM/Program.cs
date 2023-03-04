using ATM.Entities;
using ATM.Entities.Exceptions;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");

            Console.Write("Number: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holderAccount = Console.ReadLine();
            Console.Write("Initial balance: ");
            double inicialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Account account = new Account(numberAccount, holderAccount, inicialBalance, withdrawLimit);

            Console.Write("Enter the amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                account.Withdraw(amount);
                Console.WriteLine($"New Balance: ${account.Balace}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}