using Abp.AutoMapper;

namespace SK.Support.TechnicalServices.Dto
{
    [AutoMap(typeof(TechnicalService))]
    public class CreateTechnicalServiceDto
    {
        public string Name { get; set; }
    }
}
