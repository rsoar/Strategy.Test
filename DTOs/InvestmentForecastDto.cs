namespace POC.Strategy.DTOs
{
    public record InvestmentForecastDto(
        string Name,
        double RateOfReturn,
        double AmountInvested,
        double Return
    );
}
