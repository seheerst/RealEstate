using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.PopulerCityDtos;
using RealEstate_Api.Repositories.AboutDetailRepository;
using RealEstate_Api.Repositories.PopulerCityRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulerCityController : ControllerBase
    {
        private readonly IPopulerCityRepository _populerCityRepository;

        public PopulerCityController(IPopulerCityRepository populerCityRepository)
        {
            _populerCityRepository = populerCityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopulerCityList()
        {
            var values = await _populerCityRepository.GetAllAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePopulerCity(CreatePopulerCityDto createPopulerCityDto)
        {
            _populerCityRepository.CreatePopulerCity(createPopulerCityDto);
            return Ok("Populer şehir Eklendi");
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopulerCity(int id)
        {
            _populerCityRepository.DeletePopulerCity(id);
            return Ok("Populer şehir Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopulerCity(UpdatePopulerCityDto updatePopulerCityDto)
        {
            _populerCityRepository.UpdatePopulerCity(updatePopulerCityDto);
            return Ok("Populer şehir güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdPopulerCity(int id)
        {
            var value = await _populerCityRepository.GetByIdPopulerCity(id);

            return Ok(value);

        }
    }
}
