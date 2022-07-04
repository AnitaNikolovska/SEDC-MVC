using BurgerApp.DomainModels;
using BurgerApp.Models;

namespace BurgerApp.Mappers
{
    public static class MenuItemMapper
    {
        public static MenuItemViewModel ToViewModel(this MenuItem menuItem)
        {
            return new MenuItemViewModel
            {
                Id = menuItem.Id,
                Burger = menuItem.BurgerId.ToViewModel(),
                Size = menuItem.SizeId.ToViewModel(),
                Price = menuItem.Price
            };
        }
    }
}
