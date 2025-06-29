using BlogStore.BusinessLayer.Abstract;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogStore.PresentationLayer.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly UserManager<AppUser> _userManager;

        public AuthorController(IArticleService articleService, ICategoryService categoryService, UserManager<AppUser> userManager)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _userManager = userManager;
        }

        //Yani _userManager, uygulamanın kullanıcılarıyla ilgili veritabanı işlemlerini yapmak için kullandığı bir araçtır.
        public async Task<IActionResult> GetProfile()
        {
            var userProfile = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = userProfile.Name;
            ViewBag.Surname = userProfile.Surname;
            ViewBag.id = userProfile.Id;
            return View();
        }
        [HttpGet]
        public IActionResult CreateArticle()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticle(Article article)
        {
           var userProfile = await _userManager.FindByNameAsync(User.Identity.Name);
           article.AppUserId = userProfile.Id; // Kullanıcının ID'sini al ve makaleye ata
           article.CreatedDate = DateTime.Now; // Makalenin oluşturulma tarihini ayarla
           _articleService.TInsert(article);
            return RedirectToAction("Index", "Default");
        }
        public async Task<IActionResult> MyArticleList()
        {
            var userProfile = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _articleService.TGetArticlesByAppUser(userProfile.Id);
            return View(values);
        }
    }
}
