using DesignPatterns.TemplateMethod.Example2.Account;
using DesignPatterns.TemplateMethod.Example2.Report;
using DesignPatterns.TemplateMethod.Sale;
using DesignPatterns.TemplateMethod.Tax;

//EXAMPLE 1 = TAX
var order = new Order();
order.AddItem(new OrderItem("Pencil", 1000));

ITax icpp = new Icpp();
ITax ikcv = new Ikcv();
var calculateTax = new TaxCalculator();
var icppValue = calculateTax.Calculate(order, icpp);
var ikcvValue = calculateTax.Calculate(order, ikcv);

Console.WriteLine($"Order Value = {order.TotalValue}");
Console.WriteLine($"Icpp Value = {icppValue}");
Console.WriteLine($"Ikcv Value = {ikcvValue}");
Console.ReadKey();

//EXAMPLE 2 = ACCOUNT
var accounts = new List<AccountEntity>
{
    new AccountEntity("Name_1", 1, "0001", 500),
    new AccountEntity("Name_2", 2, "0002", 1000),
    new AccountEntity("Name_3", 3, "0003", 10000)
};

IReport simpleReport = new SimpleReport();
IReport complexReport = new ComplexReport();

var reportPrinter = new ReportPrinter();
reportPrinter.Print(accounts, simpleReport);
reportPrinter.Print(accounts, complexReport);