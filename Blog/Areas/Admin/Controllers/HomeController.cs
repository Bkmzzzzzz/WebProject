using Microsoft.AspNetCore.Mvc;
using Blog.Domain;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.NewsItems.GetNewsItems());
        }
    }
}