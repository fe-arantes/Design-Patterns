using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.Sale
{
    internal class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public decimal TotalValue => Items.Sum(x => x.Value);
        public IList<OrderItem> Items { get; private set; }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }
}
