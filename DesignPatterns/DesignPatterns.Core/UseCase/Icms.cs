using DesignPatterns.Core.Context;

namespace DesignPatterns.Core.UseCase
{
    internal class Icms
    {
        public decimal CalculaIcms(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1M;
        }
    }
}
