#pragma checksum "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fab6497d52624f6f07e3f1e7876473b55a8ee87"
// <auto-generated/>
#pragma warning disable 1591
namespace Shared.Components.Menus.VerticalMenu
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
    public partial class MenuButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
 if (IsVisible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
                   () => Parent.ActivatePage(ButtonId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", "nav-link" + " " + (
#nullable restore
#line 4 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
                        CssClass

#line default
#line hidden
#nullable disable
            ) + " show");
            __builder.AddAttribute(3, "id", "v-pills-" + (
#nullable restore
#line 5 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
                    ButtonId

#line default
#line hidden
#nullable disable
            ) + "-tab");
            __builder.AddAttribute(4, "data-toggle", "pill");
            __builder.AddAttribute(5, "href", "#v-pills-" + (
#nullable restore
#line 7 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
                       ButtonId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "role", "tab");
            __builder.AddAttribute(7, "aria-controls", "v-pills-" + (
#nullable restore
#line 9 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
                               ButtonId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "aria-selected", "true");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
                             ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\wayne\source\repos\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuButton.razor"
      
    [Parameter] public string ButtonText { get; set; }

    [Parameter] public string ButtonId { get; set; }

    [Parameter] public bool IsVisible { get; set; } = true;

    [CascadingParameter] VerticalMenuControl Parent { get; set; }

    string CssClass { get; set; }

    bool IsActive { get; set; }

    protected override Task OnInitializedAsync()
    {
        Parent.AddButton(this);

        return Task.CompletedTask;
    }

    internal void Activate()
    {
        IsActive = true;
        CssClass = "active";


    }
    internal void DeActivate()
    {
        IsActive = false;
        CssClass = "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
