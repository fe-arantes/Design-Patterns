using DesignPatterns.State.Sale;

namespace DesignPatterns.State.State
{
    internal class Approved : IState
    {
        public decimal GetExtraDiscount(Order order)
        {
            return order.TotalGrossValue * 0.05M;
        }

        public void Approve(Order order)
        {
            throw new ArgumentException("Orçamento já está em estado de aprovação");
        }

        public void Reprove(Order order)
        {
            order.SetStatus(new Reproved());
        }

        public void Finish(Order order)
        {
            order.SetStatus(new Finished());
        }
    }
}
