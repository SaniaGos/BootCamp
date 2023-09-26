namespace Lib2
{
    public class OrderBase
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public OrderStatus OrdersStatus { get; set; }
        protected double Discount { get; set; }
    }
}