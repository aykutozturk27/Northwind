using Northwind.Core.Entities;
using Northwind.Entities.Concrete;

namespace Northwind.Entities.Dtos
{
    public class ProductListDto : IDto
    {
        public List<Product> Products { get; set; }
    }
}
