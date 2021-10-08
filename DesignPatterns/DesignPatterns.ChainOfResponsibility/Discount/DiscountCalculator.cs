using DesignPatterns.ChainOfResponsibility.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Discount
{
    internal class DiscountCalculator
    {
        public decimal Calculate(Order order)
        {
            IDiscount discountByUnits = new DiscountByUnits();
            IDiscount discountByValue = new DiscountByValue();
            IDiscount discountByGroup = new DiscountByGroup();
            IDiscount discountDefault = new DiscountDefault();

            discountByUnits.NextDiscount = discountByValue;
            discountByValue.NextDiscount = discountByGroup;
            discountByGroup.NextDiscount = discountDefault;
            return discountByUnits.Discount(order);
        }
    }
}
