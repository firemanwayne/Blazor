#pragma checksum "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedFormTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5bae189a1fffb1cec4a868f961d3c85c5fbc553"
// <auto-generated/>
#pragma warning disable 1591
namespace Shared.Components.Templates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using System.Collections.Concurrent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Components.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Components.Menus.VerticalMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Models.Concrete;

#line default
#line hidden
#nullable disable
    public partial class AuthorizedFormTemplate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedFormTemplate.razor"
 if (IsLoading && LoadingContent != null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 12 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedFormTemplate.razor"
     LoadingContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 12 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedFormTemplate.razor"
                   
}
else
{
    if(FormContent != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 18 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedFormTemplate.razor"
         FormContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 18 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedFormTemplate.razor"
                    
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedFormTemplate.razor"
      
    [Parameter] public bool IsLoading { get; set; }

    [Parameter] public RenderFragment LoadingContent { get; set; }

    [Parameter] public RenderFragment FormContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
