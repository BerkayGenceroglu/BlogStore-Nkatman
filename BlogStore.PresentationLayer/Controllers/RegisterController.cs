using BlogStore.EntityLayer.Entities;
using BlogStore.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserRegisterViewModel userRegisterViewModel)
        {
            AppUser appuser = new AppUser()
            {
                ImageUrl = "Test",
                Desctiption = "test",
                Name = userRegisterViewModel.Name,
                Surname = userRegisterViewModel.Surname,
                UserName = userRegisterViewModel.Username,
                Email = userRegisterViewModel.Email,
            };
            await _userManager.CreateAsync(appuser, userRegisterViewModel.Password);
            return RedirectToAction("UserLogin", "Login");
        }
    }
}
