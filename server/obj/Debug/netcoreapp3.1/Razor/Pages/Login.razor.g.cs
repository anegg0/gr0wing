#pragma checksum "/home/anegg0/Dev/radzen/server/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e459a52f967d7fe3585d7f2419706711908e2447"
// <auto-generated/>
#pragma warning disable 1591
namespace Growing.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using Growing.Shared;

#line default
#line hidden
#line 5 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
using Growing.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
using Growing.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Growing.Pages.LoginComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "method", "post");
            __builder.AddAttribute(2, "action", "account/login");
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(4);
            __builder.AddAttribute(5, "Container", "main");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(8);
                __builder2.AddAttribute(9, "Size", "H1");
                __builder2.AddAttribute(10, "Text", "Login");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.AddMarkupContent(14, "\n      ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-12");
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLogin>(18);
                __builder2.AddAttribute(19, "AllowResetPassword", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 23 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
                                         false

#line default
#line hidden
                ));
                __builder2.AddAttribute(20, "Register", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 23 "/home/anegg0/Dev/radzen/server/Pages/Login.razor"
                                                           Login0Register

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<ApplicationUser> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<ApplicationUser> UserManager { get; set; }
    }
}
#pragma warning restore 1591