using SK.Support.Common;
using SK.Support.ProductModels;
using SK.Support.TechnicalServices;
using System;

namespace SK.Support.Faults
{
    public class Fault : BaseEntity
    {
        public int FaultNumber { get; set; }
        public string FormNumber { get; set; } 
        public Guid ProductModelId { get; set; }
        public ProductModel ProductModel { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Type { get; set; }
        public string Region { get; set; }
        public string Branch { get; set; }
        public string FaultDescription { get; set; } 
        public Guid TechnicalServiceId { get; set; }
        public TechnicalService TechnicalService { get; set; } 
        public string Status { get; set; }
        public string Result { get; set; }
        public string OutgoingSerialNumber { get; set; }
        public DateTime OutgoingDate { get; set; }
        public string Notes { get; set; }
        public string ConsolationNumber { get; set; }
        public int Counter { get; set; } 
        public string ReplacementSent { get; set; }
    }
}
