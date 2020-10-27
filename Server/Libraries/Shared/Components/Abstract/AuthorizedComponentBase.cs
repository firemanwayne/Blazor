using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Shared.Components.Abstract
{
    [Authorize]
    public abstract class AuthorizedComponentBase : ComponentBase
    {
        [Inject] protected AuthenticationStateProvider AuthenticationState { get; set; }

        [Inject] protected NavigationManager NavManager { get; set; }

        protected ClaimsPrincipal CurrentUser { get; set; }

        protected string CurrentUserId { get; set; }

        protected string CurrentUsersName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                if (CurrentUser == null)
                    await GetAuthenticatedUser();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected async Task GetAuthenticatedUser()
        {
            try
            {
                var result = await AuthenticationState.GetAuthenticationStateAsync();

                CurrentUser = result.User;
                CurrentUserId = result.User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (CurrentUser.Identity.IsAuthenticated)
                {
                    var FirstName = CurrentUser.FindFirstValue("FirstName");
                    var LastName = CurrentUser.FindFirstValue("LastName");

                    CurrentUsersName = $"{FirstName} {LastName}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Authorize]
    public abstract class AuthorizedLayoutBase : LayoutComponentBase
    {
        [Inject] protected AuthenticationStateProvider AuthenticationState { get; set; }

        [Inject] protected NavigationManager NavManager { get; set; }

        protected ClaimsPrincipal CurrentUser { get; set; }

        protected string CurrentUserId { get; set; }

        protected string CurrentUsersName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                if (CurrentUser == null)
                    await GetAuthenticatedUser();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected async Task GetAuthenticatedUser()
        {
            try
            {
                var result = await AuthenticationState.GetAuthenticationStateAsync();

                CurrentUser = result.User;
                CurrentUserId = result.User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (CurrentUser.Identity.IsAuthenticated)
                {
                    var FirstName = CurrentUser.FindFirstValue("FirstName");
                    var LastName = CurrentUser.FindFirstValue("LastName");

                    CurrentUsersName = $"{FirstName} {LastName}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
