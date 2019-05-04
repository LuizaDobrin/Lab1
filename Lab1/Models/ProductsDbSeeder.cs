using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Name1",
                    Description = "d1",
                    Category = "c1",
                    Price = 50.0
                },
                 new Product
                 {
                     Name = "Name2",
                     Description = "d2",
                     Category = "c2",
                     Price = 20.0
                 }
            );
            context.SaveChanges();
        }
    }
}
