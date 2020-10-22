using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace BlazorApp
{
    public class Startup
    {
        public IWebHostEnvironment Env { get; }
        public IConfiguration Config { get; }

        public Startup(IConfiguration Config, IWebHostEnvironment Env)
        {
            this.Env = Env;
            this.Config = Config;
        }

        public void ConfigureServices(IServiceCollection services)
        {           
            services.AddRazorPages();

            services.AddServerSideBlazor()
                .AddCircuitOptions(o =>
                {
                    if (Env.IsDevelopment()) //only add details when debugging
                    {
                        o.DetailedErrors = true;
                    }
                });

            services.AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddHttpClient();

            ///Add Application Services
            services.AddApplicationServices(Config);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var cookiePolicyOptions = new CookiePolicyOptions
            {
                CheckConsentNeeded = Context => false,
                MinimumSameSitePolicy = SameSiteMode.None
            };

            app.UseSerilogRequestLogging(options =>
            {
                // Customize the message template
                options.MessageTemplate = "Handled {RequestPath}";

                // Emit debug-level events instead of the defaults
                options.GetLevel = (httpContext, elapsed, ex) => LogEventLevel.Error;

                // Attach additional properties to the request completion event
                options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
                {
                    diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value);
                    diagnosticContext.Set("RequestScheme", httpContext.Request.Scheme);
                };
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy(cookiePolicyOptions);

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
