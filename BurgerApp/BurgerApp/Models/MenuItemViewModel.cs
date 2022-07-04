namespace BurgerApp.Models
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public BurgerViewModel Burger { get; set; }
        public SizeViewModel Size { get; set; }
        public decimal Price { get; set; }
    }
}
