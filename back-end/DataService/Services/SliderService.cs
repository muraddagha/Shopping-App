using AutoMapper;
using DataService.Data;
using DataService.Data.Entities;
using DataService.dtos.Slider;

namespace DataService.Services
{
    public interface ISliderService : IService<Slider, SliderDto, SliderCreateDto, SliderUpdateDto>
    {

    }
    public class SliderService : Service<Slider, SliderDto, SliderCreateDto, SliderUpdateDto>, ISliderService
    {
        public SliderService(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}