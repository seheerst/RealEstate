using Dapper;
using RealEstate_Api.Dtos.PopulerCityDtos;
using RealEstate_Api.Dtos.StepDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.StepRepositories
{
    public class StepRepository : IStepRepository
    {
        private readonly Context _context;

        public StepRepository(Context context)
        {
            _context = context;
        }
        public void CreateStep(CreateStepDto stepDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteStep(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultStepDto>> GetAllAsync()
        {
            string query = "Select * From Steps";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultStepDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdStepDto> GetByIdStep(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStep(UpdateStepDto stepDto)
        {
            throw new NotImplementedException();
        }
    }
}
