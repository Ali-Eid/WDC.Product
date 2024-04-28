using System;
using MediatR;
using WDC.Products.Core.Bases.ResponseBase;

namespace WDC.Products.Core.Features.ProductFeatures.Command.Models
{
    public class DeleteProductCommand : IRequest<Response<string>>
    {
        public int ProductId { get; set; }

        public DeleteProductCommand(int ProductId)
        {
            this.ProductId = ProductId;
        }
    }
}

