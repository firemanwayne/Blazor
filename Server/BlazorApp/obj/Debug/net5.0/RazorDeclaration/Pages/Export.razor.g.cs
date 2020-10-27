// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Export.razor"
using ExportToExcel.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Export.razor"
using Domain.IdentityManagement.UserAggregate;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Export")]
    public partial class Export : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Export.razor"
       
    [Inject] UserManager<User> UserManager { get; set; }

    HeaderStyle HeaderStyle { get; set; } = new HeaderStyle();

    BodyStyle BodyStyle { get; set; } = new BodyStyle();

    string UserButtonText => "Export Users To Excel";

    string UserReportName => "Users Report";

    string FileName => $"{ DateTime.UtcNow.ToString("MM:dd:yyyy:hh:mm:ss") }";

    string Source { get; set; }

    IEnumerable<UserSpreadSheet> ExportUserRequest()
    {
        return UserManager.Users.Cast<UserSpreadSheet>().ToList();
    }

    Task<UploadResponse> DownloadFile(ExcelDocumentResponse Response)
    {
        var response = new UploadFileLocalResponse
        {
            FileName = Response.FileName,
            ContentType = ExcelConstants.ContentType,
            FileContent = Convert.ToBase64String(Response.SpreadSheetBytes)
        };

        Source = response.FileContent;

        return Task.FromResult(response as UploadResponse);
    }

    void HandleHeaderColorSelected(StyleColorSelectedEventArgs a)
    {
        HeaderStyle.SetForegroundColor(a);
    }
    void HandleBodyColorSelected(StyleColorSelectedEventArgs a)
    {
        BodyStyle.SetForegroundColor(a);
    }
    void HandleHeaderHorizontalAlignmentSelected(HorizontalAlignmentChangedEventArgs a)
    {
        HeaderStyle.SetHorizontalAlignment(a);
    }
    void HandleBodyHorizontalAlignmentSelected(HorizontalAlignmentChangedEventArgs a)
    {
        BodyStyle.SetHorizontalAlignment(a);
    }
    void HandleHeaderVerticalAlignmentSelected(VerticalAlignmentChangedEventArgs a)
    {
        HeaderStyle.SetVerticalAlignment(a);
    }
    void HandleBodyVerticalAlignmentSelected(VerticalAlignmentChangedEventArgs a)
    {
        BodyStyle.SetVerticalAlignment(a);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
