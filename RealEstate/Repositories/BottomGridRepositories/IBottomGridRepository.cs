using RealEstate_Api.Dtos.AboutServiceDtos;
using RealEstate_Api.Dtos.BottomGridDtos;

namespace RealEstate_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllAsync();

        void CreateBottomGrid(CreateBottomGridDto bottomGridDto);

        void DeleteBottomGrid(int id);

        void UpdateBottomGrid(UpdateBottomGridDto bottomGridDto);

        Task<GetByIdBottomGridDto> GetByIdBottomGrid(int id);
    }
}
