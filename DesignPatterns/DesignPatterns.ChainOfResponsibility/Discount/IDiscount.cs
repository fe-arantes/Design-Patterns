using DesignPatterns.ChainOfResponsibility.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Discount
{
    internal interface IDiscount
    {
        decimal Discount(Order order);
        IDiscount NextDiscount { get; set; }
    }
}
