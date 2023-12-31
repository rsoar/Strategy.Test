using POC.Strategy.DTOs;
namespace POC.Strategy.Interfaces
{
    public interface ITransaction
    {
        List<InvestmentForecastDto> New(double entryValue, IBank bank);
    }
}
