#pragma checksum "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a92ee9f58721fb301d0678076d56f2319306c4"
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
#line 2 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using System.Collections.Concurrent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Components.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Components.Menus.VerticalMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Components.Menus.Navigation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Components.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Models.Concrete;

#line default
#line hidden
#nullable disable
    public partial class AuthorizedListTemplate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 14 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
 if (IsLoading && LoadingContent != null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 16 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
     LoadingContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
                   
}

else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
     if(HeaderContent != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 23 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
         HeaderContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
                      
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
     
    if (ListContent != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 27 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
         ListContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 27 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
                    
    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
     if(FooterContent != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 31 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
         FooterContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 31 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
                      
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Templates\AuthorizedListTemplate.razor"
      
    [Parameter] public bool IsLoading { get; set; }

    [Parameter] public RenderFragment LoadingContent { get; set; }

    [Parameter] public RenderFragment HeaderContent { get; set; }

    [Parameter] public RenderFragment ListContent { get; set; }

    [Parameter] public RenderFragment FooterContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
