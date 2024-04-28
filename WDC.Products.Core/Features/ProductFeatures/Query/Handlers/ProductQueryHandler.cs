using System;
using AutoMapper;
using MediatR;
using WDC.Products.Core.Bases.ResponseBase;
using WDC.Products.Core.Features.ProductFeatures.Query.Models;
using WDC.Products.Core.Features.ProductFeatures.Query.Responses;
using WDC.Products.Service.ProductServices;

namespace WDC.Products.Core.Features.ProductFeatures.Query.Handlers
{
    public class ProductQueryHandler : ResponseHandler , IRequestHandler<GetProductListQuery, Response<List<ProductResponse>>>,
                                                         IRequestHandler<GetProductByIdQuery, Response<ProductResponse>>
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;
        public ProductQueryHandler(IMapper mapper ,IProductService productService)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<Response<List<ProductResponse>>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            var products = await _productService.GetProductsListAsync();
            var productsMapping = _mapper.Map<List<ProductResponse>>(products);
            return Success(productsMapping);
        }

        public async Task<Response<ProductResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product =  _productService.GetProductById(request.ProductId);
            if (product == null) return NotFound<ProductResponse>("The product is not exist");
            var productMapping = _mapper.Map<ProductResponse>(product);
            return Success(productMapping);
        }
    }
}

