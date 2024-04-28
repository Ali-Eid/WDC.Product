using System;
using MediatR;
using WDC.Products.Core.Bases.ResponseBase;
using WDC.Products.Core.Features.ProductFeatures.Query.Responses;

namespace WDC.Products.Core.Features.ProductFeatures.Query.Models
{
    public class GetProductByIdQuery : IRequest<Response<ProductResponse>>
    {
        public int ProductId { get; set; }

        public GetProductByIdQuery(int ProductId)
        {
            this.ProductId = ProductId;
        }
    }
}

