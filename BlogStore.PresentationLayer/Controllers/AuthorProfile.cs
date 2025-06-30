using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.Controllers
{
    public class AuthorProfile : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
