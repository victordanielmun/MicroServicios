using System;
using System.Collections.Generic;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder) 
        { 
            entityBuilder.HasIndex(x => x.ProductID);

            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(150);

            entityBuilder.Property(x => x.Description).HasMaxLength(500);

            //SEEDS

            var product = new List<Product>();
            var random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                product.Add(new Product
                {
                    ProductID = i,
                    Name = $"Product {i}",
                    Description = $"Product {i} Description",
                    Price = random.Next(10000, 100000)
                });
            }

            entityBuilder.HasData(product);

        }
    }
}
