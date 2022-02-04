using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Invoice
{
    internal class NotaFiscalBuilder
    {
        private string _RazaoSocial;
        private string _Cnpj;
        private string _Note;
        private DateTime _DataDeEmissao = DateTime.Now;
        public decimal TotalValue => Items.Sum(x => x.Value);
        public decimal TaxValue => Items.Sum(x => x.TaxValue);

        private readonly IList<NotaFiscalItem> Items = new List<NotaFiscalItem>();

        public NotaFiscalBuilder SetRazaoSocial(string razaoSocial)
        {
            _RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder SetCnpj(string cnpj)
        {
            _Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder SetDataDeEmissao(DateTime dataDeEmissao)
        {
            _DataDeEmissao = dataDeEmissao;
            return this;
        }

        public NotaFiscalBuilder SetNote(string note)
        {
            _Note = note;
            return this;
        }

        public NotaFiscalBuilder AddItem(NotaFiscalItem item)
        {
            Items.Add(item);
            return this;
        }

        public NotaFiscal CreateNf()
        {
            var notaFiscal = new NotaFiscal(_RazaoSocial, _Cnpj, _DataDeEmissao, _Note);

            notaFiscal.AddItems(Items);

            return notaFiscal;
        }
    }
}
