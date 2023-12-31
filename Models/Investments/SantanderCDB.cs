namespace POC.Strategy.Models.Investments
{
    public class SantanderCDB : Investment
    {
        public override Guid Identifier => Guid.NewGuid();
        public override string Name => "CDB_SANTANDER_MAR_2024";
        public override double InterestRate => 1.11;
    }
}
