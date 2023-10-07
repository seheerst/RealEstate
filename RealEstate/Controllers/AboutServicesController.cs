using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Dtos.AboutServiceDtos;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Repositories.AboutServiceRepository;
using RealEstate_Api.Repositories.CategoryRepository;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutServicesController : ControllerBase
    {
        private readonly IAboutServiceRepository _aboutServiceRepository;

        public AboutServicesController(IAboutServiceRepository aboutServiceRepository)
        {
            _aboutServiceRepository = aboutServiceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _aboutServiceRepository.GetAllAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateAboutServiceDto createServiceDto)
        {
            _aboutServiceRepository.CreateAboutService(createServiceDto);
            return Ok("Servis Eklendi");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            _aboutServiceRepository.DeleteAboutService(id);
            return Ok("Servis Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateAboutServiceDto updateServiceDto)
        {
            _aboutServiceRepository.UpdateAboutService(updateServiceDto);
            return Ok("Servis güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdService(int id)
        {
            var value = await _aboutServiceRepository.GetByIdAboutService(id);

            return Ok(value);

        }
    }
}
