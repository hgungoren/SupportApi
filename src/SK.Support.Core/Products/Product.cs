using SK.Support.Common;
using SK.Support.Faults;
using SK.Support.ProductModels;
using System.Collections.Generic;

namespace SK.Support.Products
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public ICollection<ProductModel> ProductModels{ get; set; } 
    }
}
