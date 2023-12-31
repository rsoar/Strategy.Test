namespace POC.Strategy.Models.Investments
{
    public class SantanderFIIs : Investment
    {
        public override Guid Identifier => Guid.NewGuid();
        public override string Name => "FIIs_Santander_SET_2027";
        public override double InterestRate => 1.21;
    }
}
