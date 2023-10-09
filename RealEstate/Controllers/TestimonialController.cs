using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Api.Repositories.AboutDetailRepository;
using RealEstate_Api.Repositories.TestimonialRepositories;

namespace RealEstate_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> AboutDetailList()
        {
            var values = await _testimonialRepository.GetAllAsync();
            return Ok(values);
        }
    }
}
