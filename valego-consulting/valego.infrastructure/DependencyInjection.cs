using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using valego.application;
using valego.infrastructure.Persistence;

namespace valego.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(configuration.GetConnectionString("ValegoDB"),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            //mediatr
            services.AddMediatR(dd => { dd.RegisterServicesFromAssemblies(typeof(Program).Assembly); });

            return services;
        }
    }
}
