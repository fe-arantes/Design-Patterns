using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Invoice
{
    public interface INotaFiscalService
    {
        public void ExecuteNF(NotaFiscal notaFiscal);
    }
}
