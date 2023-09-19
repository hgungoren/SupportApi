using Abp.AutoMapper;
using Newtonsoft.Json;
using SK.Support.Common;

namespace SK.Support.TechnicalServices.Dto
{
    [AutoMap(typeof(TechnicalService))]
    public class TechnicalServiceDto : BaseEntityDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
