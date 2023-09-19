using SK.Support.Branches;
using SK.Support.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.Support.Regions
{
    public class Region:BaseEntity
    {
        public string Name { get; set; }
        public List<Branch> Branches { get; set; }
    }
}
