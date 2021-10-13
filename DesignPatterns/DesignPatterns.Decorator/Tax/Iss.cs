using DesignPatterns.Decorator.Sale;

namespace DesignPatterns.Decorator.Tax
{
    internal class Iss : TaxCalculator
    {
        public Iss() { }
        public Iss(TaxCalculator anotherTax) : base(anotherTax) { }

        public override decimal Calculate(Order order)
        {
            return (order.TotalValue * 0.06M) + (CalculateAnotherTax(order));
        }

    }
}
