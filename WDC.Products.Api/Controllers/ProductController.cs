using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WDC.Products.Api.Controllers.Base;
using WDC.Products.Core.Features.ProductFeatures.Command.Models;
using WDC.Products.Core.Features.ProductFeatures.Query.Models;
using WDC.Products.Data.AppMetaData;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WDC.Products.Api.Controllers
{

    public class ProductController : AppControllerBase
    {
        [HttpGet(Router.ProductRouting.list)]
        public async Task<IActionResult> GetProductsList()
        {
            return Ok(await Mediator.Send(new GetProductListQuery()));
        }
        [HttpGet(Router.ProductRouting.productById)]
        public async Task<IActionResult> GetProductById([FromRoute] int Id)
        {
            return NewResult(await Mediator.Send(new GetProductByIdQuery(Id)));
        }
        [HttpPost(Router.ProductRouting.create)]
        public async Task<IActionResult> AddProduct([FromBody] AddProductCommand command)
        {
            return NewResult(await Mediator.Send(command));
        }
        [HttpPut(Router.ProductRouting.update)]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductCommand command)
        {
            return NewResult(await Mediator.Send(command));
        }
        [HttpDelete(Router.ProductRouting.delete)]
        public async Task<IActionResult> DeleteProduct([FromRoute] int Id)
        {
            return NewResult(await Mediator.Send(new DeleteProductCommand(Id)));
        }
    }
}

