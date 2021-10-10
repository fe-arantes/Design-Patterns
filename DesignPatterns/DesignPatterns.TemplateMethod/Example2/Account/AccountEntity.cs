namespace DesignPatterns.TemplateMethod.Example2.Account
{
    internal class AccountEntity
    {
        public AccountEntity(string name, int number, string agency, decimal balance)
        {
            Name = name;
            Number = number;
            Agency = agency;
            Balance = balance;
        }

        public string Name { get; internal set; }
        public int Number { get; internal set; }
        public string Agency { get; internal set; }
        public decimal Balance { get; internal set; }
    }
}
