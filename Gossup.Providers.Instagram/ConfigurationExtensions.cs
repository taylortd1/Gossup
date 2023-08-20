using Microsoft.Extensions.DependencyInjection;

namespace Gossup.Providers.Instagram;

public static class ConfigurationExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection serviceObj)
    {
        serviceObj.AddTransient<ISocialMediaProvider, InstagramProvider>();
        return serviceObj;
    }
}
