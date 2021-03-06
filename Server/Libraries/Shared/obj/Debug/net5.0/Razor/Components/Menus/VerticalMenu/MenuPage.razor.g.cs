#pragma checksum "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6caa1f6ceb382bf29639698a3cb75e0f042059df"
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
#line 19 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\_Imports.razor"
using Shared.Models.Concrete;

#line default
#line hidden
#nullable disable
    public partial class MenuPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor"
 if (IsActive)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "tab-pane active show");
            __builder.AddAttribute(2, "id", "v-pills-" + (
#nullable restore
#line 4 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor"
                                                               ButtonId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "role", "tabpanel");
            __builder.AddAttribute(4, "aria-labelledby", "v-pills-" + (
#nullable restore
#line 4 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor"
                                                                                                                   ButtonId

#line default
#line hidden
#nullable disable
            ) + "-tab");
            __builder.SetKey(
#nullable restore
#line 4 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor"
           ButtonId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, 
#nullable restore
#line 5 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\MenuPage.razor"
      
    private string buttonId;
    private bool isActive;

    [Parameter] public RenderFragment ChildContent { get; set; }

    [Parameter] public string ButtonId
    {
        get => buttonId;
        set
        {
            buttonId = value;
            InvokeAsync(() => StateHasChanged());
        }
    }

    [Parameter] public EventCallback<MenuPage> OnSelected { get; set; }

    [CascadingParameter] VerticalMenuControl Parent { get; set; }

    bool IsActive
    {
        get => isActive;
        set
        {
            isActive = value;

            OnSelected.InvokeAsync(this);

            InvokeAsync(() => StateHasChanged());
        }
    }

    protected override Task OnInitializedAsync()
    {
        Parent.AddPage(this);

        return Task.CompletedTask;
    }

    internal void Activate()
    {
        IsActive = true;

        if (OnSelected.HasDelegate)
            OnSelected.InvokeAsync(this);
    }
    internal void DeActivate()
    {
        IsActive = false;

        if (OnSelected.HasDelegate)
            OnSelected.InvokeAsync(this);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
