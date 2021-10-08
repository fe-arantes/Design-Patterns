using DesignPatterns.Strategy.Sale;
using DesignPatterns.Strategy.Tax;

ITax iss = new Iss();
ITax icms = new Icms();
ITax iCCC = new ICCC();
var calculateTax = new CalculateTax();


var myOrder = new Order(100);
var issValue = calculateTax.Calculate(myOrder, iss);
var icmsValue = calculateTax.Calculate(myOrder, icms);
var iCCCValue = calculateTax.Calculate(myOrder, iCCC);

Console.WriteLine($"Order Value = {myOrder.Value}");
Console.WriteLine($"Iss Value = {issValue}");
Console.WriteLine($"Icms Value = {icmsValue}");
Console.WriteLine($"ICCC Value = {iCCCValue}");
Console.ReadKey();

