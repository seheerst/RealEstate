
using RealEstate_Api.Dtos.PopulerCityDtos;

namespace RealEstate_Api.Repositories.PopulerCityRepositories
{
    public interface IPopulerCityRepository
    {
        Task<List<ResultPopulerCityDto>> GetAllAsync();

        void CreatePopulerCity(CreatePopulerCityDto populerCityDto);

        void DeletePopulerCity(int id);

        void UpdatePopulerCity(UpdatePopulerCityDto populerCityDto);

        Task<GetByIdPopulerCityDto> GetByIdPopulerCity(int id);
    }
}
