using Northwind.Entities.Concrete;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();

        List<Product> GetAll();
        Product Add(Product product);
    }
}
