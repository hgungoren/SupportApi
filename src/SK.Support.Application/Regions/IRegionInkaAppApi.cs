using Refit;
using SK.Support.Regions.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SK.Support.Regions
{ 
    public interface IRegionInkaAppApi
    {
        [Get("/getAreaByType/{id}")]
        Task<IEnumerable<RegionInkaDto>> GetAreaByType(string id);
    }
}
