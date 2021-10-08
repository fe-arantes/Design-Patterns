using DesignPatterns.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Core.UseCase
{
    internal class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, string imposto)
        {
            var icms = orcamento.Valor * 0.1M;
            Console.WriteLine(icms);

            var iss = orcamento.Valor * 0.06M;
            Console.WriteLine(iss);
        }
    }
}
