using DesignPatterns.State.Sale;

namespace DesignPatterns.State.State
{
    internal class OnApproval : IState
    {
        public decimal GetExtraDiscount(Order order)
        {
            return order.TotalGrossValue * 0.10M;
        }

        public void Approve(Order order)
        {
            order.SetStatus(new Approved());
        }

        public void Reprove(Order order)
        {
            order.SetStatus(new Reproved());
        }

        public void Finish(Order order)
        {
            throw new ArgumentException("Orçamento em aprovação não pode ir para finalizado direto");
        }
    }
}
