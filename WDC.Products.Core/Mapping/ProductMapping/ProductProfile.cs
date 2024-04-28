using System;
using AutoMapper;

namespace WDC.Products.Core.Mapping.ProductMapping
{
    public partial class ProductProfile : Profile
    {
        public ProductProfile()
        {
            GetProductListMapping();
            AddProductMapping();
            UpdateProductMapping();
        }
    }
}

