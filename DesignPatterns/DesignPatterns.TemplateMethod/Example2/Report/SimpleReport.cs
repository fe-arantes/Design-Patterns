using DesignPatterns.TemplateMethod.Example2.Account;

namespace DesignPatterns.TemplateMethod.Example2.Report
{
    internal class SimpleReport : ReportTemplate
    {
        protected override void Body(IList<AccountEntity> accounts)
        {
            Console.WriteLine("Name - Balance");

            foreach (var account in accounts)
            {
                Console.WriteLine(account.Name + " - " + account.Balance);
            }
        }

        protected override void Footer()
        {
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Header()
        {
            Console.WriteLine("Banco XYZ");
        }
    }
}
