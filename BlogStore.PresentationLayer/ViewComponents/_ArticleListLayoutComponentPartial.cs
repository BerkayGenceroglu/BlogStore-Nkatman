using BlogStore.BusinessLayer.Abstract;
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
            var values = _articleService.TGetArticlesWithCategories();
            return View(values);
        }
    }
}
