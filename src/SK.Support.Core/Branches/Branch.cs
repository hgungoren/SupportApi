using SK.Support.Common;
using SK.Support.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.Support.Branches
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public Guid RegionID { get; set; }
        public Region Region { get; set; }
    }
}
