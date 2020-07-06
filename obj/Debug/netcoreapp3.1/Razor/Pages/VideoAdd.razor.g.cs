#pragma checksum "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d3e592dad709ec7364e0a0c7ea6c95030c2982"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDapperCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using BlazorDapperCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorDapperCrud\_Imports.razor"
using BlazorDapperCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
using BlazorDapperCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videoadd")]
    public partial class VideoAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add a video</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
                  _video

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
                                          VideoInsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "table");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "tr");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<td>Video Title:</td>\r\n            ");
                __builder2.OpenElement(11, "td");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "required", true);
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
                                          _video.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _video.Title = __value, _video.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.AddMarkupContent(21, "<td>Date Published:</td>\r\n            ");
                __builder2.OpenElement(22, "td");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "date");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
                                          _video.DatePublished

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _video.DatePublished = __value, _video.DatePublished, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenElement(30, "tr");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.AddMarkupContent(32, "<td>Is Active:</td>\r\n            ");
                __builder2.OpenElement(33, "td");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "checkbox");
                __builder2.AddAttribute(36, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
                                              _video.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _video.IsActive = __value, _video.IsActive));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "tr");
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "td");
                __builder2.AddAttribute(43, "colspan", "2");
                __builder2.AddAttribute(44, "style", "text-align: center");
                __builder2.AddMarkupContent(45, "\r\n                <input type=\"submit\" value=\"Add\">\r\n                ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "button");
                __builder2.AddAttribute(48, "value", "Cancel");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
                                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Projects\BlazorDapperCrud\Pages\VideoAdd.razor"
       
    //Create a new empty video object
    readonly Video _video = new Video();

    protected async Task VideoInsert()
    {
        await VideoService.VideoInsert(_video);
        NavigationManager.NavigateTo("/");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVideoService VideoService { get; set; }
    }
}
#pragma warning restore 1591
