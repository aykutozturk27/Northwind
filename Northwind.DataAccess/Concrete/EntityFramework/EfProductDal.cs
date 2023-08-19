using Northwind.Core.DataAccess.EntityFramework;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework.Contexts;
using Northwind.Entities.Concrete;
using Northwind.Entities.Dtos;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public ProductWithCategoryDto GetProductWithCategory()
        {
            using (var context = new NorthwindContext())
            {
                var query = (from product in context.Products
                 join category in context.Categories on product.CategoryID equals category.CategoryID
                 select new ProductWithCategoryDto { ProductName = product.ProductName, 
                     CategoryName = category.CategoryName }).FirstOrDefault();
                return query;
            }
        }
    }
}
