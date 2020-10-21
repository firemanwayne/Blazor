using Application.Authentication;
using Infrastructure.Contexts;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationServiceRegistry
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration Config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Config.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(o => o.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
