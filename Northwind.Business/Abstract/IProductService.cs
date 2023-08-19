using Northwind.Entities.Concrete;
using Northwind.Entities.Dtos;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();

        //List<Product> GetAll();
        ProductListDto GetAll();

        //Product Add(Product product);
        ProductAddDto Add(Product product);
    }
}
