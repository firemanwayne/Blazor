#pragma checksum "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef7f0e554c44ee8b236d11966f6cbaaf883335a"
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
#line 2 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\nWelcome to your new ");
            __builder.OpenComponent<Shared.Components.Tooltips.Tooltip>(1);
            __builder.AddAttribute(2, "Text", "Blazor is awesome!");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "app");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, ".\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
