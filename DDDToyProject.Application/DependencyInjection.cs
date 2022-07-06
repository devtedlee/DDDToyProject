using Microsoft.Extensions.DependencyInjection;
using DDDToyProject.Application.Services.Authentication;

namespace DDDToyProject.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}