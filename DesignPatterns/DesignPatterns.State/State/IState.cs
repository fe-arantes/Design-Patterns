using DesignPatterns.State.Sale;

namespace DesignPatterns.State.State
{
    internal interface IState
    {
        decimal GetExtraDiscount(Order order);
        void Approve(Order order);
        void Reprove(Order order);
        void Finish(Order order);
    }
}
