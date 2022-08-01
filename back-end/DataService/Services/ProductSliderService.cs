using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.ProductSlider;

namespace DataService.Services
{
    public interface IProductSliderService : IService<ProductSlider, ProductSliderDto, ProductSliderCreateDto, ProductSliderUpdateDto>
    {

    }
    public class ProductSliderService : Service<ProductSlider, ProductSliderDto, ProductSliderCreateDto, ProductSliderUpdateDto>, IProductSliderService
    {
        public ProductSliderService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}