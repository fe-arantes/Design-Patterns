using DesignPatterns.Decorator.Sale;

namespace DesignPatterns.Decorator.Tax
{
    internal interface Itax
    {
        abstract decimal Calculate(Order order);
    }
}
