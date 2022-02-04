// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DesignPatterns.Builder.Invoice;

var notaFiscalFactory = new NotaFiscalBuilder();
notaFiscalFactory
    .SetRazaoSocial("RazaoSocial")
    .SetCnpj("Cnpj")
    .SetNote("Note")
    .AddItem(new NotaFiscalItem("item 1", 10, 3))
    .AddItem(new NotaFiscalItem("item 2", 22, 7));

var notaFiscal = notaFiscalFactory.CreateNf();

Console.WriteLine($"TotalValue = { notaFiscal.TotalValue}");
Console.WriteLine($"TaxValue = { notaFiscal.TaxValue}");
Console.ReadKey();
