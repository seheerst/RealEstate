using Dapper;
using RealEstate_Api.Dtos.BottomGridDtos;
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
        public async void CreatePopulerCity(CreatePopulerCityDto populerCityDto)
        {
            string query = "insert into PopulerCities (ImageUrl, Title) values (@imageUrl, @title)";
            var parameters = new DynamicParameters();
            parameters.Add("@imageUrl", populerCityDto.ImageUrl);
            parameters.Add("@title", populerCityDto.Title);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopulerCity(int id)
        {
            string query = "Delete From PopulerCities Where PopulerCityID = @populerCityID";
            var parameters = new DynamicParameters();
            parameters.Add("@populerCityID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
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

        public async Task<GetByIdPopulerCityDto> GetByIdPopulerCity(int id)
        {
            string query = "Select * From PopulerCities Where PopulerCityID= @populerCityID";
            var parameters = new DynamicParameters();
            parameters.Add("@populerCityID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIdPopulerCityDto>(query, parameters);

                return value;
            }
        }

        public async void UpdatePopulerCity(UpdatePopulerCityDto populerCityDto)
        {
            string query = "Update PopulerCities Set Title= @title, ImageUrl=@imageUrl where PopulerCityID = @populerCityID";
            var parameters = new DynamicParameters();

            parameters.Add("@title", populerCityDto.Title);
            parameters.Add("@imageUrl", populerCityDto.ImageUrl);

            parameters.Add("@populerCityID", populerCityDto.PopulerCityID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
