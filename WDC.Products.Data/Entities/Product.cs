using System;
namespace WDC.Products.Data.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}

