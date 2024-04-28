using System;
namespace WDC.Products.Data.AppMetaData
{
    public static class Router
    {
        public const string root = "api";
        public const string version = "v1";
        public const string byId = "/{Id}";

        public const string rule = root + "/" + version + "/";

        public static class ProductRouting
        {
            public const string prefix = rule + "product";
            public const string list = prefix + "/list";
            public const string productById = prefix + byId;
            public const string create = prefix + "/create";
            public const string update = prefix + "/update";
            public const string delete = prefix + "/delete" + byId;
        }
    }
}

