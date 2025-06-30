using BlogStore.DataAccessLayer.Context;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogStore.PresentationLayer.Controllers
{
    public class WritterController : Controller
    {
        private readonly BlogContext _context;

        public WritterController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           
            var values = _context.Users.ToList();
            return View(values);
        }
    }
}
