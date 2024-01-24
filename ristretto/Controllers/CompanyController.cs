using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ristretto.Entities;
using ristretto.Services;

namespace ristretto.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _companyService.GetCompanyAsync();

            return Ok(companies);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCompany(long id)
        {
            var company = await _companyService.GetCompanyByIdAsync(id);

            return Ok(company);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(Company company)
        {
            _ = company ?? throw new ArgumentNullException(nameof(company));

            var result = await _companyService.CreateCompanyAsync(company);

            return Ok(result);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCompany(Company company)
        {
            _ = company ?? throw new ArgumentNullException(nameof(company));

            var result = await _companyService.UpdateCompanyAsync(company);

            return Ok(result);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteCompany(long companyId)
        {
            var result = await _companyService.DeleteCompanyByIdAsync(companyId);

            return Ok(result);
        }
    }
}
