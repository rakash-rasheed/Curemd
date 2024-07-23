using Web_API_Lecture.Models;

namespace Web_API_Lecture.DataAccessLayer
{
    public class ProductDAL
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "A high-performance laptop", Price = 999.99m, ManufacturingDate = DateTime.UtcNow },
            new Product { Id = 2, Name = "Smartphone", Description = "A latest model smartphone", Price = 699.99m, ManufacturingDate = DateTime.UtcNow },
            new Product { Id = 3, Name = "SmartWatch", Description = "A high-performance watch", Price = 599.99m, ManufacturingDate = DateTime.UtcNow },
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.ManufacturingDate = product.ManufacturingDate;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = products.First(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
