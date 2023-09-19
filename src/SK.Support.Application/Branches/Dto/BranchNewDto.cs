using Abp.AutoMapper;
using Newtonsoft.Json;

namespace SK.Support.Branches.Dto
{
    [AutoMap(typeof(Branch))]
    public class BranchNewDto
    { 
        public string BirimAdi { get; set; }
        public long ObjId { get; set; }
    }
}
