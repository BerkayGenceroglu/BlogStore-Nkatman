using BlogStore.EntityLayer.Entities;
using BlogStore.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.Username, loginViewModel.Password, true, false);
            if (result.Succeeded)
            {
                return RedirectToAction("GetProfile", "Author");
            }
            return View();
            //Bu satır, kullanıcıdan gelen giriş bilgilerini alıp:
            //Doğruysa giriş yaptırır,
            //Yanlışsa hata döner,
            //“Beni hatırla” ve “Kilitlenme” gibi ayarları da kontrol eder.
        }
    }
}
