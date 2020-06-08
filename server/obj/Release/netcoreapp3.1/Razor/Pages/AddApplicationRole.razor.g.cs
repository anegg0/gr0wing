#pragma checksum "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3c47811a0a1c24021c04f44bf78648c3ca1cc35"
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
#line 5 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
using Growing.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
using Growing.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-application-role")]
    public partial class AddApplicationRole : Growing.Pages.AddApplicationRoleComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<IdentityRole>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<IdentityRole>(
#line 17 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                                        role

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                                                         role != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<IdentityRole>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<IdentityRole>(this, 
#line 17 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                                                                                 Form0Submit

#line default
#line hidden
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Component", "Name");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(34, "Name", "Name");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 25 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                                                                  role.Name

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => role.Name = __value, role.Name))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => role.Name));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "Name");
                    __builder3.AddAttribute(41, "style", "position: absolute");
                    __builder3.AddAttribute(42, "Text", "Name is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "class", "row");
                    __builder3.AddMarkupContent(48, "\n              ");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(51, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(52);
                    __builder3.AddAttribute(53, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 33 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(54, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 33 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(55, "Icon", "save");
                    __builder3.AddAttribute(56, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(58);
                    __builder3.AddAttribute(59, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 35 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "Text", "Cancel");
                    __builder3.AddAttribute(61, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 35 "/home/anegg0/Dev/radzen/server/Pages/AddApplicationRole.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
