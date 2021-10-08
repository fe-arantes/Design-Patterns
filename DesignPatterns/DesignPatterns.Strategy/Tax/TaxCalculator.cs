using DesignPatterns.Strategy.Sale;

namespace DesignPatterns.Strategy.Tax
{
    internal class TaxCalculator
    {
        public decimal Calculate(Order order, ITax tax)
        {
            return tax.Calculate(order);
        }
    }
}
