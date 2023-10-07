using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.AboutDetailDtos;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Repositories.AboutDetailRepository;
using RealEstate_Api.Repositories.CategoryRepository;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutDetailController : ControllerBase
    {
        private readonly IAboutDetailRepository _aboutDetailRepository;

        public AboutDetailController(IAboutDetailRepository aboutDetailRepository)
        {
            _aboutDetailRepository = aboutDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> AboutDetailList()
        {
            var values = await _aboutDetailRepository.GetAllAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutDetail(CreateAboutDto createAboutDto)
        {
            _aboutDetailRepository.CreateAbout(createAboutDto);
            return Ok("AboutDetail Eklendi");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteAboutDetail(int id)
        {
            _aboutDetailRepository.DeleteAbout(id);
            return Ok("About Detail Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _aboutDetailRepository.UpdateAbout(updateAboutDto);
            return Ok("About Detail güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAbout(int id)
        {
            var value = await _aboutDetailRepository.GetByIdAboutDetail(id);

            return Ok(value);

        }
    }
}
