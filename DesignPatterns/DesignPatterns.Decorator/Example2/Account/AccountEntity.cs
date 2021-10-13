namespace DesignPatterns.Decorator.Example2.Account
{
    internal class AccountEntity
    {
        public AccountEntity(
            string name,
            int number,
            string agency,
            decimal balance,
            DateTime creationDate)
        {
            Name = name;
            Number = number;
            Agency = agency;
            Balance = balance;
            CreationDate = creationDate;
        }

        public string Name { get; internal set; }
        public int Number { get; internal set; }
        public string Agency { get; internal set; }
        public decimal Balance { get; internal set; }
        public DateTime CreationDate { get; internal set; }
    }
}
