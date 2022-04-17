﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);
        List<Category> GetList();
        Category GetById(int id);


    }
}
