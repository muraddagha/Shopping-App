using System.Threading.Tasks;
using DataService.dtos.Settings;
using DataService.dtos.Slider;
using DataService.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Pagination;

namespace Api.Controllers.v1
{
    public class SettingController : BaseController
    {
        private readonly ISettingsService _service;
        private readonly ISliderService _sliderService;
        public SettingController(ISettingsService service, ISliderService sliderService)
        {
            _service = service;
            _sliderService = sliderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSettings([FromQuery] Pagination pagination) => Ok(await _service.GetAllAsync(pagination));


        [HttpGet("{id}")]
        public async Task<IActionResult> GetSettingById([FromRoute] int id) => Ok(await _service.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> AddSetting([FromBody] SettingsCreateDto dto) => Ok(await _service.CreateAsync(dto));

        [HttpPut]
        public IActionResult UpdateSetting([FromBody] SettingsUpdateDto dto) => Ok(_service.Update(dto));

        [HttpDelete("{id}")]
        public IActionResult RemoveSetting([FromRoute] int id) => Ok(_service.Remove(id));



        [HttpGet("Slider")]
        public async Task<IActionResult> GetAllSliders([FromQuery] Pagination pagination) => Ok(await _sliderService.GetAllAsync(pagination));


        [HttpGet("Slider/{id}")]
        public async Task<IActionResult> GetSliderById([FromRoute] int id) => Ok(await _sliderService.GetByIdAsync(id));

        [HttpPost("Slider")]
        public async Task<IActionResult> AddSlider([FromBody] SliderCreateDto dto) => Ok(await _sliderService.CreateAsync(dto));

        [HttpPut("Slider")]
        public IActionResult UpdateSlider([FromBody] SliderUpdateDto dto) => Ok(_sliderService.Update(dto));

        [HttpDelete("Slider/{id}")]
        public IActionResult RemoveSlider([FromRoute] int id) => Ok(_sliderService.Remove(id));
    }
}