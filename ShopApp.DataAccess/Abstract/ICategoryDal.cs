﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
        void DeleteFromCategory(int categoryId, int productId);
        Category GetByIdWithProducts(int id);
    }
}
