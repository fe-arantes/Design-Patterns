using DesignPatterns.TemplateMethod.Example2.Account;

namespace DesignPatterns.TemplateMethod.Example2.Report
{
    internal class ComplexReport : ReportTemplate
    {
        protected override void Body(IList<AccountEntity> accounts)
        {
            Console.WriteLine("Name - Number - Agency - Balance");

            foreach (var account in accounts)
            {
                Console.WriteLine(account.Name + " - " + account.Number + " - " + account.Agency + " - " + account.Balance);
            }
        }

        protected override void Footer()
        {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Header()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }
    }
}
