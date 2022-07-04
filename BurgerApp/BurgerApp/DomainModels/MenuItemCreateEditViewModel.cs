using System.ComponentModel;

namespace BurgerApp.DomainModels
{
    public class MenuItemCreateEditViewModel
    {
        public int Id { get; set; }
        [DisplayName("Selected Burger")]
        public int SelectedBurgerId { get; set; }
        [DisplayName("Selected Size")]
        public int SelectedSize { get; set; }
        public decimal Price { get; set; }
    }
}
