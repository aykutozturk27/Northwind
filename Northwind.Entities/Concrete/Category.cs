using Northwind.Core.Entities;

namespace Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}
