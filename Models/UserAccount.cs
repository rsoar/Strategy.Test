namespace POC.Strategy.Models
{
    public class UserAccount
    {
        public double Balance { get; protected set; }

        public UserAccount(double balance)
        {
            Balance = balance;
        }
    }
}
