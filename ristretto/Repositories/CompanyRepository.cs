using Microsoft.EntityFrameworkCore;
using ristretto.Configuration;
using ristretto.Entities;
using System;

namespace ristretto.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> GetCompanyByIdAsync(long id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public async Task<Company> InsertCompanyAsync(Company company)
        {
            _ = company ?? throw new ArgumentNullException(nameof(company));

            _ = _context.Companies.Add(company);
            _ = await _context.SaveChangesAsync();

            return company;
        }

        public async Task<Company> UpdateCompanyAsync(Company company)
        {
            _ = company ?? throw new ArgumentNullException(nameof(company));

            _ = _context.Companies.Update(company);
            _ = await _context.SaveChangesAsync();

            return company;
        }

        public async Task<Company> DeleteCompanyByIdAsync(long id)
        {
            var company = await _context.Companies.FindAsync(id);

            if (company != null)
            {
                _ = _context.Companies.Remove(company);
                _ = await _context.SaveChangesAsync();
            }

            return company;
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
