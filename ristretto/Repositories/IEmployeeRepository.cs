using ristretto.Entities;

namespace ristretto.Repositories
{
    public interface IEmployeeRepository : IDisposable
    {
        Task<IEnumerable<Employee>> GetEmployeesAsync();

        Task<IEnumerable<Employee>> GetEmployeesByCompanyAsync(long companyId);

        Task<Employee> GetEmployeeByIdAsync(long employeeId);

        Task<Employee> InsertEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(long employeeId);
    }
}
