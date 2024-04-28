using System;
using AutoMapper;
using WDC.Products.Core.Features.ProductFeatures.Query.Responses;
using WDC.Products.Data.Entities;

namespace WDC.Products.Core.Mapping.ProductMapping
{
    public partial class ProductProfile : Profile
    {
        void GetProductListMapping()
        {
            CreateMap<Product, ProductResponse>();
        }
    }
}

