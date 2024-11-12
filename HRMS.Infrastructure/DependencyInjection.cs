using HRMS.Application.Common.Interfaces.Persistence;
using HRMS.Infrastructure.Persistence;
using HRMS.Infrastructure.Persistence.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace HRMS.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        ConfigurationManager builderConfiguration)
    {
        services.AddDbContext<EmployeesDbContext>(option=>
            option.UseSqlServer(builderConfiguration.GetConnectionString("DefaultConnection")));
        
        services.AddScoped<IEmployeesRepository, EmployeesRepository>();
        return services;
    }
}