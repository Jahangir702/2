using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6.Models
{
    public class Cart
    {
        private static readonly Cart _instance = new Cart();

        private List<Product> _items = new List<Product>();

        public static Cart Instance => _instance;

        public IReadOnlyList<Product> Items => _items.AsReadOnly();

        public void AddToCart(Product product)
        {
            _items.Add(product);
        }
    }
}
