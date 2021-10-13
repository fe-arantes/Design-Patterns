using DesignPatterns.State.State;

namespace DesignPatterns.State.Sale
{
    internal class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
            CurrentStatus = new OnApproval();
        }

        public IState CurrentStatus { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public decimal TotalGrossValue => Items.Sum(x => x.Value);
        public decimal TotalNetValue => TotalGrossValue - ExtraDiscount;
        public decimal ExtraDiscount { get; private set; }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void SetStatus(IState newStatus)
        {
            CurrentStatus = newStatus;
        }

        public void ApplyExtraDiscount()
        {
            ExtraDiscount = CurrentStatus.GetExtraDiscount(this);
        }

        public void Approve()
        {
            CurrentStatus.Approve(this);
        }

        public void Reprove()
        {
            CurrentStatus.Reprove(this);
        }

        public void Finish()
        {
            CurrentStatus.Finish(this);
        }
    }
}
