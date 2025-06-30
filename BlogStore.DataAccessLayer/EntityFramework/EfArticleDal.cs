 using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Context;
using BlogStore.DataAccessLayer.Dtos;
using BlogStore.DataAccessLayer.Repositories;
using BlogStore.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<CategoryArticleCountDto> GetArticleCountByCategory()
        {
            var result = _context.Articles
                .Include(a => a.Category)
                .GroupBy(a => a.Category.CategoryName)
                .Select(b => new CategoryArticleCountDto
                {
                    CategoryName = b.Key,
                    ArticleCount = b.Count()
                })
                .ToList();

            return result;
        }

        public List<Article> GetArticlesByAppUser(string id)
        {
            return _context.Articles.Where(x => x.AppUserId == id).ToList();
            //Bu kısım, belirli bir AppUser (kullanıcı) tarafından yazılmış makaleleri getirir 
        }

        public List<Article> GetArticlesWithCategories(int id)
        {
            return _context.Articles
                    .Where(a => a.CategoryId == id)
                    .Include(a => a.Category)
                    .ToList();
            //Bu kısım, "Eager Loading" denen bir işlemi yapar. Yani, her makalenin ilişkili olduğu Category (kategori) bilgilerini de birlikte getirir.
        }

        public List<Article> GetArticlesWithCategoriesAll()
        {
            return _context.Articles
                    .Include(a => a.Category)
                    .ToList();
            //Bu kısım, tüm makaleleri ve her bir makalenin ilişkili olduğu Category (kategori) bilgilerini getirir.
        }

        public List<Article> GetLast5ArticleByUser(string id)
        {
            return _context.Articles
                .Where(x => x.AppUserId == id)
                .OrderByDescending(x => x.CreatedDate)
                .Take(5)
                .ToList();
        }

        public List<Article> GetListByFilter(Expression<Func<Article, bool>> filter)
        {
            return _context.Articles.Where(filter).ToList();
            //Bu kısım, belirli bir filtreye göre makaleleri getirir. Örneğin, belirli bir başlığa veya açıklamaya sahip makaleleri bulmak için kullanılabilir.
        }

        public List<Article> GetTop3PopularArticles()
        {
            var values = _context.Articles.OrderByDescending(x => x.ArticleId).Take(3).ToList();
            return values;
        }
    }
}
