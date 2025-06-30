using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.ViewComponents.AuthorLayoutViewComponents
{
    public class _AuthorLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
