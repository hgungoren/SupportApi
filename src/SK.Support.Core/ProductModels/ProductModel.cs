using SK.Support.Common;
using SK.Support.Faults;
using SK.Support.Products;
using System;
using System.Collections.Generic;

namespace SK.Support.ProductModels
{
    public class ProductModel: BaseEntity
    {
        public string ModelName { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public ICollection<Fault> Faults{ get; set; } 

    }
}
