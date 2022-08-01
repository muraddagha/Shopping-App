using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.Brand;

namespace DataService.Services
{
    public interface IBrandService : IService<Brand, BrandDto, BrandCreateDto, BrandUpdateDto>
    {

    }
    public class BrandService : Service<Brand, BrandDto, BrandCreateDto, BrandUpdateDto>, IBrandService
    {
        public BrandService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}