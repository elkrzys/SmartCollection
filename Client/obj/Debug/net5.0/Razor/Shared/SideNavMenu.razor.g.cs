#pragma checksum "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\Shared\SideNavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d600f79bdc3dac44eab1e75faef34ab111414768"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAPIClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using BlazorAPIClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krzys\OneDrive\Dokumenty\GitHub\2021_BD2_S10_KOST\Client\_Imports.razor"
using BlazorAPIClient.Shared;

#line default
#line hidden
#nullable disable
    public partial class SideNavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "navbar-nav bg-gradient-primary sidebar sidebar-dark accordion");
            __builder.AddAttribute(2, "id", "accordionSidebar");
            __builder.AddMarkupContent(3, @"<a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html""><div class=""sidebar-brand-icon rotate-n-15""><i class=""bi bi-camera""></i></div>
        <div class=""sidebar-brand-text mx-3"">Smart Collection</div></a>

    
    <hr class=""sidebar-divider my-0"">

    
    ");
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "class", "nav-item active");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "class", "nav-link");
            __builder.AddAttribute(8, "href", "/");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<span>Dashboard</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "nav-item active");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "nav-link");
            __builder.AddAttribute(16, "href", "/login");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<span>Login</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "nav-item active");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "class", "nav-link");
            __builder.AddAttribute(24, "href", "/register");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "<span>Register</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n    \r\n    <hr class=\"sidebar-divider\">\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(28, "<div class=\"sidebar-heading\">\r\n        Section\r\n    </div>\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(29, @"<li class=""nav-item""><a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo""><span>Anything</span>
            <i class=""bi bi-chevron-compact-right""></i></a>
        <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar""><div class=""bg-white py-2 collapse-inner rounded""><h6 class=""collapse-header"">Custom Components:</h6>
                <a class=""collapse-item"" href=""#"">Buttons</a>
                <a class=""collapse-item"" href=""#"">Cards</a></div></div></li>

    
    <hr class=""sidebar-divider"">

    
    ");
            __builder.AddMarkupContent(30, "<div class=\"sidebar-heading\">\r\n        Addons\r\n    </div>\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(31, @"<li class=""nav-item""><a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages""><span class=""col col-md-12 text-left"">
                Pages
                <i class=""bi bi-chevron-compact-right""></i></span></a>
        <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar""><div class=""bg-white py-2 collapse-inner rounded""><h6 class=""collapse-header"">Login Screens:</h6>
                <a class=""collapse-item"" href=""login.html"">Login</a>
                <a class=""collapse-item"" href=""register.html"">Register</a>
                <a class=""collapse-item"" href=""forgot-password.html"">Forgot Password</a>
                <div class=""collapse-divider""></div>
                <h6 class=""collapse-header"">Other Pages:</h6>
                <a class=""collapse-item"" href=""404.html"">404 Page</a>
                <a class=""collapse-item"" href=""blank.html"">Blank Page</a></div></div></li>

    
    ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "href", "#");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "<i class=\"bi bi-link-45deg\"></i>\r\n            ");
                __builder2.AddMarkupContent(39, "<span>Linkacz 1</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "href", "#");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<i class=\"bi bi-link-45deg\"></i>\r\n            ");
                __builder2.AddMarkupContent(48, "<span>Linkacz 2</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    \r\n    ");
            __builder.AddMarkupContent(50, "<div class=\"text-center text-white d-none d-md-inline\"><button class=\"rounded-circle border-0\" id=\"sidebarToggle\"><i class=\"bi bi-three-dots-vertical\"></i></button></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
