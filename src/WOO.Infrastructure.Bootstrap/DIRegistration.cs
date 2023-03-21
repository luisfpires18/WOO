namespace WOO.Infrastructure.Bootstrap
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using WOO.Application.Service;
    using WOO.Application.Service.Mappers;
    using WOO.Application.Service.Mappers.Interfaces;
    using WOO.Data.Contexts;
    using WOO.Data.Repositories.Implementations;
    using WOO.Data.Repositories.Interfaces;

    public static class DIRegistration
    {
        public static void RegisterDI(WebApplicationBuilder builder)
        {
            RegisterServices(builder);
            RegisterRepositories(builder);
            RegisterMappers(builder);
        }

        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPlayerService, PlayerService>();
        }

        public static void RegisterRepositories(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
        }

        public static void RegisterMappers(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPlayerMapper, PlayerMapper>();
        }

        public static void RegisterDBContext(
            WebApplicationBuilder builder,
            string connectionString)
        {
            builder.Services.AddDbContext<WooDBContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<WooDBContext>();
        }

        public static void RegisterIdentityContext(WebApplicationBuilder builder)
        {
        }
    }
}