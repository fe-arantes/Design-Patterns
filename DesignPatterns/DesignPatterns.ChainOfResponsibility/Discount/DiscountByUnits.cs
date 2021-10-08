using DesignPatterns.ChainOfResponsibility.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Discount
{
    internal class DiscountByUnits : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public decimal Discount(Order order)
        {
            if (order.Items.Count > 5)
                return order.TotalValue * 0.1M;

            return NextDiscount.Discount(order);
        }
    }
}
