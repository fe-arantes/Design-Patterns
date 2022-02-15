namespace DesignPatterns.Observer.Invoice
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public string Note { get; private set; }
        public decimal TotalValue => Items.Sum(x => x.Value);
        public decimal TaxValue => Items.Sum(x => x.TaxValue);

        private readonly IList<NotaFiscalItem> Items = new List<NotaFiscalItem>();

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, string note)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            Note = note;
        }

        public void AddItems(IList<NotaFiscalItem> items)
        {
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
