using Abp.AutoMapper;

namespace SK.Support.Regions.Dto
{
    [AutoMap(typeof(Region))]
    public class CreateRegionDto
    {
        public string RegionName { get; set; }
    }
}
