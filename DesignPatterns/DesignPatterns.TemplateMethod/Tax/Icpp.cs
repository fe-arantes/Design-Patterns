using DesignPatterns.TemplateMethod.Sale;

namespace DesignPatterns.TemplateMethod.Tax
{
    internal class Icpp : TaxTemplate
    {
        protected override bool UseMaxTax(Order order)
        {
            return order.TotalValue >= 500;
        }

        protected override decimal MaxTax(Order order)
        {
            return order.TotalValue * 0.07M;
        }

        protected override decimal MinTax(Order order)
        {
            return order.TotalValue * 0.05M;
        }
    }
}
