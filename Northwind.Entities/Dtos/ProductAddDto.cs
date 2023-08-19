using Northwind.Core.Entities;
using Northwind.Entities.Concrete;

namespace Northwind.Entities.Dtos
{
    public class ProductAddDto : IDto
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
