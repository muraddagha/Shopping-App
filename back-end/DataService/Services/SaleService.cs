using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.Sale;

namespace DataService.Services
{
    public interface ISaleService : IService<Sale, SaleDto, SaleCreateDto, SaleUpdateDto>
    {

    }
    public class SaleService : Service<Sale, SaleDto, SaleCreateDto, SaleUpdateDto>, ISaleService
    {
        public SaleService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}