using System.Threading.Tasks;
using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.About;
using Shared.Pagination;

namespace DataService.Services
{
    public interface IAboutService : IService<About, AboutDto, AboutCreateDto, AboutUpdateDto>
    {
    }
    public class AboutService : Service<About, AboutDto, AboutCreateDto, AboutUpdateDto>, IAboutService
    {
        public AboutService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}