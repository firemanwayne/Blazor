using Application.Authentication;
using Domain.IdentityManagement.RoleAggregate;
using Domain.IdentityManagement.UserAggregate;
using ExportToExcel;
using Infrastructure.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ApplicationServiceRegistry
    {
        private const string LoginPath = "/Login";
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration Config)
        {
            services.AddExportToExcel();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Config.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, Role>(
                o => {
                    o.SignIn = new SignInOptions 
                    {
                        RequireConfirmedEmail = true,
                    };
                    o.Password = new PasswordOptions 
                    {
                        RequireDigit = true,
                        RequireLowercase = true,
                        RequireUppercase = true 
                    };                    
                    o.User = new UserOptions
                    {
                        RequireUniqueEmail = true,
                    };
                })                
                .AddSignInManager<SignInManager<User>>()
                .AddUserManager<UserManager<User>>()             
                .AddEntityFrameworkStores<ApplicationDbContext>()                
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(o => 
            {
                o.LoginPath = LoginPath;
                o.AccessDeniedPath = "/Account/AccessDenied";
                o.SlidingExpiration = true;
                o.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                o.Cookie = new CookieBuilder
                {                    
                    SameSite = SameSiteMode.None,
                    Name = "Blazor-Shared-Cookie",
                    HttpOnly = true,
                    IsEssential = true
                };
                o.Events = new CookieAuthenticationEvents()
                {
                    OnRedirectToLogin = ctx =>
                    {
                        var rdt = ctx.Request.Path.ToUriComponent();

                        if (ctx.Request.Path.HasValue)
                            ctx.Response.Redirect(LoginPath);
                        else
                            ctx.Response.Redirect(LoginPath);

                        return Task.CompletedTask;
                    },
                    OnRedirectToAccessDenied = ctx =>
                    {
                        ctx.Response.Redirect(LoginPath);

                        return Task.CompletedTask;
                    }
                };
            });

            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<User>>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
    }
}
