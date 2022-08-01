using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.Settings;

namespace DataService.Services
{
    public interface ISettingsService : IService<Settings, SettingsDto, SettingsCreateDto, SettingsUpdateDto>
    {

    }
    public class SettingsService : Service<Settings, SettingsDto, SettingsCreateDto, SettingsUpdateDto>, ISettingsService
    {
        public SettingsService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}