// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Register.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Register.razor"
using BDefenderBlazorApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Register.razor"
       
    private User user = new User();
    private string res = "";
    private static Timer timer;

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5002")
    };

    protected async Task RegisterUser()
    {
        HttpResponseMessage response = await httpClient.PostAsJsonAsync<User>("/api/v1/Register", user);
        if (response.StatusCode.ToString() == "OK")
        {
            res = "Account created succesfully";
        }
        else
        {
            res = "Username already in use.";
        }

        timer = new System.Timers.Timer();
        timer.Interval = 6000;

        timer.Elapsed += (sender, args) =>
        {
            NavManager.NavigateTo("/login");
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
