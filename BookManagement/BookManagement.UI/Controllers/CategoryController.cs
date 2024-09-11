using Microsoft.AspNetCore.Mvc;

namespace BookManagement.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
