using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.Product;

namespace DataService.Services
{
    public interface IProductService : IService<Product, ProductDto, ProductCreateDto, ProductUpdateDto>
    {

    }
    public class ProductService : Service<Product, ProductDto, ProductCreateDto, ProductUpdateDto>, IProductService
    {
        public ProductService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}