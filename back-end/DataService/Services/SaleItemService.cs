using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.SaleItem;

namespace DataService.Services
{
    public interface ISaleItemService : IService<SaleItem, SaleItemDto, SaleItemCreateDto, SaleItemUpdateDto>
    {

    }
    public class SaleItemService : Service<SaleItem, SaleItemDto, SaleItemCreateDto, SaleItemUpdateDto>, ISaleItemService
    {
        public SaleItemService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}