using Abp.AutoMapper;

namespace SK.Support.Branches.Dto
{
    [AutoMap(typeof(Branch))]
    public class CreateBranchDto
    {
        public string BranchName { get; set; }
    }
}
