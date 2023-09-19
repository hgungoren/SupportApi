using Abp.AutoMapper;

namespace SK.Support.Faults.Dto
{
    [AutoMap(typeof(Fault))]
    public class FaultNewDto
    {
        public string Adi { get; set; } 
    }
}
