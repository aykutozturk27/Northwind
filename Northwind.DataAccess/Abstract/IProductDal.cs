﻿using Northwind.Core.DataAccess;
using Northwind.Entities.Concrete;
using Northwind.Entities.Dtos;

namespace Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        ProductWithCategoryDto GetProductWithCategory();
    }
}
