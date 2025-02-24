using CoreCarBook.Domain.Repositories;
using CoreCarBook.Persistence.Context;
using CoreCarBook.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CoreCarBook.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<CarBookContext>();
        services.AddScoped<ICarRepository, CarRepository>();
        //services.AddScoped<ICarService, CarService>
        return services;
    }
}