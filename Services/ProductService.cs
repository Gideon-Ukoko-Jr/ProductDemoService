namespace ProductDemoService.Services;
using System.Collections.Generic;
using ProductDemoService.Models;
public class ProductService
{
    private List<Product> _products;

    public ProductService() {
        InitializeMockData();
    }

    public List<Product> GetMockedProducts()
    {
        return _products;
    }

    private void InitializeMockData()
    {
        _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 19.99M },
            new Product { Id = 2, Name = "Product 2", Price = 29.99M },
            new Product { Id = 3, Name = "Product 3", Price = 39.99M }
        };
    }
}
