using DesignPatterns.Strategy.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Tax
{
    internal class Icms : ITax
    {
        public decimal Calculate(Order order)
        {
            return order.Value * 0.05M;
        }
    }
}
