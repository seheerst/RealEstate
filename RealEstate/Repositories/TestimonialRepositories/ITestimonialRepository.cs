using RealEstate_Api.Dtos.PopulerCityDtos;
using RealEstate_Api.Dtos.TestimonialDtos;

namespace RealEstate_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();

        void CreateTestimonial(CreateTestimonialDto testimonialDto);

        void DeleteTestimonial(int id);

        void UpdateTestimonial(UpdateTestimonialDto testimonialDto);

        Task<GetByIdTestimonialDto> GetByIdTestimonial(int id);
    }
}
