using DesignPatterns.TemplateMethod.Sale;

namespace DesignPatterns.TemplateMethod.Tax
{
    internal class Ikcv : TaxTemplate
    {
        protected override bool UseMaxTax(Order order)
        {
            return order.TotalValue >= 500 && HaveItemGreaterThan100(order);
        }

        protected bool HaveItemGreaterThan100(Order order)
        {
            return order.Items.Any(x => x.Value > 100);
        }

        protected override decimal MaxTax(Order order)
        {
            return order.TotalValue * 0.10M;
        }

        protected override decimal MinTax(Order order)
        {
            return order.TotalValue * 0.06M;
        }
    }
}
