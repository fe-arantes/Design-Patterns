using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Core.Context
{
    internal class Orcamento
    {
        public Orcamento(decimal valor)
        {
            Valor = valor;
        }

        public decimal Valor { get; private set; }
    }
}
