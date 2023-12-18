using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.Models
{
    // ProductRepository.cs
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Apple", Description = "Delicious ", Price = 10.99m },
        new Product { Id = 2, Name = "Jacket", Description = "Flexible and comfortable", Price = 20.99m },
    };

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }
        public static List<Product> SearchProduct(string filterText)
        {
          var products= _products.Where(x=>x.Name.StartsWith(filterText,StringComparison.OrdinalIgnoreCase))?.ToList();
            if (products == null) return null;
            return products;
        }
    }
    

}
