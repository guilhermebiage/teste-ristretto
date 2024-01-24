using ristretto.Entities;

namespace ristretto.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeByIdAsync(long id);

        Task<IEnumerable<Employee>> GetEmployeesByCompany(long companyId);

        Task<Employee> CreateEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(long id);
    }
}
