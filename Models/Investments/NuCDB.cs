namespace POC.Strategy.Models.Investments
{
    public class NuCDB : Investment
    {
        public override Guid Identifier => Guid.NewGuid();
        public override string Name => "CDB_NU_MAR_2024";
        public override double InterestRate => 1.17;
    }
}
