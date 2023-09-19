using Abp.Application.Services.Dto;

namespace SK.Support.Faults.Dto
{
    public class PagedFaultResultRequestDto:PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
