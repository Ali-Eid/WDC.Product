using System;
using WDC.Products.Data.Entities;

namespace WDC.Products.Service.ProductServices
{
    public interface IProductService
    {
        public Task<List<Product>> GetProductsListAsync();

        public Product? GetProductById(int Id);

        public Task<Product> AddProduct(Product product);

        public Task UpdateProduct(Product product);

        public Task DeleteProduct(Product product);
    }
}

