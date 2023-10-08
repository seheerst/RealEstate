using Dapper;
using RealEstate_Api.Dtos.PopulerCityDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.PopulerCityRepositories
{
    public class PopulerCityRepository : IPopulerCityRepository
    {
        private readonly Context _context;

        public PopulerCityRepository(Context context)
        {
            _context = context;
        }
        public void CreatePopulerCity(CreatePopulerCityDto populerCityDto)
        {
            throw new NotImplementedException();
        }

        public void DeletePopulerCity(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopulerCityDto>> GetAllAsync()
        {
            string query = "Select * From PopulerCities";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopulerCityDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdPopulerCityDto> GetByIdPopulerCity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopulerCity(UpdatePopulerCityDto aboutDto)
        {
            throw new NotImplementedException();
        }
    }
}
