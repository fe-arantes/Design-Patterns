using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Sale
{
    internal class OrderItem
    {
        public OrderItem(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }
        public decimal Value { get; private set; }
    }
}
