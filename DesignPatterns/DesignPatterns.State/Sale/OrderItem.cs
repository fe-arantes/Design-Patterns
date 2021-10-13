namespace DesignPatterns.State.Sale
{
    internal class OrderItem
    {
        public OrderItem(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }
        public decimal Value { get; private set; }
    }
}
