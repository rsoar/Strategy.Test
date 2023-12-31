using POC.Strategy.DTOs;
using POC.Strategy.Interfaces;

namespace POC.Strategy.Models
{
    class Transaction
    {
        public Transaction(UserAccount account)
        {
            Account = account;
        }

        public readonly Guid Id = Guid.NewGuid();
        public UserAccount Account { get; }

        public List<InvestmentForecastDto> New(double entryValue, IBank bank)
        {
            if (entryValue > Account.Balance)
                throw new Exception("It was not possible to complete your transaction as you do not have sufficient balance.");

            return bank.Calculate(entryValue, 30);
        }
    }
}
