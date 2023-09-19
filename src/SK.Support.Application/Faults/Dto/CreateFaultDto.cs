using Abp.AutoMapper;
using System;

namespace SK.Support.Faults.Dto
{
    [AutoMap(typeof(Fault))]
    public class CreateFaultDto
    {
        public int FaultNumber { get; set; } 
        public Guid ProductId { get; set; }
        public Guid ProductModelId { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Type { get; set; }
        public string Region { get; set; }
        public string Branch { get; set; }
        public string FaultDescription { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
        public string OutgoingSerialNumber { get; set; }
        public DateTime OutgoingDate { get; set; }
        public string Notes { get; set; }
        public string ConsolationNumber { get; set; }  
        public Guid TechnicalServiceID { get; set; } 
    }
}
