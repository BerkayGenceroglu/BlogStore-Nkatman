using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.ViewComponents.AuthorLayoutViewComponents
{
    public class _AuthorLayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
