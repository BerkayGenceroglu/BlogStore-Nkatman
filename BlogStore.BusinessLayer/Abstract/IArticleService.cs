using BlogStore.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        List<Article> TGetArticlesWithCategories();
        public AppUser TGetAppUserByArticleId(int id);
        List<Article> TGetTop3PopularArticles();
        List<Article> TGetArticlesByAppUser(string id);
    }
}
