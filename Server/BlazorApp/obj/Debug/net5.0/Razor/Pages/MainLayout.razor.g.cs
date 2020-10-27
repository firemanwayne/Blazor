#pragma checksum "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7efe44cd721ee121e9e92fb519900a12d42d52"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using BlazorApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Shared.Components.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using ExportToExcel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\MainLayout.razor"
using Shared.Components.Navigation;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : AuthorizedLayoutBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorApp.Pages.RedirectToLogin>(2);
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(3, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Loading...");
            }
            ));
            __builder.AddAttribute(5, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorApp.Pages.HeaderBar>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenComponent<Shared.Components.Navigation.SideNavBar>(8);
                __builder2.AddAttribute(9, "BarItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Shared.Components.Navigation.BarItem>>(
#nullable restore
#line 41 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\MainLayout.razor"
                              NavBarItems

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "OnSideNavToggled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 41 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\MainLayout.razor"
                                                             HandleSideNavToggled

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenElement(12, "main");
                __builder2.AddAttribute(13, "id", "main");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.AddAttribute(15, "style", "padding-bottom:" + " 60px;" + " padding-left:" + " 30px;" + " " + (
#nullable restore
#line 43 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\MainLayout.razor"
                                                                                      MarginLeft

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "content p-4");
                __builder2.AddContent(18, 
#nullable restore
#line 45 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\MainLayout.razor"
      
    
    string MarginLeft { get; set; } = "margin-left: 300px;";
    
    IList<BarItem> NavBarItems = new List<BarItem>()
    {
         new BarItem { IsLocked = false, Name = "Import", LogoName = "dashboard", HrefLink = "/Import" },
         new BarItem { IsLocked = false, Name = "Export", LogoName = "language", HrefLink = "/Export" },
         new BarItem { IsLocked = false, Name = "IO", NavItems = IOListItems, LogoName = "description", HrefLink = "javascript:void(0)" },
    };
    private static readonly IList<BarListItem> IOListItems = new List<BarListItem>()
    {
            new BarListItem("Import", "/Import"),
            new BarListItem("Export", "/Export")           
    };

    void HandleSideNavToggled(bool IsOpen)
    {
        if(IsOpen)
            MarginLeft = "margin-left: 300px;";
        else
            MarginLeft = "margin-left: 85px;";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
