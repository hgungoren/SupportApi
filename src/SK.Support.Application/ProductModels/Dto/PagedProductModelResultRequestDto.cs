using Abp.Application.Services.Dto;

namespace SK.Support.ProductModels.Dto
{
    public class PagedProductModelResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
