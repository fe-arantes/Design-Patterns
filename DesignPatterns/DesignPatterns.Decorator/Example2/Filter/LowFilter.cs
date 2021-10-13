using DesignPatterns.Decorator.Example2.Account;

namespace DesignPatterns.Decorator.Example2.Filter
{
    internal class LowFilter : FilterAccount
    {
        public LowFilter() { }

        public LowFilter(FilterAccount anotherFilter) : base(anotherFilter) { }

        public override IList<AccountEntity> Filter(IList<AccountEntity> accounts)
        {
            var filteredAccounts = new List<AccountEntity>();

            foreach (var account in accounts)
            {
                if (account.Balance < 100)
                {
                    filteredAccounts.Add(account);
                }
            }

            foreach (var account in Next(accounts))
            {
                filteredAccounts.Add(account);
            }

            return filteredAccounts;
        }
    }
}
