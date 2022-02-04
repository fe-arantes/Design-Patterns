namespace DesignPatterns.Builder.Invoice
{
    internal class NotaFiscalItem
    {
        public NotaFiscalItem(string name, decimal value, decimal taxValue)
        {
            Name = name;
            Value = value;
            TaxValue = taxValue;
        }

        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public decimal TaxValue { get; private set; }
    }
}
