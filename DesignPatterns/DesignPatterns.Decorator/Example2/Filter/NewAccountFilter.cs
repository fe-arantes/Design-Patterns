using DesignPatterns.Decorator.Example2.Account;

namespace DesignPatterns.Decorator.Example2.Filter
{
    internal class NewAccountFilter : FilterAccount
    {
        public NewAccountFilter() { }

        public NewAccountFilter(FilterAccount anotherFilter) : base(anotherFilter) { }

        public override IList<AccountEntity> Filter(IList<AccountEntity> accounts)
        {
            var filteredAccounts = new List<AccountEntity>();

            foreach (var account in accounts)
            {
                if (account.CreationDate.Month == DateTime.Now.Month
                    && account.CreationDate.Year == DateTime.Now.Year)
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
