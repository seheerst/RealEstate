using RealEstate_Api.Dtos.PopulerCityDtos;
using RealEstate_Api.Dtos.StepDtos;

namespace RealEstate_Api.Repositories.StepRepositories
{
    public interface IStepRepository
    {
        Task<List<ResultStepDto>> GetAllAsync();

        void CreateStep(CreateStepDto stepDto);

        void DeleteStep(int id);

        void UpdateStep(UpdateStepDto stepDto);

        Task<GetByIdStepDto> GetByIdStep(int id);
    }
}
