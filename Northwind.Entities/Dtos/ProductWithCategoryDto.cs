using Northwind.Core.Entities;

namespace Northwind.Entities.Dtos
{
    public class ProductWithCategoryDto : IDto
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string? CategoryName { get; set; }
    }
}
