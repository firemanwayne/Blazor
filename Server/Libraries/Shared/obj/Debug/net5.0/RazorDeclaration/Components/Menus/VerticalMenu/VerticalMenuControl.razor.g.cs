// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class VerticalMenuControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Menus\VerticalMenu\VerticalMenuControl.razor"
      

    [Parameter] public string HeaderStyle { get; set; } = "text-align:right;";

    [Parameter] public string HeaderClassCss { get; set; } = "col-md-8";

    [Parameter] public RenderFragment HeaderContent { get; set; }

    [Parameter] public string HeaderText { get; set; }

    [Parameter] public RenderFragment MenuButtons { get; set; }

    [Parameter] public RenderFragment MenuPages { get; set; }

    public MenuPage ActivePage { get; set; }

    public MenuButton ActiveButton { get; set; }

    public IList<MenuPage> Pages { get; set; } = new List<MenuPage>();
    public IList<MenuButton> Buttons { get; set; } = new List<MenuButton>();

    internal void AddButton(MenuButton button)
    {
        Buttons.Add(button);

        if (Buttons.Count == 1 && button.IsVisible)
        {
            ActiveButton = button;
            ActiveButton.Activate();
        }
        else
        {
            button.DeActivate();
        }

        InvokeAsync(() => StateHasChanged());
    }

    internal void AddPage(MenuPage menuPage)
    {
        Pages.Add(menuPage);

        if (Pages.Count == 1)
        {
            ActivePage = menuPage;
            ActivePage.Activate();
        }

        InvokeAsync(() => StateHasChanged());
    }

    internal void ActivatePage(string buttonId)
    {
        var clickedPage = Pages.FirstOrDefault(e => e.ButtonId.Equals(buttonId));
        var clickedButton = Buttons.FirstOrDefault(e => e.ButtonId.Equals(buttonId));

        foreach (var item in Pages)
            if (item.ButtonId.Equals(buttonId))
                item.Activate();
            else
                item.DeActivate();

        foreach (var item in Buttons)
            if (item.ButtonId.Equals(buttonId))
                item.Activate();
            else
                item.DeActivate();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
