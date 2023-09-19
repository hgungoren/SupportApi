using Abp.Application.Services.Dto;

namespace SK.Support.Regions.Dto
{
    public class PagedRegionResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
