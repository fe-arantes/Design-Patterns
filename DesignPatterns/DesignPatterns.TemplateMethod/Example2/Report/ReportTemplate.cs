using DesignPatterns.TemplateMethod.Example2.Account;

namespace DesignPatterns.TemplateMethod.Example2.Report
{
    internal abstract class ReportTemplate : IReport
    {
        public void Print(IList<AccountEntity> accounts)
        {
            Console.Clear();
            Header();
            
            Console.WriteLine("");
            Body(accounts);
            
            Console.WriteLine("");
            Footer();

            Console.ReadKey();
        }

        protected abstract void Header();
        protected abstract void Footer();
        protected abstract void Body(IList<AccountEntity> accounts);
    }
}
