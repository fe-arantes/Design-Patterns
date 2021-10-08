using DesignPatterns.ChainOfResponsibility.Discount;
using DesignPatterns.ChainOfResponsibility.Sale;

var discountCalculator = new DiscountCalculator();
var order = new Order();
order.AddItem(new OrderItem("Pencil", 100));
order.AddItem(new OrderItem("Pencil", 100));
order.AddItem(new OrderItem("Pen", 100));
order.AddItem(new OrderItem("Pen", 100));
order.AddItem(new OrderItem("Eraser", 100));
order.AddItem(new OrderItem("Pencil Case", 300));

var discountValue = discountCalculator.Calculate(order);
Console.WriteLine($"Discount Value = {discountValue}");

Console.ReadKey();
