using SK.Support.Common;
using SK.Support.Faults;
using System.Collections.Generic;

namespace SK.Support.TechnicalServices
{
    public class TechnicalService:BaseEntity
    {
        public string Name { get; set; } 
        public ICollection<Fault> Faults { get; set; }
    }
}
