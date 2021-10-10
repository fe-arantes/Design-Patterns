using DesignPatterns.TemplateMethod.Example2.Account;

namespace DesignPatterns.TemplateMethod.Example2.Report
{
    internal interface IReport
    {
        void Print(IList<AccountEntity> accounts);
    }
}
