using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "dbo");

            builder.HasKey(x => x.CategoryID);

            builder.Property(x => x.CategoryName).HasColumnName("CategoryName");
        }
    }
}
