using Dapper;
using RealEstate_Api.Dtos.AboutDetailDtos;
using RealEstate_Api.Dtos.AboutServiceDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.AboutServiceRepository
{
    public class AboutServiceRepository : IAboutServiceRepository
    {
        private readonly Context _context;

        public AboutServiceRepository(Context context)
        {
            _context = context;
        }

        public void CreateAboutService(CreateAboutServiceDto aboutServiceDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteAboutService(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultAboutServiceDto>> GetAllAsync()
        {

            string query = "Select * From Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultAboutServiceDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdAboutServiceDto> GetByIdAboutService(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAboutService(UpdateAboutServiceDto aboutServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
