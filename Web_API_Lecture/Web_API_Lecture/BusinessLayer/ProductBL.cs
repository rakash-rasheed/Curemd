using Web_API_Lecture.DataAccessLayer;
using Web_API_Lecture.Models;

namespace Web_API_Lecture.BusinessLayer
{
    public class ProductBL
    {
        private readonly ProductDAL productDAL = new ProductDAL();
        public List<Product> GetProducts()
        {
            return productDAL.GetProducts();
        }

        public Product GetProduct(int id)
        {
            return productDAL.GetProduct(id);
        }

        public void AddProduct(Product product)
        {
            productDAL.AddProduct(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            var existingProduct = productDAL.GetProduct(id);
            if (existingProduct != null)
            {
                product.Id = id; // Ensure the ID remains unchanged
                productDAL.UpdateProduct(product);
            }
        }

        public void DeleteProduct(int id)
        {
            productDAL.DeleteProduct(id);
        }
    }
}
