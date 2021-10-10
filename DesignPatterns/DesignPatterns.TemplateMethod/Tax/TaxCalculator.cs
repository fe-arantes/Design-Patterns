using DesignPatterns.TemplateMethod.Sale;

namespace DesignPatterns.TemplateMethod.Tax
{
    internal class TaxCalculator
    {
        public decimal Calculate(Order order, ITax tax)
        {
            return tax.Calculate(order);
        }
    }
}
