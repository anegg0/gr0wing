#pragma checksum "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5942e38f8aba2f79c181dc4c79f9630a2604893"
// <auto-generated/>
#pragma warning disable 1591
namespace Localhost.Pages
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
#line 5 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
using Localhost.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
using Localhost.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/application-users")]
    public partial class ApplicationUsers : Localhost.Pages.ApplicationUsersComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(4);
                __builder2.AddAttribute(5, "Size", "H1");
                __builder2.AddAttribute(6, "Text", "Users");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.AddMarkupContent(10, "\n      ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-12");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "Icon", "add_circle_outline");
                __builder2.AddAttribute(16, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(17, "Text", "Add");
                __builder2.AddAttribute(18, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<ApplicationUser>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ApplicationUser>>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                                     users

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ApplicationUser>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ApplicationUser>(this, 
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                                                                                Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ApplicationUser>>(28);
                    __builder3.AddAttribute(29, "Property", "UserName");
                    __builder3.AddAttribute(30, "Title", "User Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ApplicationUser>>(32);
                    __builder3.AddAttribute(33, "Property", "Email");
                    __builder3.AddAttribute(34, "Title", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<ApplicationUser>>(36);
                    __builder3.AddAttribute(37, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(38, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 27 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(39, "Width", "70px");
                    __builder3.AddAttribute(40, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ApplicationUser>)((applicationUser) => (__builder4) => {
                        __builder4.AddMarkupContent(41, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(42);
                        __builder4.AddAttribute(43, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 29 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(44, "Icon", "close");
                        __builder4.AddAttribute(45, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 29 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(46, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 29 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, applicationUser)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(47, "onclick", 
#line 29 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                                                                                                                                                                                               true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(48, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(50, (__value) => {
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/ApplicationUsers.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<ApplicationUser>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
