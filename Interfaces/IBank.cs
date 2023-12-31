using POC.Strategy.DTOs;

namespace POC.Strategy.Interfaces
{
    public interface IBank
    {
        List<InvestmentForecastDto> Calculate(double value, int days);
    }
}
