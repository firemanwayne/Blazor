#pragma checksum "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7901c34c4f497951dff72038d64614d39dd4ad8f"
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
#line 3 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
using ExportToExcel.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Import")]
    public partial class Import : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(2);
            __builder.AddAttribute(3, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 82 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                         HandleFileChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "multiple", true);
            __builder.AddAttribute(5, "class", "form-control");
            __builder.CloseComponent();
#nullable restore
#line 85 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
     if (Sheet != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "fieldset");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "<legend>Header Style</legend>\r\n\r\n            ");
            __builder.OpenComponent<ExportToExcel.Components.ExcelColorSelector>(9);
            __builder.AddAttribute(10, "OnColorSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExportToExcel.StyleColorSelectedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExportToExcel.StyleColorSelectedEventArgs>(this, 
#nullable restore
#line 90 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                                 HandleHeaderColorSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n            ");
            __builder.OpenComponent<ExportToExcel.Components.ExcelHorizontalAlignmentSelector>(12);
            __builder.AddAttribute(13, "OnSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExportToExcel.HorizontalAlignmentChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExportToExcel.HorizontalAlignmentChangedEventArgs>(this, 
#nullable restore
#line 92 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                                          HandleHeaderHorizontalAlignmentSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenComponent<ExportToExcel.Components.ExcelVerticalAlignmentSelector>(15);
            __builder.AddAttribute(16, "OnSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExportToExcel.VerticalAlignmentChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExportToExcel.VerticalAlignmentChangedEventArgs>(this, 
#nullable restore
#line 94 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                                        HandleHeaderVerticalAlignmentSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(17, "fieldset");
            __builder.AddAttribute(18, "class", "row");
            __builder.AddMarkupContent(19, "<legend>Body Style</legend>\r\n\r\n            ");
            __builder.OpenComponent<ExportToExcel.Components.ExcelColorSelector>(20);
            __builder.AddAttribute(21, "OnColorSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExportToExcel.StyleColorSelectedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExportToExcel.StyleColorSelectedEventArgs>(this, 
#nullable restore
#line 100 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                                 HandleBodyColorSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n            ");
            __builder.OpenComponent<ExportToExcel.Components.ExcelHorizontalAlignmentSelector>(23);
            __builder.AddAttribute(24, "OnSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExportToExcel.HorizontalAlignmentChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExportToExcel.HorizontalAlignmentChangedEventArgs>(this, 
#nullable restore
#line 102 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                                          HandleBodyHorizontalAlignmentSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n            ");
            __builder.OpenComponent<ExportToExcel.Components.ExcelVerticalAlignmentSelector>(26);
            __builder.AddAttribute(27, "OnSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ExportToExcel.VerticalAlignmentChangedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ExportToExcel.VerticalAlignmentChangedEventArgs>(this, 
#nullable restore
#line 104 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                                        HandleBodyVerticalAlignmentSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenComponent<ExportToExcel.Components.ExcelExport<SheetRow>>(28);
            __builder.AddAttribute(29, "ButtonText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 107 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                ButtonText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "CssClass", "btn btn-outline-success");
            __builder.AddAttribute(31, "ReportName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 109 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                  ReportName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "HeaderStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ExportToExcel.HeaderStyle>(
#nullable restore
#line 111 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                  HeaderStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "BodyStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ExportToExcel.BodyStyle>(
#nullable restore
#line 112 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                BodyStyle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "RequestDelegate", new System.Func<System.Collections.Generic.IEnumerable<SheetRow>>(
#nullable restore
#line 113 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                      ExportRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "DownloadToBrowser", new ExportToExcel.Delegates.UploadFileEventHandler(
#nullable restore
#line 114 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                        DownloadFile

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "container");
            __builder.AddAttribute(38, "style", "max-height:800px;overflow-y:auto");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table table-bordered");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<SheetRow>>(41);
            __builder.AddAttribute(42, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.ICollection<SheetRow>>(
#nullable restore
#line 118 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                                                Sheet.DataRows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "ItemContent", (Microsoft.AspNetCore.Components.RenderFragment<SheetRow>)((d) => (__builder2) => {
                __builder2.OpenElement(44, "tr");
                __builder2.OpenElement(45, "td");
                __builder2.AddContent(46, "Row: ");
                __builder2.AddContent(47, 
#nullable restore
#line 122 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                      d.Index

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 124 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                             foreach (var item in d.Columns)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(48, "td");
                __builder2.AddContent(49, "Column: ");
                __builder2.AddContent(50, 
#nullable restore
#line 126 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                             item.ColumnIndex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.OpenElement(51, "td");
                __builder2.AddContent(52, 
#nullable restore
#line 128 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                                     item.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 129 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(53, "Placeholder", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext>)((d) => (__builder2) => {
                __builder2.AddMarkupContent(54, "<p>Loading&hellip;</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 139 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "H:\Projects\firemanwayne\Blazor\Server\BlazorApp\Pages\Import.razor"
       
    SpreadSheet Sheet { get; set; }

    string Source { get; set; }

    string ReportName => "Excel Test Document";

    string ButtonText => "Export To Excel";

    HeaderStyle HeaderStyle { get; set; } = new HeaderStyle();

    BodyStyle BodyStyle { get; set; } = new BodyStyle();

    async Task HandleFileChange(InputFileChangeEventArgs a)
    {
        if (a.File != null)
        {
            var buffer = new byte[a.File.Size];
            await a.File.OpenReadStream().ReadAsync(buffer);
            var ms = new MemoryStream(buffer);

            Sheet = new SpreadSheet(a.File);
            var reader = new StreamReader(ms);

            while (!reader.EndOfStream)
                Sheet.AddRow(await reader.ReadLineAsync());

            ExportRequest();
        }
    }

    IEnumerable<SheetRow> ExportRequest()
    {
        return Sheet.DataRows.ToList();
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
