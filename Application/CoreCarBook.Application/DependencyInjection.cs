using CoreCarBook.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace CoreCarBook.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddPersistence();
        return services;
    }
}