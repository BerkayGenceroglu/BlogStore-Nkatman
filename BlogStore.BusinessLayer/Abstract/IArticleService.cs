using BlogStore.DataAccessLayer.Dtos;
using BlogStore.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        List<Article> TGetArticlesWithCategories(int id);
        public AppUser TGetAppUserByArticleId(int id);
        List<Article> TGetTop3PopularArticles();
        List<Article> TGetArticlesByAppUser(string id);
        List<Article> TGetListByFilter(Expression<Func<Article, bool>> filter);
        List<Article> TGetArticlesWithCategoriesAll();
        public List<CategoryArticleCountDto> TGetArticleCountByCategory();
        List<Article> TGetLast5ArticleByUser(string id);

    }
}
