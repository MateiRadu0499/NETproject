#pragma checksum "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee41c7ed6cafa5b9adab8b500733f5078119f8e0"
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
#line 4 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
using BDefenderBlazorApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile/{id}")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "b-2ga2atsq36");
#nullable restore
#line 7 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
     if(user == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h1 b-2ga2atsq36>Just a second</h1>");
#nullable restore
#line 10 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "login-container");
            __builder.AddAttribute(5, "b-2ga2atsq36");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-container");
            __builder.AddAttribute(8, "b-2ga2atsq36");
            __builder.OpenElement(9, "form");
            __builder.AddAttribute(10, "method", "post");
            __builder.AddAttribute(11, "b-2ga2atsq36");
            __builder.AddMarkupContent(12, "<h5 class=\"text-center\" b-2ga2atsq36>Profile</h5>\r\n                    ");
            __builder.OpenElement(13, "h2");
            __builder.AddAttribute(14, "b-2ga2atsq36");
            __builder.AddContent(15, "Username: ");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
                                   user.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "h2");
            __builder.AddAttribute(19, "b-2ga2atsq36");
            __builder.AddContent(20, "First Name: ");
            __builder.AddContent(21, 
#nullable restore
#line 18 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
                                     user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "h2");
            __builder.AddAttribute(24, "b-2ga2atsq36");
            __builder.AddContent(25, "Last Name: ");
            __builder.AddContent(26, 
#nullable restore
#line 19 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
                                    user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "h2");
            __builder.AddAttribute(29, "b-2ga2atsq36");
            __builder.AddContent(30, "Phone: ");
            __builder.AddContent(31, 
#nullable restore
#line 20 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
                                user.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "h2");
            __builder.AddAttribute(34, "b-2ga2atsq36");
            __builder.AddContent(35, "Affiliation: ");
            __builder.AddContent(36, 
#nullable restore
#line 21 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
                                      user.Affiliation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Matei Radu\OneDrive\Desktop\NETproject\BDefenderBlazorApp\BDefenderBlazorApp\Pages\Profile.razor"
       
    public string Id { get; set; }
    public string localId { get; set; }
    public string loggedIn { get; set; }

    private User user = new User();


    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5002")
    };
    protected override async Task OnInitializedAsync()
    {
        localId = await localStorage.GetItemAsStringAsync("id");
        loggedIn = await localStorage.GetItemAsStringAsync("authenticated");
        user = await httpClient.GetFromJsonAsync<User>("/api/v1/users/" + Id);
        user = await httpClient.GetFromJsonAsync<User>("/api/v1/users/" + localId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
