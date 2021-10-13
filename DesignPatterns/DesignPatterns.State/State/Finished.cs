using DesignPatterns.State.Sale;

namespace DesignPatterns.State.State
{
    internal class Finished : IState
    {
        public decimal GetExtraDiscount(Order order)
        {
            throw new ArgumentException("O desconto extra não pode ser aplicado em orçamentos finalizados");
        }

        public void Approve(Order order)
        {
            throw new ArgumentException("O orçamento já está finalizado");
        }

        public void Reprove(Order order)
        {
            throw new ArgumentException("O orçamento já está finalizado");
        }

        public void Finish(Order order)
        {
            throw new ArgumentException("O orçamento já está finalizado");
        }
    }
}
