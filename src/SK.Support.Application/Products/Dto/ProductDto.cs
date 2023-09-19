using Abp.AutoMapper;
using Newtonsoft.Json;
using SK.Support.Common;

namespace SK.Support.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto:BaseEntityDto
    {
        [JsonProperty("productName")]
        public string ProductName { get; set; }
    }
}
