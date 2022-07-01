namespace BurgerApp.DomainModels
{
    public class OrderItem
    {
        public int Id { get; set; }
        public MenuItem MenuItemId { get; set; }
        public Order OrderId { get; set; }
        public int Quantity { get; set; }

        public OrderItem() { }

        public OrderItem(int id, MenuItem menuItemId, Order orderId, int quantity)
        {
            Id = id;
            MenuItemId = menuItemId;
            OrderId = orderId;
            Quantity = quantity;
        }
    }
}
