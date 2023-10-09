using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.StepRepositories;
using RealEstate_Api.Repositories.TestimonialRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepController : ControllerBase
    {
        private readonly IStepRepository _stepRepository;

        public StepController(IStepRepository stepRepository)
        {
            _stepRepository = stepRepository;
        }

        [HttpGet]
        public async Task<IActionResult> AboutDetailList()
        {
            var values = await _stepRepository.GetAllAsync();
            return Ok(values);
        }
    }
}
