using System;
using AutoMapper;
using WDC.Products.Core.Features.ProductFeatures.Command.Models;
using WDC.Products.Data.Entities;

namespace WDC.Products.Core.Mapping.ProductMapping
{
    public partial class ProductProfile : Profile
    {
       void AddProductMapping()
        {
            CreateMap<AddProductCommand, Product>();
        }
    }
}

