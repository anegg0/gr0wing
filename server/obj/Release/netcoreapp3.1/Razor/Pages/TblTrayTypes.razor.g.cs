#pragma checksum "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4701ebd7a684785f0731bc16a63f986e8e7418e"
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
#line 5 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
using Localhost.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
using Localhost.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-tray-types")]
    public partial class TblTrayTypes : Localhost.Pages.TblTrayTypesComponent
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
                __builder2.AddAttribute(6, "Text", "Tray Types");
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
#line 19 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Localhost.Models.Growing.TblTrayType>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Localhost.Models.Growing.TblTrayType>>(
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                                     getTblTrayTypesResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Localhost.Models.Growing.TblTrayType>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Localhost.Models.Growing.TblTrayType>(this, 
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                                                                                                                     Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Localhost.Models.Growing.TblTrayType>>(28);
                    __builder3.AddAttribute(29, "Property", "TrayTypeId");
                    __builder3.AddAttribute(30, "Title", "Tray Type Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Localhost.Models.Growing.TblTrayType>>(32);
                    __builder3.AddAttribute(33, "Property", "TrayName");
                    __builder3.AddAttribute(34, "Title", "Tray Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Localhost.Models.Growing.TblTrayType>>(36);
                    __builder3.AddAttribute(37, "Property", "TrayHandle");
                    __builder3.AddAttribute(38, "Title", "Tray Handle");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Localhost.Models.Growing.TblTrayType>>(40);
                    __builder3.AddAttribute(41, "Property", "TrayLength");
                    __builder3.AddAttribute(42, "Title", "Tray Length");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Localhost.Models.Growing.TblTrayType>>(44);
                    __builder3.AddAttribute(45, "Property", "TrayWidth");
                    __builder3.AddAttribute(46, "Title", "Tray Width");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Localhost.Models.Growing.TblTrayType>>(48);
                    __builder3.AddAttribute(49, "Property", "TrayHeight");
                    __builder3.AddAttribute(50, "Title", "Tray Height");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Localhost.Models.Growing.TblTrayType>>(52);
                    __builder3.AddAttribute(53, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 35 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                       false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(54, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 35 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                                        false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(55, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 35 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                                                          TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(56, "Width", "70px");
                    __builder3.AddAttribute(57, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Localhost.Models.Growing.TblTrayType>)((localhostModelsGrowingTblTrayType) => (__builder4) => {
                        __builder4.AddMarkupContent(58, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(59);
                        __builder4.AddAttribute(60, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 37 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(61, "Icon", "close");
                        __builder4.AddAttribute(62, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 37 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(63, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 37 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, localhostModelsGrowingTblTrayType)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(64, "onclick", 
#line 37 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                                                                                                                                                                                                                 true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(67, (__value) => {
#line 21 "/home/anegg0/Dev/gr0wing/server/Pages/TblTrayTypes.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Localhost.Models.Growing.TblTrayType>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
