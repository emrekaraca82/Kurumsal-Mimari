﻿using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;
using Northwind.Dal.Abstract;

namespace Northwind.Bll.Concrete
{
    public class CategoryManger : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
