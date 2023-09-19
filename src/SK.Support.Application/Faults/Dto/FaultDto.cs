using Abp.AutoMapper;
using Newtonsoft.Json;
using SK.Support.Common;
using SK.Support.TechnicalServices;
using System;

namespace SK.Support.Faults.Dto
{
    [AutoMap(typeof(Fault))]
    public class FaultDto : BaseEntityDto
    {
        [JsonProperty("faultNumber")]
        public int FaultNumber { get; set; } 
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }
        [JsonProperty("productModelId")]
        public Guid ProductModelId { get; set; }
        [JsonProperty("productName")]
        public string ProductName { get; set; }
        [JsonProperty("productModelName")]
        public string ProductModelName { get; set; }
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }
        [JsonProperty("arrivalDate")]
        public DateTime ArrivalDate { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("branch")]
        public string Branch { get; set; }
        [JsonProperty("faultDescription")]
        public string FaultDescription { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("outgoingSerialNumber")]
        public string OutgoingSerialNumber { get; set; }
        [JsonProperty("outgoingDate")]
        public DateTime OutgoingDate { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; } 
        [JsonProperty("technicalServiceId")]
        public Guid TechnicalServiceID { get; set; }  
    }
}
