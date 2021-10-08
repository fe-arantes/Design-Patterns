using DesignPatterns.ChainOfResponsibility.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Discount
{
    internal class DiscountDefault : IDiscount
    {
        public IDiscount? NextDiscount { get; set; }

        public decimal Discount(Order order)
        {
            return 0;
        }
    }
}
