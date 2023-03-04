using ATM.Entities.Exceptions;

namespace ATM.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balace { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balace = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balace += amount;
        } 
        public void Withdraw(double amount)
        {
            if (Balace < amount)
            {
                throw new DomainException("Not enough balance!");
            }
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            Balace -= amount;
        }
    }
}
