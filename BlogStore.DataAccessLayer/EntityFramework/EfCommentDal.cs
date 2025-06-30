using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using BlogStore.DataAccessLayer.Repositories;
using BlogStore.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly BlogContext _context;
        public EfCommentDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var values = _context.Comments.Include(x => x.AppUser).Include(x => x.Article).Where(x => x.ArticleId == id && x.IsValid == true).ToList();
            return values;
        }

        public List<Comment> GetLast3CommentByUserArticle(string id)
        {
            var values = _context.Comments.Include(x => x.AppUser).Include(x => x.Article)
                .Where(x => x.Article.AppUserId == id && x.IsValid == true).OrderByDescending(x => x.CommentDate).Take(3).ToList();
            return values;
        }
    }
}
