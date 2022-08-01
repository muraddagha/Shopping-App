using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.ProductOption;

namespace DataService.Services
{
    public interface IProductOptionService : IService<ProductOption, ProductOptionDto, ProductOptionCreateDto, ProductOptionUpdateDto>
    {

    }

    public class ProductOptionService : Service<ProductOption, ProductOptionDto, ProductOptionCreateDto, ProductOptionUpdateDto>, IProductOptionService
    {
        public ProductOptionService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}