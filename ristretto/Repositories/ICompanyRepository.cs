using ristretto.Entities;

namespace ristretto.Repositories
{
    public interface ICompanyRepository : IDisposable
    {
        Task<IEnumerable<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyByIdAsync(long id);
        Task<Company> InsertCompanyAsync(Company company);
        Task<Company> UpdateCompanyAsync(Company company);
        Task<Company> DeleteCompanyByIdAsync(long id);
    }
}
