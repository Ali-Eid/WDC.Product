using System;
using MediatR;
using WDC.Products.Core.Bases.ResponseBase;
using WDC.Products.Core.Features.ProductFeatures.Query.Responses;

namespace WDC.Products.Core.Features.ProductFeatures.Command.Models
{
    public class AddProductCommand : IRequest<Response<ProductResponse>>
    {
        public required string Name { get; set; }

        public decimal Price { get; set; }
    }
}

