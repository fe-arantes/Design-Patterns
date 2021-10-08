using DesignPatterns.Core.Context;

namespace DesignPatterns.Core.Tax
{
    internal interface IImposto
    {
        decimal Calcula(Orcamento orcamento);
    }
}
