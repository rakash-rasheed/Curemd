using Web_API_Lecture.DataAccessLayer;
using Web_API_Lecture.Models;

namespace Web_API_Lecture.Services
{
    public class ProductBL
    {
        private readonly ProductDAL _productDAL;

        public ProductBL(ProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public List<Product> GetProducts()
        {
            return _productDAL.GetProducts();
        }

        public Product GetProduct(int id)
        {
            return _productDAL.GetProduct(id);
        }

        public void AddProduct(Product product)
        {
            _productDAL.AddProduct(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            var existingProduct = _productDAL.GetProduct(id);
            if (existingProduct != null)
            {
                product.Id = id; // Ensure the ID remains unchanged
                _productDAL.UpdateProduct(product);
            }
        }

        public void DeleteProduct(int id)
        {
            _productDAL.DeleteProduct(id);
        }
    }
}
