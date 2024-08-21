﻿using System;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {

        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductInStockId);

            var random = new Random();
            var products = new List<ProductInStock>();
            
            for (int i = 1; i <= 100; i++)
            {
                products.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = random.Next(0, 100)
                });
            }

            entityBuilder.HasData(products);
        }
    }
}
