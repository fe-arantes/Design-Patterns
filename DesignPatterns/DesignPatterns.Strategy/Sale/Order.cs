namespace DesignPatterns.Strategy.Sale
{
    internal class Order
    {
        public Order(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; private set; }
    }
}
