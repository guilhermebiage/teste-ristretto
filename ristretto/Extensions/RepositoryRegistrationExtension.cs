using ristretto.Repositories;
using System.Runtime.CompilerServices;

namespace ristretto.Extensions
{
    internal static class RepositoryRegistrationExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddTransient<ICompanyRepository, CompanyRepository>()
                           .AddTransient<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
