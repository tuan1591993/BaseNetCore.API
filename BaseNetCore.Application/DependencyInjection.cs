using BaseNetCore.Application.Common.Interdaces;
using BaseNetCore.Application.Common.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BaseNetCore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IService, Service>();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}