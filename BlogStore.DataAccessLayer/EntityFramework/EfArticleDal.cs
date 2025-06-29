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
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        private readonly BlogContext _context;
        public EfArticleDal(BlogContext context) : base(context)
        {
            _context = context;
        }

        public AppUser GetAppUserByArticleId(int id)
        {
            string userId = _context.Articles.Where(x => x.ArticleId == id).Select(y => y.AppUserId).FirstOrDefault();
            var uservalue = _context.Users.Where(x => x.Id == userId).FirstOrDefault();
            return uservalue;
        }

        public List<Article> GetArticlesByAppUser(string id)
        {
            return _context.Articles.Where(x => x.AppUserId == id).ToList();
            //Bu kısım, belirli bir AppUser (kullanıcı) tarafından yazılmış makaleleri getirir 
        }

        public List<Article> GetArticlesWithCategories()
        {
            return _context.Articles.Include(a => a.Category).ToList();
            //Bu kısım, "Eager Loading" denen bir işlemi yapar. Yani, her makalenin ilişkili olduğu Category (kategori) bilgilerini de birlikte getirir.
        }

        public List<Article> GetTop3PopularArticles()
        {
            var values = _context.Articles.OrderByDescending(x => x.ArticleId).Take(3).ToList();
            return values;
        }
    }
}
