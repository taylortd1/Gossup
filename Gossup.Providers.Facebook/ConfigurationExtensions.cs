using Microsoft.Extensions.DependencyInjection;

namespace Gossup.Providers.Facebook;

public static class ConfigurationExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection serviceObj)
    {
        serviceObj.AddTransient<ISocialMediaProvider, FacebookProvider>();
        return serviceObj;
    }
}
