using BlogStore.BusinessLayer.Abstract;
using BlogStore.DataAccessLayer.Abstract;
using BlogStore.DataAccessLayer.Dtos;
using BlogStore.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<CategoryWithArticleCountDto> TGetCategoryWithArticleCount()
        {
            return _categoryDal.GetCategoryWithArticleCount();
        }

        public void TInsert(Category entity)
        {
            if (entity.CategoryName.Length >= 3 && entity.CategoryName.Length<=20)
            {
            _categoryDal.Insert(entity);
            }
            else
            {
                throw new ArgumentException("Category name must be between 3 and 20 characters.");
            }
        }

        public void TUpdate(Category entity)
        {
            if (entity.CategoryName.Length >= 3 && entity.CategoryName.Length <= 20)
            {
                _categoryDal.Update(entity);
            }
            else
            {
                throw new ArgumentException("Category name must be between 3 and 20 characters.");
            }
        }
    }
}
