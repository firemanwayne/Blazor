using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Authentication
{
    public class RevalidatingIdentityAuthenticationStateProvider<TUser> : RevalidatingServerAuthenticationStateProvider where TUser : class
    {
        private readonly IServiceScopeFactory ScopeFactory;
        private readonly IdentityOptions Options;

        public RevalidatingIdentityAuthenticationStateProvider(
            ILoggerFactory LoggerFactory,
            IServiceScopeFactory ScopeFactory,
            IOptions<IdentityOptions> Options) : base(LoggerFactory)
        {
            this.ScopeFactory = ScopeFactory;
            this.Options = Options.Value;
        }

        protected override TimeSpan RevalidationInterval => TimeSpan.FromMinutes(30);

        protected override async Task<bool> ValidateAuthenticationStateAsync(AuthenticationState state, CancellationToken token)
        {
            // Get the user manager from a new scope to ensure it fetches fresh data
            var scope = ScopeFactory.CreateScope();
            try
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<TUser>>();

                return await ValidateSecurityStampAsync(userManager, state.User);
            }
            finally
            {
                if (scope is IAsyncDisposable asyncDisposable)                
                    await asyncDisposable.DisposeAsync();                
                else                
                    scope.Dispose();                
            }
        }

        private async Task<bool> ValidateSecurityStampAsync(UserManager<TUser> userManager, ClaimsPrincipal User)
        {
            var user = await userManager.GetUserAsync(User);

            if (user == null)            
                return false;
            
            else if (!userManager.SupportsUserSecurityStamp)            
                return true;            

            else
            {
                var principalStamp = User.FindFirstValue(Options.ClaimsIdentity.SecurityStampClaimType);
                var userStamp = await userManager.GetSecurityStampAsync(user);
                return principalStamp == userStamp;
            }
        }
    }
}
