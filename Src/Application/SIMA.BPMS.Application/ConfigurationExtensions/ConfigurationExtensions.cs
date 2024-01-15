
using Microsoft.Extensions.DependencyInjection;
using SIMA.BPMS.Application.SBpms;
using SIMA.Framework.Common.Security;
using SIMA.Framework.Core.Mediator;

namespace SIMA.BPMS.Application.ConfigurationExtensions;

public static class ConfigurationExtensions
{
    public static IServiceCollection RegisterCommandMappers(this IServiceCollection services)
    {
        return services.AddAutoMapper((serviceProvider, conf) =>
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var scopedServiceProvider = scope.ServiceProvider;
               // conf.AddProfile(new CurrencyTypeMapper(scopedServiceProvider.GetRequiredService<ISimaIdentity>()));
              
            }
        }, Array.Empty<Type>());
    }

    public static IServiceCollection AddCommandHandlerServices(this IServiceCollection services)
    {

        return services.Scan(scan =>
       scan.FromAssemblyOf<BpmsCommandHandler>()
       .AddClasses(classes => classes.AssignableTo(typeof(ICommandHandler<,>)))
       .AsImplementedInterfaces()
       .WithScopedLifetime());
    }
}
