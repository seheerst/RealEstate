using RealEstate_Api.Dtos.AboutDetailDtos;

namespace RealEstate_Api.Repositories.AboutDetailRepository
{
    public interface IAboutDetailRepository
    {
        Task<List<ResultAboutDto>> GetAllAsync();

        void CreateAbout(CreateAboutDto aboutDto);

        void DeleteAbout(int id);

        void UpdateAbout(UpdateAboutDto aboutDto);

        Task<GetByIdAboutDto> GetByIdAboutDetail(int id);
    }
}
