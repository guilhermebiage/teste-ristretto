using Microsoft.AspNetCore.Mvc;
using ristretto.Entities;
using ristretto.Services;

namespace ristretto.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeService.GetEmployeesAsync();

            return Ok(employees);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetEmployee(long id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);

            return Ok(employee);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            _ = employee ?? throw new ArgumentNullException(nameof(employee));

            var result = await _employeeService.CreateEmployeeAsync(employee);

            return Ok(result);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            _ = employee ?? throw new ArgumentNullException(nameof(employee));

            var result = await _employeeService.UpdateEmployeeAsync(employee);

            return Ok(result);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteEmployee(long employeeId)
        {
            var result = await _employeeService.DeleteEmployeeAsync(employeeId);

            return Ok(result);
        }
    }
}
