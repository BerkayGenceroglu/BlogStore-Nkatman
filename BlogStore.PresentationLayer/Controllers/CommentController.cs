using BlogStore.BusinessLayer.Abstract;
using BlogStore.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult CommentList()
        {
            var values = _commentService.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateComment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comment.Description))
                {
                    return Json(new { status = "error", message = "Yorum alanı boş olamaz." });
                }

                comment.CommentDate = DateTime.Now;


                _commentService.TInsert(comment);
                return Json(new { status = "success", message = "Yorum başarıyla eklendi!" });
            }
            catch (Exception)
            {
                return Json(new { status = "error", message = "Yorum gönderilirken bir hata oluştu." });
            }
        }

        public IActionResult DeleteComment(int id)
        {
            _commentService.TDelete(id);
            return RedirectToAction("CommentList");
        }

        [HttpGet]
        public IActionResult UpdateComment(int id)
        {
            var value = _commentService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentService.TUpdate(comment);
            return RedirectToAction("CommentList");
        }
    }
}
