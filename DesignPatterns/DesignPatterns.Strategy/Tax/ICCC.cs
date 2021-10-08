using DesignPatterns.Strategy.Sale;

namespace DesignPatterns.Strategy.Tax
{
    internal class ICCC : ITax
    {
        public decimal Calculate(Order order)
        {
            if(order.Value < 1000)
                return order.Value * 0.05M;

            if (order.Value > 3000)
                return (order.Value * 0.08M) + 30;

            return order.Value * 0.07M;
        }
    }
}
