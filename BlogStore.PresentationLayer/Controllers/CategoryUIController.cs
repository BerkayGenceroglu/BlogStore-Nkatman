using BlogStore.BusinessLayer.Abstract;
using BlogStore.EntityLayer.Entities;
using BlogStore.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

public class CategoryUIController : Controller
{
    private readonly ICategoryService _categoryService;
    private readonly IArticleService _articleService;

    public CategoryUIController(ICategoryService categoryService, IArticleService articleService)
    {
        _categoryService = categoryService;
        _articleService = articleService;
    }

    public IActionResult Index(int? categoryId)
    {
        var categories = _categoryService.TGetAll();

        var articles = categoryId.HasValue
            ? _articleService.TGetListByFilter(x => x.CategoryId == categoryId)
            : new List<Article>();

        var model = new CategoryWithArticlesViewModel
        {
            Categories = categories,
            Articles = articles,
            SelectedCategoryId = categoryId
        };

        return View(model);
    }
}

