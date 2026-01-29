using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Models;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 60000, IsAvailable = true },
        new Product { Id = 2, Name = "Mobile", Category = "Electronics", Price = 25000, IsAvailable = true }
    };

    // 1. GET: api/products (Saare products lene ke liye)
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(products);
    }

    // 2. GET: api/products/{id} (Ek specific product search karne ke liye)
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound("Product nahi mila!");
        return Ok(product);
    }

    // 3. POST: api/products (Naya product add karne ke liye)
    [HttpPost]
    public IActionResult Create(Product newProduct)
    {
        products.Add(newProduct);
        return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
    }

    // 4. PUT: api/products/{id} (Existing product update karne ke liye)
    [HttpPut("{id}")]
    public IActionResult Update(int id, Product updatedProduct)
    {
        var existingProduct = products.FirstOrDefault(p => p.Id == id);
        if (existingProduct == null) return NotFound();

        existingProduct.Name = updatedProduct.Name;
        existingProduct.Category = updatedProduct.Category;
        existingProduct.Price = updatedProduct.Price;
        existingProduct.IsAvailable = updatedProduct.IsAvailable;

        return NoContent();
    }

    // 5. DELETE: api/products/{id} (Product delete karne ke liye)
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound();

        products.Remove(product);
        return Ok($"Product {id} delete ho gaya.");
    }
}