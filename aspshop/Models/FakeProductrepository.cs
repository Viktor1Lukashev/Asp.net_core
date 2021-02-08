using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspshop.Models
{
    public class FakeProductrepository: IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
        new Product{Name = "Football",Price = 25},
        new Product{Name = "Surf Board",Price = 170},
        new Product{Name = "Running Shoes",Price = 93}
        }.AsQueryable<Product>();
    }
}
