using BaseNetCore.Application.Common.Interdaces;
using BaseNetCore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace BaseNetCore.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AssetManagementContext>(
                dbContextOptions => dbContextOptions
                    .UseSqlServer(
                        configuration.GetConnectionString("ConnectionDefault"))
            );
            services.AddScoped<IAssetManagementContext>(provider => provider.GetRequiredService<AssetManagementContext>());
        }
    }
}
