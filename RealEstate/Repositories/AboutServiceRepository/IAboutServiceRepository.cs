

using RealEstate_Api.Dtos.AboutServiceDtos;

namespace RealEstate_Api.Repositories.AboutServiceRepository
{
    public interface IAboutServiceRepository
    {
        Task<List<ResultAboutServiceDto>> GetAllAsync();

        void CreateAboutService(CreateAboutServiceDto aboutServiceDto);

        void DeleteAboutService(int id);

        void UpdateAboutService(UpdateAboutServiceDto aboutServiceDto);

        Task<GetByIdAboutServiceDto> GetByIdAboutService(int id);
    }
}
