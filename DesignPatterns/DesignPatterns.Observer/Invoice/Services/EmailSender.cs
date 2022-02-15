using DesignPatterns.Observer.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Invoice.Services
{
    public class EmailSender : INotaFiscalService
    {
        public void ExecuteNF(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Nota Fiscal enviada por email");
        }
    }
}
