using ristretto.Entities;
using ristretto.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ristretto.Services
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;

        public CompanyService(ICompanyRepository companyRepository, IEmployeeRepository employeeRepository)
        {
            _companyRepository = companyRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task<Company> CreateCompanyAsync(Company company)
        {
            _ = company ?? throw new ArgumentNullException(nameof(company));

            return await _companyRepository.InsertCompanyAsync(company);
        }

        public async Task<Company> DeleteCompanyByIdAsync(long companyId)
        {
            var company = await _companyRepository.GetCompanyByIdAsync(companyId);

            foreach (var employee in company.Employees)
            {
                employee.Company = null;
                _ = await _employeeRepository.UpdateEmployeeAsync(employee);
            }

            return await _companyRepository.DeleteCompanyByIdAsync(companyId);
        }

        public Task<IEnumerable<Company>> GetCompaniesByNameAsync(string companyName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Company>> GetCompanyAsync()
        {
            return await _companyRepository.GetCompaniesAsync();
        }

        public async  Task<Company> GetCompanyByIdAsync(long companyId)
        {
            return await _companyRepository.GetCompanyByIdAsync(companyId);
        }

        public Task<IEnumerable<Company>> SearchCompaniesByNameAsync(string companyName)
        {
            throw new NotImplementedException();
        }

        public async Task<Company> UpdateCompanyAsync(Company company)
        {
            _ = company ?? throw new ArgumentNullException(nameof(company));

            return await _companyRepository.UpdateCompanyAsync(company);
        }
    }
}
