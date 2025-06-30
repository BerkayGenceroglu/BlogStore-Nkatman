using BlogStore.BusinessLayer.Abstract;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.ViewComponents.AuthorLayoutViewComponents
{
    public class _AuthorDashboardRecentCommentsComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public _AuthorDashboardRecentCommentsComponentPartial(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var APP = await _userManager.FindByNameAsync(User.Identity.Name);
            var comments = _commentService.TGetLast3CommentByUserArticle(APP.Id);
            return View(comments);
        }
    }
}
