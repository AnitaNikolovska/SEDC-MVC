using BurgerApp.Mappers;
using BurgerApp.Storage;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Index()
        {
            var burgers = BurgerDb.Burgers.Select(x => x.ToViewModel()).OrderBy(x => x.Name).ToList();
            return View(burgers);
        }

        public IActionResult Details(int id)
        {
            var burger = BurgerDb.Burgers.FirstOrDefault(x => x.Id == id);

            if(burger == null)
            {
                throw new Exception($"Burger with Id: {id} does not exist!");
            }

            return View(burger.ToViewModel());
        }
    }
}
