namespace POC.Strategy.Models.Investments
{
    public class ItauFIIs : Investment
    {
        public override Guid Identifier => Guid.NewGuid();
        public override string Name => "FIIs_ITAU_SET_2027";
        public override double InterestRate => 1.21;
    }
}
