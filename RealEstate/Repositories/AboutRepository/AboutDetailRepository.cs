using Dapper;
using RealEstate_Api.Dtos.AboutDtos;
using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Models.DapperContext;

namespace RealEstate_Api.Repositories.AboutRepository
{
    public class AboutDetailRepository: IAboutDetailRepository
    {
        private readonly Context _context;

        public AboutDetailRepository(Context context)
        {
            _context = context;
        }

        public async void CreateAbout(CreateAboutDto aboutDto)
        {
            string query = "insert into AboutDetail (Title, Subtitle, Description1, Description2) values (@title, @subtitle, @description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", aboutDto.Title);
            parameters.Add("@subtitle", aboutDto.SubTitle);
            parameters.Add("@description1", aboutDto.Description1);
            parameters.Add("@description2", aboutDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteAbout(int id)
        {
            string query = "Delete From AboutDetail Where AboutID =@aboutID";
            var parameters = new DynamicParameters();
            parameters.Add("@aboutID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            string query = "Select * From AboutDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultAboutDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdAboutDto> GetByIdAbout(int id)
        {
            string query = "Select * From AboutDetail Where AboutID= @aboutID";
            var parameters = new DynamicParameters();
            parameters.Add("@aboutID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIdAboutDto>(query, parameters);

                return value;
            }
        }

        public async void UpdateAbout(UpdateAboutDto aboutDto)
        {
            string query = "Update AboutDetail Set Title= @title, SubTitle=@subTitle, Description1 = @description1, Description2= @description2 where AboutID = @aboutID";
            var parameters = new DynamicParameters();
            
            parameters.Add("@title", aboutDto.Title);
            parameters.Add("@subTitle", aboutDto.SubTitle);
            parameters.Add("@description1", aboutDto.Description1);
            parameters.Add("@description2", aboutDto.Description2);
            parameters.Add("@aboutID", aboutDto.AboutID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
