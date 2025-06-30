using BlogStore.BusinessLayer.Abstract;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.ViewComponents
{
    public class _ArticleListLayoutComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleListLayoutComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetArticlesWithCategoriesAll();
            return View(values);
        }
    }
}
