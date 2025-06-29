using BlogStore.DataAccessLayer.Dtos;
using BlogStore.EntityLayer.Entities;

namespace BlogStore.DataAccessLayer.Abstract
{
    public interface ICategoryDal: IGenericDal<Category>    
    {
        public List<CategoryWithArticleCountDto> GetCategoryWithArticleCount();
    }
}
