using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Refit;
using SK.Support.Faults.Dto;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SK.Support.Faults
{
    public class FaultAppService : AsyncCrudAppService<Fault, FaultDto, Guid, PagedFaultResultRequestDto, CreateFaultDto, FaultDto>, IFaultAppService
    {
        private Mapper _mapper;
        public FaultAppService(IRepository<Fault, Guid> repository) : base(repository)
        {
            _mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UpdateFaultDto, FaultDto>();
            }));
        }

        public override async Task<PagedResultDto<FaultDto>> GetAllAsync(PagedFaultResultRequestDto input)
        {
            string service_URL = "https://gateway.suratkargo.com.tr";
            var service = RestService.For<IFaultAppApi>(service_URL);


            var result = await Repository
                .GetAllIncluding(x => x.ProductModel)
                .Include(x => x.ProductModel.Product)
                .Include(x => x.TechnicalService)
                .Select(x => new FaultDto
                {
                    ProductName = x.ProductModel.Product.ProductName,
                    ProductModelName = x.ProductModel.ModelName,
                    ArrivalDate = x.ArrivalDate,
                    Branch = x.Branch, 
                    CreationTime = x.CreationTime,
                    CreatorUserId = x.CreatorUserId,
                    FaultDescription = x.FaultDescription,
                    FaultNumber = x.FaultNumber, 
                    Id = x.Id,
                    LastModificationTime = x.LastModificationTime,
                    LastModifierUserId = x.LastModifierUserId,
                    Notes = x.Notes,
                    OutgoingDate = x.OutgoingDate,
                    OutgoingSerialNumber = x.OutgoingSerialNumber,
                    ProductId = x.ProductModel.Product.Id,
                    ProductModelId = x.ProductModel.Id,
                    Region = (service.GetById(x.Region)).Result.Adi, 
                    Result = x.Result,
                    SerialNumber = x.SerialNumber,
                    Status = x.TechnicalService.Name,
                    TechnicalServiceID = x.TechnicalServiceId,
                    Type = x.Type,
                })
                .ToListAsync();
            return new PagedResultDto<FaultDto>
            {
                TotalCount = result.Count(),
                Items = result,
            };
        }
        public override async Task<FaultDto> GetAsync(EntityDto<Guid> input)
        {
            string service_URL = "https://gateway.suratkargo.com.tr";
            var service = RestService.For<IFaultAppApi>(service_URL);
            FaultDto faultDto = new FaultDto();

            var result = Repository
                .GetAllIncluding(x => x.ProductModel)
                .Include(x => x.ProductModel.Product)
                .Include(x => x.TechnicalService)
                .Select(x => new FaultDto
                {
                    ProductName = x.ProductModel.Product.ProductName,
                    ProductModelName = x.ProductModel.ModelName,
                    ArrivalDate = x.ArrivalDate,
                    Branch = x.Branch, 
                    CreationTime = x.CreationTime,
                    CreatorUserId = x.CreatorUserId,
                    FaultDescription = x.FaultDescription,
                    FaultNumber = x.FaultNumber, 
                    Id = x.Id,
                    LastModificationTime = x.LastModificationTime,
                    LastModifierUserId = x.LastModifierUserId,
                    Notes = x.Notes,
                    OutgoingDate = x.OutgoingDate,
                    OutgoingSerialNumber = x.OutgoingSerialNumber,
                    ProductId = x.ProductModel.Product.Id,
                    ProductModelId = x.ProductModel.Id,
                    Region = (service.GetById(x.Region)).Result.Adi, 
                    Result = x.Result,
                    SerialNumber = x.SerialNumber,
                    Status = x.TechnicalService.Name,
                    TechnicalServiceID = x.TechnicalServiceId,
                    Type = x.Type,
                });

            foreach (var item in result)
            {
                faultDto.ProductName = item.ProductName;
                faultDto.ProductModelName = item.ProductModelName;
                faultDto.ArrivalDate = item.ArrivalDate;
                faultDto.Branch = item.Branch;  
                faultDto.CreationTime = item.CreationTime;
                faultDto.CreatorUserId = item.CreatorUserId;
                faultDto.FaultDescription = item.FaultDescription;
                faultDto.FaultNumber = item.FaultNumber; 
                faultDto.Id = item.Id;
                faultDto.LastModificationTime = item.LastModificationTime;
                faultDto.LastModifierUserId = item.LastModifierUserId;
                faultDto.Notes = item.Notes;
                faultDto.OutgoingDate = item.OutgoingDate;
                faultDto.OutgoingSerialNumber = item.OutgoingSerialNumber;
                faultDto.ProductId = item.ProductId;
                faultDto.ProductModelId = item.ProductModelId;
                faultDto.Region = item.Region; 
                faultDto.Result = item.Result;
                faultDto.SerialNumber = item.SerialNumber;
                faultDto.Status = item.Status;
                faultDto.TechnicalServiceID = item.TechnicalServiceID;
                faultDto.Type = item.Type; 
            }
             
            return faultDto;
             
        }
         
        

        //protected override IQueryable<Fault> CreateFilteredQuery(PagedFaultResultRequestDto input)
        //{
        //    var result = base.CreateFilteredQuery(input).Include(x => x.Product).ThenInclude(x => x.ProductModels);
        //    return result;
        //}
    }
}
