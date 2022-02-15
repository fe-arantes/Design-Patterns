using DesignPatterns.Observer.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Invoice.Services
{
    public class SmsSender : INotaFiscalService
    {
        public void ExecuteNF(NotaFiscal notaFiscal)
        {
            Console.WriteLine("SMS enviado com sucesso");
        }
    }
}
