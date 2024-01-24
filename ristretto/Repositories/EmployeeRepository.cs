using Microsoft.EntityFrameworkCore;
using ristretto.Configuration;
using ristretto.Entities;

namespace ristretto.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetEmployeeByIdAsync(long employeeId)
        {
            return await _context.Employees.FindAsync(employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByCompanyAsync(long companyId)
        {
            return await _context.Employees.Where(e => e.Company.Id == companyId).ToListAsync();
        }

        public async Task<Employee> InsertEmployeeAsync(Employee employee)
        {
            _ = employee ?? throw new ArgumentNullException(nameof(employee));

            _ = _context.Employees.Add(employee);
            _ = await _context.SaveChangesAsync();

            return employee;
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            _ = employee ?? throw new ArgumentNullException(nameof(employee));

            _ = _context.Employees.Update(employee);
            _ = await _context.SaveChangesAsync();

            return employee;
        }
        public async Task<Employee> DeleteEmployeeAsync(long employeeId)
        {
            var employee = await _context.Employees.FindAsync(employeeId);

            _ = _context.Employees.Remove(employee);
            _ = await _context.SaveChangesAsync();

            return employee;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
