using Dapper;
using RealEstate_Api.Dtos.AboutServiceDtos;
using RealEstate_Api.Dtos.BottomGridDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {

        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public void CreateBottomGrid(CreateBottomGridDto bottomGridDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDto>> GetAllAsync()
        {

            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdBottomGridDto> GetByIdBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDto bottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
