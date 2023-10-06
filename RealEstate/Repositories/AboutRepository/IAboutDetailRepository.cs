using RealEstate_Api.Dtos.AboutDtos;

namespace RealEstate_Api.Repositories.AboutRepository
{
    public interface IAboutDetailRepository
    {
        Task<List<ResultAboutDto>> GetAllAsync();

        void CreateAbout(CreateAboutDto aboutDto);

        void DeleteAbout(int id);

        void UpdateAbout(UpdateAboutDto aboutDto);

        Task<GetByIdAboutDto> GetByIdAbout(int id);
    }
}
