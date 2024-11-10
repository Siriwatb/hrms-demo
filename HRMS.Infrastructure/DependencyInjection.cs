using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Infrastructure.Persistence;

using Microsoft.Extensions.DependencyInjection;
namespace HRMS.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IEmployeesRepository, EmployeesRepository>();
        return services;
    }
}