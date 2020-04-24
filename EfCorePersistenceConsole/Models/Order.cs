namespace EfCorePersistenceConsole.Models
{
    public class Order
    {
        private Order()
        {

        }

        public Order(OrderRowGuid rowGuid, OrderAmount amount, OrderDate orderDate)
        {
            RowGuid = rowGuid;
            Amount = amount;
            OrderDate = orderDate;
        }

        public int OrderId { get; set; }
        public OrderRowGuid RowGuid { get; set; }
        public OrderAmount Amount { get; set; }
        public OrderDate OrderDate { get; set; }

    }
}
