using Refit;
using SK.Support.Faults.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SK.Support.Faults
{
    [Headers("Content-Type: application/json")]
    public interface IFaultAppApi
    {
        [Get("/ksube/GetById/{id}")]
        Task<FaultNewDto> GetById(string id);
    }
}
