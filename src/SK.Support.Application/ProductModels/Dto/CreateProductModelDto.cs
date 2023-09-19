using Abp.AutoMapper;
using System;

namespace SK.Support.ProductModels.Dto
{
    [AutoMap(typeof(ProductModel))]
    public class CreateProductModelDto
    {
        public string ModelName { get; set; }
        public Guid ProductID { get; set; }
    }
}
