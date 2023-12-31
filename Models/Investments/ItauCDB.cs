namespace POC.Strategy.Models.Investments
{
    public class ItauCDB : Investment
    {
        public override Guid Identifier => Guid.NewGuid();
        public override string Name => "CDB_ITAU_MAR_2024";
        public override double InterestRate => 1.12;
    }
}
