using DesignPatterns.State.Sale;

namespace DesignPatterns.State.State
{
    internal class Reproved : IState
    {
        public decimal GetExtraDiscount(Order order)
        {
            throw new ArgumentException("O desconto extra não pode ser aplicado em orçamentos reprovados");
        }

        public void Approve(Order order)
        {
            throw new ArgumentException("O Orçamento não pode ser aprovado");
        }

        public void Reprove(Order order)
        {
            throw new ArgumentException("O orçamento já está reprovado");
        }

        public void Finish(Order order)
        {
            order.SetStatus(new Finished());
        }
    }
}
