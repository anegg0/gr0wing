#pragma checksum "/home/anegg0/Dev/gr0wing/server/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "447b266b4a9aa49c55fbdce199152902519f5cf1"
// <auto-generated/>
#pragma warning disable 1591
namespace Localhost
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using Localhost.Shared;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/gr0wing/server/_Imports.razor"
using Radzen;

#line default
#line hidden
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(3);
                __builder2.AddAttribute(4, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 6 "/home/anegg0/Dev/gr0wing/server/App.razor"
                     typeof(Startup).Assembly

#line default
#line hidden
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(6, "\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#line 8 "/home/anegg0/Dev/gr0wing/server/App.razor"
                                            routeData

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 8 "/home/anegg0/Dev/gr0wing/server/App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(11, "\n                    ");
                        __builder4.OpenComponent<Localhost.Shared.RedirectToLogin>(12);
                        __builder4.AddAttribute(13, "IsAuthenticated", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 10 "/home/anegg0/Dev/gr0wing/server/App.razor"
                                                       context.User.Identity.IsAuthenticated

#line default
#line hidden
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\n    ");
                }
                ));
                __builder2.AddAttribute(16, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(17, "\n        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(18);
                    __builder3.AddAttribute(19, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 15 "/home/anegg0/Dev/gr0wing/server/App.razor"
                            typeof(MainLayout)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(21, "\n            ");
                        __builder4.AddMarkupContent(22, "<h1>Page not found</h1>\n            ");
                        __builder4.AddMarkupContent(23, "<p>Sorry, but there\'s nothing here!</p>\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
