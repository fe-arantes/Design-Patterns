using DesignPatterns.TemplateMethod.Sale;

namespace DesignPatterns.TemplateMethod.Tax
{
    internal abstract class TaxTemplate : ITax
    {
        public decimal Calculate(Order order)
        {
            if (UseMaxTax(order))
            {
                return MaxTax(order);
            }

            return MinTax(order);
        }

        protected abstract bool UseMaxTax(Order order);
        protected abstract decimal MaxTax(Order order);
        protected abstract decimal MinTax(Order order);
    }
}
