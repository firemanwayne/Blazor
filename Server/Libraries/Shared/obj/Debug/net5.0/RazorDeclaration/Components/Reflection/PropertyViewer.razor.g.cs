// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Shared.Components.Reflection
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
    public partial class PropertyViewer<TValue> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "H:\Projects\firemanwayne\Blazor\Server\Libraries\Shared\Components\Reflection\PropertyViewer.razor"
       

    [Parameter] public TValue Value { get; set; }

    IDictionary<string, PropertyWrapper> TypeProperties { get; set; } = new Dictionary<string, PropertyWrapper>();

    protected override Task OnParametersSetAsync()
    {
        try
        {
            if (Value != null)
            {
                var props = typeof(TValue).GetProperties();

                foreach (var item in props)
                {
                    var prop = Value.GetType().GetProperty(item.Name);

                    if (prop != null)
                    {
                        var propValue = prop.GetValue(Value, null);

                        if (propValue != null && propValue.GetType() == typeof(bool))
                            TypeProperties.TryAdd(item.Name, new PropertyWrapper(propValue, item.Name, item));
                    }
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return Task.CompletedTask;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591