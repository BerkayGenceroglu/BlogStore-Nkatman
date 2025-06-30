using BlogStore.BusinessLayer.Abstract;
using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Dtos;
using BlogStore.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll();
        }

        public AppUser TGetAppUserByArticleId(int id)
        {
            return _articleDal.GetAppUserByArticleId(id);
        }

        public List<CategoryArticleCountDto> TGetArticleCountByCategory()
        {
            return _articleDal.GetArticleCountByCategory();
        }

        public List<Article> TGetArticlesByAppUser(string id)
        {
            return _articleDal.GetArticlesByAppUser(id);
        }

        public List<Article> TGetArticlesWithCategories(int id)
        {
            return _articleDal.GetArticlesWithCategories(id);
        }

        public List<Article> TGetArticlesWithCategoriesAll()
        {
            return _articleDal.GetArticlesWithCategoriesAll();
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public List<Article> TGetLast5ArticleByUser(string id)
        {
            return _articleDal.GetLast5ArticleByUser(id);
        }

        public List<Article> TGetListByFilter(Expression<Func<Article, bool>> filter)
        {
            return _articleDal.GetListByFilter(filter);
        }

        public List<Article> TGetTop3PopularArticles()
        {
            return _articleDal.GetTop3PopularArticles();
        }

        public void TInsert(Article entity)
        {
            if (entity.Title != null && entity.Title.Length > 10 && entity.Description != "" && entity.ImageUrl.Contains("a"))
            {
            _articleDal.Insert(entity);
            }
        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}
