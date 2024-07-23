using Microsoft.AspNetCore.Mvc;
using Web_API_Lecture.Models;
using Web_API_Lecture.BusinessLayer;

namespace Web_API_Lecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductBL productBL = new ProductBL();

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = productBL.GetProducts();
            return Ok(products);
        }

        // GET: api/Products/3
        [HttpGet("{id}/products")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = productBL.GetProduct(id);

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
            productBL.AddProduct(product);
            //return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
            return Ok(product);
        }

        // PUT: api/Products/2
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            var existingProduct = productBL.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound(new { Message = "Product not found" });
            }

            productBL.UpdateProduct(id, product);
            return Ok(new { Message = "Product updated successfully" });
        }

        // DELETE: api/Products/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var existingProduct = productBL.GetProduct(id);
            if (existingProduct == null)
            {
                return NotFound(new { Message = "Product not found" });
            }

            productBL.DeleteProduct(id);
            return Ok(new { Message = "Product deleted successfully" });
        }
    }
}
