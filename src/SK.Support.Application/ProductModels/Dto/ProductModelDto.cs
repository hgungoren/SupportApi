using Abp.AutoMapper;
using Newtonsoft.Json;
using SK.Support.Common;
using System;

namespace SK.Support.ProductModels.Dto
{
    [AutoMap(typeof(ProductModel))]
    public class ProductModelDto: BaseEntityDto
    {
        [JsonProperty("modelName")]
        public string ModelName { get; set; }
        [JsonProperty("productId")]
        public Guid ProductID { get; set; }
    }
}
