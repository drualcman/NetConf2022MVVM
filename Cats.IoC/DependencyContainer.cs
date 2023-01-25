using Cats.BusinesObjects.ValueObjects;

namespace Cats.IoC;
public static class DependencyContainer
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services, CatsEndpoints endpoints)
    {
        services.AddHttpClient<ICatsModel, CatsModels>(HttpClient =>  new CatsModels(HttpClient, endpoints));
        services.AddScoped<ICatsViewModels, CatsViewModel>();

        return services;
    }
           
    public static IServiceCollection AddConsoleServices(this IServiceCollection services, CatsEndpoints endpoints)
    {
        services.AddCoreServices(endpoints);
        services.AddScoped<ICatsView, CatsView>();

        return services;
    }
}
