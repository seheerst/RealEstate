using RealEstate_Api.Dtos.CategoryDtos;
using RealEstate_Api.Dtos.EmployeeDtos;

namespace RealEstate_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllAsync();

        void CreateEmployee(CreateEmployeeDto employeeDto);

        void DeleteEmployee(int id);

        void UpdateEmployee(UpdateEmployeeDto employeeDto);

        Task<GetByIdEmployeeDto> GetByIdEmployee(int id);
    }
}
