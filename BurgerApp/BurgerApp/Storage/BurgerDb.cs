using BurgerApp.DomainModels;
using BurgerApp.Helpers;

namespace BurgerApp.Storage
{
    public static class BurgerDb
    {
        public static List<Burger> Burgers = new List<Burger>
        {
            new Burger(IdHelper.GetRandomId(), "Hamburger", "Beef patty, french fries", "https://assets.epicurious.com/photos/57c5c6d9cf9e9ad43de2d96e/master/pass/the-ultimate-hamburger.jpg"),
            new Burger(IdHelper.GetRandomId(), "Cheeseburger", "Beef patty, french fries, cheese", "https://assets.epicurious.com/photos/5c745a108918ee7ab68daf79/5:4/w_3129,h_2503,c_limit/Smashburger-recipe-120219.jpg"),
            new Burger(IdHelper.GetRandomId(), "Chickenburger", "Chicken, french fries", "https://www.chicken.ca/wp-content/uploads/2020/09/Moist-Chicken-Burgers.jpg")
        };

        public static List<Size> Sizes = new List<Size>
        {  
            new Size(IdHelper.GetRandomId(), "Small"),
            new Size(IdHelper.GetRandomId(), "Normal"),
            new Size(IdHelper.GetRandomId(), "Large")
        };

        public static List<MenuItem> MenuItems = new List<MenuItem>
        {
            new MenuItem(IdHelper.GetRandomId(), Burgers[0], Sizes[0], 1),
            new MenuItem(IdHelper.GetRandomId(), Burgers[0], Sizes[1], 1.5m),
            new MenuItem(IdHelper.GetRandomId(), Burgers[0], Sizes[2], 2),
            new MenuItem(IdHelper.GetRandomId(), Burgers[1], Sizes[0], 1),
            new MenuItem(IdHelper.GetRandomId(), Burgers[1], Sizes[1], 1.5m),
            new MenuItem(IdHelper.GetRandomId(), Burgers[1], Sizes[2], 2),
            new MenuItem(IdHelper.GetRandomId(), Burgers[2], Sizes[0], 1),
            new MenuItem(IdHelper.GetRandomId(), Burgers[2], Sizes[1], 1.5m),
            new MenuItem(IdHelper.GetRandomId(), Burgers[2], Sizes[2], 2),
        };
    }
}
