using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.Category;

namespace DataService.Services
{
    public interface ICategoryService : IService<Category, CategoryDto, CategoryCreateDto, CategoryUpdateDto>
    {

    }
    public class CategoryService : Service<Category, CategoryDto, CategoryCreateDto, CategoryUpdateDto>, ICategoryService
    {
        public CategoryService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}