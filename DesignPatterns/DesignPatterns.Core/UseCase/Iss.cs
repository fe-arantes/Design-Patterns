using DesignPatterns.Core.Context;

namespace DesignPatterns.Core.UseCase
{
    internal class ISS
    {
        public decimal CalculaIss(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06M;
        }
    }
}
