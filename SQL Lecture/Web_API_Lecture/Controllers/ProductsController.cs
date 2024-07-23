using Microsoft.AspNetCore.Mvc;
using Web_API_Lecture.Models;
using Web_API_Lecture.Services;

namespace Web_API_Lecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductBL _productBL;

        public ProductsController(ProductBL productBL)
        {
            _productBL = productBL;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _productBL.GetProducts();
            return Ok(products);
        }

        // GET: api/Products/3
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productBL.GetProduct(id);

            if (product == null)
            {
                return NotFound(new { Message = "Product not found" });
            }

            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            _productBL.AddProduct(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/Products/2
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            var existingProduct = _productBL.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound(new { Message = "Product not found" });
            }

            _productBL.UpdateProduct(id, product);
            return Ok(new { Message = "Product updated successfully" });
        }

        // DELETE: api/Products/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var existingProduct = _productBL.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound(new { Message = "Product not found" });
            }

            _productBL.DeleteProduct(id);
            return Ok(new { Message = "Product deleted successfully" });
        }
    }
}
