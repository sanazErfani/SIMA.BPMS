using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sima.Framework.Core.Repository;
using SIMA.BPMS.Persistance.EF.Persistence;
using SIMA.BPMS.Persistance.EF.Repositories;
using SIMA.Framework.Core.Repository;
using SIMA.Framework.Infrastructure.Data;

namespace SIMA.BPMS.Persistance.EF.ConfigurationExtentions;

public static class ConfigurationExtention
{
    public static IServiceCollection RegisterWriteDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<DbContext, BPMSContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("BPMSContext")
                ));
    }
    public static IServiceCollection RegisterCommandRepository(this IServiceCollection services)
    {
        return services.Scan(scan =>
               scan.FromAssemblyOf<ActorRepository>()
               .AddClasses(classes => classes.AssignableTo(typeof(IRepository<>)))
               .AsImplementedInterfaces()
               .WithScopedLifetime());
    }
    public static IServiceCollection RegisterUnitOfWork(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
