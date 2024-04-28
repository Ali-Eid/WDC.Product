using System;
using WDC.Products.Data.Entities;
using WDC.Products.Infrastructure.Bases.RepositoryBase;

namespace WDC.Products.Service.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepositoryAsync<Product> _productRepository;

        public ProductService(IGenericRepositoryAsync<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var result = await _productRepository.AddAsync(product);
            return result;
        }

        public async Task DeleteProduct(Product product)
        {
            var trans = _productRepository.BeginTransaction();
            try
            {
                await _productRepository.DeleteAsync(product);
                await trans.CommitAsync();
            }
            catch (Exception ex)
            {
                await trans.RollbackAsync();
            }
        }

        public Product? GetProductById(int Id)
        {
            var result = _productRepository.GetTableNoTracking().Where(x => x.Id == Id).FirstOrDefault();
            return result;
        }

        public async Task<List<Product>> GetProductsListAsync()
        {
            return await Task.FromResult(_productRepository.GetTableNoTracking().ToList());
        }

        public async Task UpdateProduct(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }
    }
}

