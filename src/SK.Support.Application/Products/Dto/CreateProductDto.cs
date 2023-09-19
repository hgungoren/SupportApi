using Abp.AutoMapper;

namespace SK.Support.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class CreateProductDto
    {
        public string ProductName { get; set; }
    }
}
