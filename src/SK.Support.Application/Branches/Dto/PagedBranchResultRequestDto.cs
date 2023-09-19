using Abp.Application.Services.Dto;
using System;

namespace SK.Support.Branches.Dto
{
    public class PagedBranchResultRequestDto : PagedResultRequestDto
    {
        public long Id { get; set; }
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
