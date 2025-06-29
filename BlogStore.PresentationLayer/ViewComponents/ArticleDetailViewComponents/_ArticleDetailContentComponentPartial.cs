using BlogStore.BusinessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailContentComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;
        private readonly BlogContext _context;

        public _ArticleDetailContentComponentPartial(IArticleService articleService, BlogContext context)
        {
            _articleService = articleService;
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _articleService.TGetById(id);
            ViewBag.username = _context.Users.Where(x => x.Id == value.AppUserId)
                .Select(y => y.Name +"  " + y.Surname)
                .FirstOrDefault();
            return View(value);
        }
    }
}
