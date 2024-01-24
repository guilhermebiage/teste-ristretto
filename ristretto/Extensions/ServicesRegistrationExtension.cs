using ristretto.Services;

namespace ristretto.Extensions
{
    public static class ServicesRegistrationExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
        { 
            return services.AddTransient<ICompanyService, CompanyService>()
                           .AddTransient<IEmployeeService, EmployeeService>();
        }
    }
}
