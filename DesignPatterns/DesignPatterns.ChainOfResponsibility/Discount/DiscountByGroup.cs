using DesignPatterns.ChainOfResponsibility.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Discount
{
    internal class DiscountByGroup : IDiscount
    {
        public IDiscount NextDiscount { get; set; }

        public decimal Discount(Order order)
        {
            if (order.Items.Any(x => x.Name == "Pen")
                && order.Items.Any(x => x.Name == "Pencil"))
            {
                return order.TotalValue * 0.05M;
            }

            return NextDiscount.Discount(order);
        }
    }
}
