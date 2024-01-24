using ristretto.Entities;
using ristretto.Repositories;

namespace ristretto.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            _ = employee ?? throw new ArgumentNullException(nameof(employee));

            return await _employeeRepository.InsertEmployeeAsync(employee);
        }

        public async Task<Employee> DeleteEmployeeAsync(long id)
        {
            return await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task<Employee> GetEmployeeByIdAsync(long id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeesAsync();
        }

        public Task<IEnumerable<Employee>> GetEmployeesByCompany(long companyId)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            _ = employee ?? throw new ArgumentNullException(nameof(employee));

            return await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
