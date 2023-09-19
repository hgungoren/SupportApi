using Refit;
using SK.Support.Branches.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SK.Support.Branches
{
    [Headers("Content-Type: application/json")]
    public interface IBranchAppApi
    {
        [Get("/GetBranchesById/{id}")]
        Task<IEnumerable<BranchNewDto>> GetAll(long id);
    }
}
