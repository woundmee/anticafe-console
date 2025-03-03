using Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Extensions;

static class RegisterServicesExtension
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        // var builder = new ConfigurationBuilder();

        services.AddScoped<IGameService, GameService>();
        services.AddScoped<IPersonalComputerService, PersonalComputer>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IGameClubService, GameClubService>();

        return services;
    }
}