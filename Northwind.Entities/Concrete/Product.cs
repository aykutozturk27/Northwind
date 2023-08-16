using Northwind.Core.Entities;

namespace Northwind.Entities.Concrete
{
    public class Product : IEntity
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
