using System.Collections.Generic;
using System.Linq;

namespace BasicFormApp.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product() {Id = 1, Name = "Product 1",Description ="Description1",IsApproved = true,Price = 100},
                new Product() {Id = 2, Name = "Product 2",Description ="Description2", IsApproved = false,Price = 200},
                new Product() {Id = 3, Name = "Product 3",Description ="Description3", IsApproved = true,Price = 300},
            };
        }

        public static List<Product> GetProducts()
        {
            return _products;
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(i => i.Id == id);
        }
    }
}