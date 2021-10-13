/*
A principal situação que faz emergir o Design Pattern State é a necessidade de implementação de uma máquina de estados. 
Geralmente, o controle das possíveis transições são vários e complexos, fazendo com que a implementação não seja simples. 
O State auxilia a manter o controle dos estados simples e organizados através da criação de classes que representem cada estado e saiba controlar as transições.
*/

using DesignPatterns.State.Sale;

var order = new Order();
order.AddItem(new OrderItem("pencil", 1000));
Console.WriteLine($"Total Value = {order.TotalNetValue}");
Console.WriteLine();

order.ApplyExtraDiscount();
Console.WriteLine(order.CurrentStatus.GetType().ToString());
Console.WriteLine($"Extra Discount Value = {order.ExtraDiscount}"); //10%
Console.WriteLine($"Total Value = {order.TotalNetValue}");
Console.WriteLine();

order.Approve();
order.ApplyExtraDiscount();
Console.WriteLine(order.CurrentStatus.GetType().ToString());
Console.WriteLine($"Extra Discount Value = {order.ExtraDiscount}"); //5%
Console.WriteLine($"Total Value = {order.TotalNetValue}");
Console.WriteLine();

order.Finish();
Console.WriteLine(order.CurrentStatus.GetType().ToString());
//order.ApplyExtraDiscount(); //throw ArgumentException

Console.ReadKey();
