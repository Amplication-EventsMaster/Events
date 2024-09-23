using ServiceGamma.APIs;

namespace ServiceGamma;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IFffsService, FffsService>();
    }
}
