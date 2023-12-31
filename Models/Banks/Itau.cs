using POC.Strategy.DTOs;
using POC.Strategy.Interfaces;
using POC.Strategy.Models.Investments;

namespace POC.Strategy.Models.Banks
{
    public class Itau : IBank
    {
        public List<Investment> Investments = new() { new ItauCDB(), new ItauFIIs() };

        public List<InvestmentForecastDto> Calculate(double value, int days)
        {
            return Investments
                .Select(investment =>
                {

                    double percent = investment.InterestRate / 100;
                    double dailyRate = percent / (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) - 1);
                    double total = value * Math.Pow(1 + dailyRate, days);

                    return new InvestmentForecastDto(investment.Name, investment.InterestRate, value, total);
                })
                .ToList();
        }
    }
}
