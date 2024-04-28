using System;
using MediatR;
using WDC.Products.Core.Bases.ResponseBase;

namespace WDC.Products.Core.Features.ProductFeatures.Command.Models
{
    public class UpdateProductCommand : IRequest<Response<string>>
    {
        public int ProductId { get; set; }

        public required string Name { get; set; }

        public decimal Price { get; set; }
    }
}

