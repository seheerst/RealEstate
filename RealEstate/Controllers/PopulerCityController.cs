using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    }
}
