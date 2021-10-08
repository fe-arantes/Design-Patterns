using DesignPatterns.Strategy.Sale;

namespace DesignPatterns.Strategy.Tax
{
    internal interface ITax
    {
        decimal Calculate(Order order);
    }
}
