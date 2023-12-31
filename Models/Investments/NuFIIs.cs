namespace POC.Strategy.Models.Investments
{
    public class NuFIIs : Investment
    {
        public override Guid Identifier => Guid.NewGuid();
        public override string Name => "FIIs_NU_SET_2027";
        public override double InterestRate => 1.21;
    }
}
