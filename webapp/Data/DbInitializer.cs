using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Data
{
    public class DbInitializer
    {
        public static void Initialize(webappContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Category.Any())
            {
                return;   // DB has been seeded
            }
            var categories = new Category[]
            {
                new Category{ Name = "Giáo Dục"},
                new Category{ Name = "Truyền Thuyết"},
                new Category{ Name = "Kinh Dị"}

            };
            foreach (Category s in categories)
            {
                context.Category.Add(s);
            }
            context.SaveChanges();
            var products = new Product[]
            {
                new Product { Name = "Chemistry", Price = 3, Unit = "3",
                    CategoryID = categories.Single( s => s.Name == "Giáo Dục").ID
                },
                new Product { Name = "Chemistry", Price = 1, Unit = "3",
                    CategoryID = categories.Single( s => s.Name == "Giáo Dục").ID
                },
                new Product { Name = "Chemistry", Price = 5, Unit = "4",
                    CategoryID = categories.Single( s => s.Name == "Giáo Dục").ID
                },
                new Product { Name = "Chemistry", Price = 4, Unit = "3",
                    CategoryID = categories.Single( s => s.Name == "Kinh Dị").ID
                }
            };

            foreach (Product c in products)
            {
                context.Product.Add(c);
            }
            context.SaveChanges();

        }
    }
}
