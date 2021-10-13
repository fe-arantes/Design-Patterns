using DesignPatterns.Decorator.Example2.Account;

namespace DesignPatterns.Decorator.Example2.Filter
{
    internal class HighFilter : FilterAccount
    {
        public HighFilter() { }

        public HighFilter(FilterAccount anotherFilter) : base(anotherFilter) { }

        public override IList<AccountEntity> Filter(IList<AccountEntity> accounts)
        {
            var filteredAccounts = new List<AccountEntity>();

            foreach (var account in accounts)
            {
                if (account.Balance > 500000)
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
