namespace POC.Strategy.Models
{
    public abstract class Investment
    {
        abstract public Guid Identifier { get; }
        abstract public string Name { get; }
        abstract public double InterestRate { get; }
    }
}
