#pragma checksum "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\ErrorPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abc6f7fd6ca81a22f0809646a132f896f8473ad7"
// <auto-generated/>
#pragma warning disable 1591
namespace BDefenderBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using BDefenderBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\_Imports.razor"
using BDefenderBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\ErrorPage.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/error")]
    public partial class ErrorPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"err\" b-308mf5gxdf>Error how did you get here hm? We will redirect you to the home page.</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\ErrorPage.razor"
       
    protected override async Task OnInitializedAsync()
    {

        Timer timer = new Timer();
        timer.Interval = 6000;

        timer.Elapsed += (sender, args) =>
        {
            NavManager.NavigateTo("/", true);
        };

        timer.AutoReset = true;

        timer.Enabled = true;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
