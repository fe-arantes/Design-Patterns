using DesignPatterns.TemplateMethod.Example2.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Example2.Report
{
    internal class ReportPrinter
    {
        public void Print(IList<AccountEntity> accounts, IReport report)
        {
            report.Print(accounts);
        }
    }
}
