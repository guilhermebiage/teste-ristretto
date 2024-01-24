using ristretto.Entities;

namespace ristretto.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetCompanyAsync();

        Task<Company> GetCompanyByIdAsync(long companyId);

        Task<IEnumerable<Company>> GetCompaniesByNameAsync(string companyName);

        Task<IEnumerable<Company>> SearchCompaniesByNameAsync(string companyName);

        Task<Company> CreateCompanyAsync(Company company);

        Task<Company> UpdateCompanyAsync(Company company);

        Task<Company> DeleteCompanyByIdAsync(long companyId);
    }
}
