#pragma checksum "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81746445be35fe4006b388e5357c8fa9dc002d88"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp
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
#line 21 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using Shared.Components.Tooltips;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\_Imports.razor"
using ExportToExcel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\App.razor"
using IdentityUI.Pages;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 5 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "AdditionalAssemblies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Reflection.Assembly>>(
#nullable restore
#line 5 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\App.razor"
                                                                          new[] { typeof(LoginModel).Assembly }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 8 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 8 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(9, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                    __builder3.AddAttribute(11, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 12 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
