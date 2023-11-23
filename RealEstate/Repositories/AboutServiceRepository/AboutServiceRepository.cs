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

        public async void CreateAboutService(CreateAboutServiceDto aboutServiceDto)
        {
            string query = "insert into Service (ServiceName, ServiceStatus) values (@serviceName, @serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", aboutServiceDto.ServiceName);
            parameters.Add("@serviceStatus", aboutServiceDto.ServiceStatus);
       
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteAboutService(int id)
        {
            string query = "Delete From Service Where ServiceID = @serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
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

        public async Task<GetByIdAboutServiceDto> GetByIdAboutService(int id)
        {
            string query = "Select * From Service Where ServiceID= @serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIdAboutServiceDto>(query, parameters);

                return value;
            }
        }

        public async void UpdateAboutService(UpdateAboutServiceDto aboutServiceDto)
        {
            string query = "Update Service Set ServiceName= @serviceName, ServiceStatus=@serviceStatus where ServiceID = @serviceID";
            var parameters = new DynamicParameters();

            parameters.Add("@serviceName", aboutServiceDto.ServiceName);
            parameters.Add("@serviceStatus", aboutServiceDto.ServiceStatus);
   
            parameters.Add("@serviceID", aboutServiceDto.ServiceID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
