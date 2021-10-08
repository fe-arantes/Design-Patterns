using DesignPatterns.ChainOfResponsibility.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Discount
{
    internal class DiscountByValue : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public decimal Discount(Order order)
        {
            if (order.TotalValue > 500)
                return order.TotalValue * 0.07M;

            return NextDiscount.Discount(order);
        }
    }
}
