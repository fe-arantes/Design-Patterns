using DesignPatterns.Decorator.Sale;

namespace DesignPatterns.Decorator.Tax
{
    internal abstract class TaxCalculator
    {
        protected TaxCalculator AnotherTax { get; set; }

        protected TaxCalculator()
        {
            AnotherTax = null;
        }

        protected TaxCalculator(TaxCalculator anotherTax)
        {
            AnotherTax = anotherTax;
        }

        public abstract decimal Calculate(Order order);

        protected decimal CalculateAnotherTax(Order order)
        {
            if (AnotherTax is null)
                return 0;

            return AnotherTax.Calculate(order);
        }
    }
}
