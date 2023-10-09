using Dapper;
using RealEstate_Api.Dtos.PopulerCityDtos;
using RealEstate_Api.Dtos.TestimonialDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }
        public void CreateTestimonial(CreateTestimonialDto testimonialDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTestimonial(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            string query = "Select * From Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdTestimonialDto> GetByIdTestimonial(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTestimonial(UpdateTestimonialDto testimonialDto)
        {
            throw new NotImplementedException();
        }
    }
}
