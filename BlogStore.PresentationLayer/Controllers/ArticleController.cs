using BlogStore.BusinessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogStore.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly BlogContext _context;

        public ArticleController(BlogContext context)
        {
            _context = context;
        }

        [Route("Article/ArticleDetail/{slug}")]
        public IActionResult ArticleDetail(string slug)
        {
            var article = _context.Articles
                                  .Include(a => a.Category)
                                  .Include(a => a.AppUser)
                                  .FirstOrDefault(a => a.Slug == slug);

            if (article == null)
                return NotFound();

            ViewBag.id = article.ArticleId;
            return View();
        }

    }
}
