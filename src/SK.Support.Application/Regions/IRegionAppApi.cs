using Refit;
using SK.Support.Regions.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SK.Support.Regions
{
    [Headers("Content-Type: application/json")]
    public interface IRegionAppApi
    {
        [Get("/KSube/KBolge")]
        Task<IEnumerable<RegionDto>> GetAll(); 
    }
}
