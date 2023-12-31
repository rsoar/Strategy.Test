using Newtonsoft.Json;
using POC.Strategy.DTOs;
using POC.Strategy.Models;
using POC.Strategy.Models.Banks;

Transaction transaction = new(new UserAccount(43000));

List<InvestmentForecastDto> nuForecast = transaction.New(5000, new Nubank());
List<InvestmentForecastDto> itauForecast = transaction.New(5000, new Itau());
List<InvestmentForecastDto> santanderForecast = transaction.New(5000, new Santander());

Console.WriteLine(JsonConvert.SerializeObject(santanderForecast));
Console.WriteLine(JsonConvert.SerializeObject(itauForecast));
Console.WriteLine(JsonConvert.SerializeObject(nuForecast));