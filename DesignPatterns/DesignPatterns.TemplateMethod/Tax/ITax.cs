using DesignPatterns.TemplateMethod.Sale;

namespace DesignPatterns.TemplateMethod.Tax
{
    internal interface ITax
    {
        decimal Calculate(Order order);
    }
}
