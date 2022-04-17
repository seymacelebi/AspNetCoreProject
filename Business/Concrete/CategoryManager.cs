using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            if (category.CategoryName != "" && category.CategoryDescription != "" &&
                  category.CategoryName.Length >= 5 && category.CategoryStatus == true)
            {
                _categoryDal.Add(category);
            }
            else
            {
                //hata mesajı
            }
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p => p.CategoryId == id);
        }

        public List<Category> GetList()
        {
          return   _categoryDal.GetAll();
        }
    }
}
