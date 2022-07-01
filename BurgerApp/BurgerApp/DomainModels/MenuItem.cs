namespace BurgerApp.DomainModels
{
    public class MenuItem
    {
        public int Id { get; set; }
        public Burger BurgerId { get; set; }
        public Size SizeId { get; set; }
        public decimal Price { get; set; }

        public MenuItem() { }

        public MenuItem(int id, Burger burgerId, Size sizeId, decimal price)
        {
            Id = id;
            BurgerId = burgerId;
            SizeId = sizeId;
            Price = price;
        }
    }
}
