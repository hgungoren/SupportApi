using Abp.Application.Services.Dto;

namespace SK.Support.TechnicalServices.Dto
{
    public class PagedTechnicalServiceResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
