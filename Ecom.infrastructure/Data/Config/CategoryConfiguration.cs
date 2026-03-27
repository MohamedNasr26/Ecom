using Ecom.Core.Entites.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.infrastructure.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);
                builder.Property(x => x.Description).HasMaxLength(500);
                builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);

            builder.HasData(
                new Category { Id = 1, Name = "test", Description = "test" }
                //new Category { Id = 2, Name = "Clothing", Description = "Apparel and accessories" },
                //new Category { Id = 3, Name = "Books", Description = "Books and literature" }
            );
        }
    }
}



