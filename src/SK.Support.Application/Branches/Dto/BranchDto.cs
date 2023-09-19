using Abp.AutoMapper;
using Newtonsoft.Json;
using SK.Support.Common;
using SK.Support.Enums;

namespace SK.Support.Branches.Dto
{
    [AutoMap(typeof(Branch))]
    public class BranchDto : BaseEntityDto
    {
        public string ObjId { get; set; }
        [JsonProperty("branchName")]
        public string Adi { get; set; }
        public bool IsActive { get; set; }
        public int PersonelSayisi { get; set; }
        public int ToplamSayi { get; set; }
        public int NormSayisi { get; set; }
        public string BagliOlduguSube_ObjId { get; set; }
        public int NormEksigi
        {
            get => this.PersonelSayisi - this.NormSayisi;
        }
        public bool? Aktif { get; set; }
        public KSubeTip? Tipi { get; set; }
        public KSubeTipTur? TipTur { get; set; }

        public string Tip { get => this.Tipi.ToString(); }
        public string Tur { get => this.TipTur.ToString(); }
    }
}
