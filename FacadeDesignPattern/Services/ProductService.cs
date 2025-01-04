using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Services
{
    public static class ProductService
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Code = "Product 1", Quantity = 10 },
                new Product { Code = "Product 2", Quantity = 20 },
                new Product { Code = "Product 3", Quantity = 30 }
            };
        }
    }
}
