using DesignPatterns.Decorator.Sale;

namespace DesignPatterns.Decorator.Tax
{
    internal class Icms : TaxCalculator
    {
        public Icms() { }

        public Icms(TaxCalculator anotherTax) : base(anotherTax) { }

        public override decimal Calculate(Order order)
        {
            return (order.TotalValue * 0.12M) + (CalculateAnotherTax(order));
        }

    }
}
