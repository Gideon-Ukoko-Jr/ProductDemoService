namespace ProductDemoService.Controllers;
using Microsoft.AspNetCore.Mvc;
using ProductDemoService.Services;
using ProductDemoService.Models;

[Route("api/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ProductService _productService;

    public ProductsController(ProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        var products = _productService.GetMockedProducts();
        return Ok(products);
    }
}
