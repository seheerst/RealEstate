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

        public async void CreateBottomGrid(CreateBottomGridDto bottomGridDto)
        {
            string query = "insert into BottomGrid (Title, Icon, Content) values (@title, @icon, @content)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", bottomGridDto.Title);
            parameters.Add("@icon", bottomGridDto.Icon);
            parameters.Add("@content", bottomGridDto.Content);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "Delete From BottomGrid Where BottomGridID = @bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
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

        public async Task<GetByIdBottomGridDto> GetByIdBottomGrid(int id)
        {
            string query = "Select * From BottomGrid Where BottomGridID= @bottomGridID";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIdBottomGridDto>(query, parameters);

                return value;
            }
        }

        public async void UpdateBottomGrid(UpdateBottomGridDto bottomGridDto)
        {
            string query = "Update BottomGrid Set Title= @title, Icon=@icon, Content=@content where BottomGridID = @bottomGridID";
            var parameters = new DynamicParameters();

            parameters.Add("@title", bottomGridDto.Title);
            parameters.Add("@icon", bottomGridDto.Icon);
            parameters.Add("@content", bottomGridDto.Content);

            parameters.Add("@bottomGridID", bottomGridDto.BottomGridID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
