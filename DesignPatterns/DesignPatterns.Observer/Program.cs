// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DesignPatterns.Observer.Invoice;
using DesignPatterns.Observer.Invoice.Services;

var notaFiscalFactory = new NotaFiscalBuilder();
notaFiscalFactory
    .SetRazaoSocial("RazaoSocial")
    .SetCnpj("Cnpj")
    .SetNote("Note")
    .AddItem(new NotaFiscalItem("item 1", 10, 3))
    .AddItem(new NotaFiscalItem("item 2", 22, 7));

notaFiscalFactory.AddService(new Recorder());
notaFiscalFactory.AddService(new EmailSender());
notaFiscalFactory.AddService(new SmsSender());
notaFiscalFactory.AddService(new Printer());

var notaFiscal = notaFiscalFactory.CreateNf();

Console.WriteLine($"TotalValue = { notaFiscal.TotalValue}");
Console.WriteLine($"TaxValue = { notaFiscal.TaxValue}");
Console.ReadKey();


/*
    Quando devemos aplicar o padrão Observer?

    Quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações diferentes a serem executadas após um determinado processo, podemos implementar o Observer.
    Ele permite que diversas ações sejam executadas de forma transparente à classe principal, reduzindo o acoplamento entre essas ações, facilitando a manutenção e evolução do código.
 
 */