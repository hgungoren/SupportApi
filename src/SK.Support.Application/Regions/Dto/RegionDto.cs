using Abp.AutoMapper;
using Newtonsoft.Json;
using SK.Support.Common;
using SK.Support.Enums;

namespace SK.Support.Regions.Dto
{
    [AutoMap(typeof(Region))]
    public class RegionDto : BaseEntityDto
    {
        [JsonProperty("id")]
        public string ObjId { get; set; }
        [JsonProperty("regionName")]
        public string Adi { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        [JsonProperty("personelCount")]
        public int PersonelSayisi { get; set; }
        [JsonProperty("totalCount")]
        public int ToplamSayi { get; set; }
        [JsonProperty("normCount")]
        public int NormSayisi { get; set; }
        [JsonProperty("normShort")]
        public int NormEksigi
        {
            get => this.PersonelSayisi - this.NormSayisi;
        }
        [JsonProperty("active")]
        public bool? Aktif { get; set; }
        [JsonProperty("type")]
        public KSubeTip? Tipi { get; set; }
        [JsonProperty("typeType")]
        public KSubeTipTur? TipTur { get; set; }
        [JsonProperty("types")]
        public string Tip { get; set; }
        [JsonProperty("typess")]
        public string Tur { get; set; }
    }
}
