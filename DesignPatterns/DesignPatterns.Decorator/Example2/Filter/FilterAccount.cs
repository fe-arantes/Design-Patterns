using DesignPatterns.Decorator.Example2.Account;

namespace DesignPatterns.Decorator.Example2.Filter
{
    internal abstract class FilterAccount
    {
        protected FilterAccount AnotherFilter { get; private set; }

        public FilterAccount() { }

        public FilterAccount(FilterAccount anotherFilter)
        {
            AnotherFilter = anotherFilter;
        }

        public abstract IList<AccountEntity> Filter(IList<AccountEntity> contas);

        protected IList<AccountEntity> Next(IList<AccountEntity> contas)
        {
            if (AnotherFilter is null)
                return new List<AccountEntity>();

            return AnotherFilter.Filter(contas);
        }

    }
}
