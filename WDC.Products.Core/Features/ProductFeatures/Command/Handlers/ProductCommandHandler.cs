using System;
using AutoMapper;
using MediatR;
using WDC.Products.Core.Bases.ResponseBase;
using WDC.Products.Core.Features.ProductFeatures.Command.Models;
using WDC.Products.Core.Features.ProductFeatures.Query.Responses;
using WDC.Products.Data.Entities;
using WDC.Products.Service.ProductServices;

namespace WDC.Products.Core.Features.ProductFeatures.Command.Handlers
{
    public class ProductCommandHandler  :ResponseHandler , IRequestHandler<AddProductCommand , Response<ProductResponse>>,
                                                           IRequestHandler<UpdateProductCommand, Response<string>>,
                                                           IRequestHandler<DeleteProductCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        public ProductCommandHandler(IMapper mapper, IProductService productService)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<Response<ProductResponse>> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            var newProduct = await _productService.AddProduct(product);
            var productMapping = _mapper.Map<ProductResponse>(newProduct);
            return Success(productMapping);
        }

        public async Task<Response<string>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _productService.GetProductById(request.ProductId);
            if (product == null) return NotFound<string>("The product is not exist");

            var productUpdate = _mapper.Map<Product>(request);

            await _productService.UpdateProduct(productUpdate);

            return Success<string>("Updated successfully");
        }

        public async Task<Response<string>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _productService.GetProductById(request.ProductId);
            if (product == null) return NotFound<string>("The product is not exist");

            await _productService.DeleteProduct(product);

            return Success<string>("Deleted successfully");
        }
    }
}

