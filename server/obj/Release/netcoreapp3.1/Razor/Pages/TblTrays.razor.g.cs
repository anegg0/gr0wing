#pragma checksum "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0fd9e531b593f87fd532cf59068e8d6e7345130"
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
#line 5 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
using Growing.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
using Growing.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-trays")]
    public partial class TblTrays : Growing.Pages.TblTraysComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Trays");
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
#line 19 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Growing.Models.Growing.TblTray>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Growing.Models.Growing.TblTray>>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                                     getTblTraysResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Growing.Models.Growing.TblTray>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Growing.Models.Growing.TblTray>(this, 
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                                                                                                           Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(28);
                    __builder3.AddAttribute(29, "Property", "CustomerId");
                    __builder3.AddAttribute(30, "SortProperty", "TblCustomer.CustomerContactName");
                    __builder3.AddAttribute(31, "FilterProperty", "TblCustomer.CustomerContactName");
                    __builder3.AddAttribute(32, "Title", "Tbl Customer");
                    __builder3.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Growing.Models.Growing.TblTray>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(34, "\n              ");
                        __builder4.AddContent(35, 
#line 25 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                data.TblCustomer?.CustomerContactName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(36, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(38);
                    __builder3.AddAttribute(39, "Property", "ExpiryDate");
                    __builder3.AddAttribute(40, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(41, "Title", "Expiry Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(43);
                    __builder3.AddAttribute(44, "Property", "SeedId");
                    __builder3.AddAttribute(45, "SortProperty", "TblSeed.CurrentDTM");
                    __builder3.AddAttribute(46, "FilterProperty", "TblSeed.CurrentDTM");
                    __builder3.AddAttribute(47, "Title", "Tbl Seed");
                    __builder3.AddAttribute(48, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Growing.Models.Growing.TblTray>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(49, "\n              ");
                        __builder4.AddContent(50, 
#line 32 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                data.TblSeed?.CurrentDTM

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(51, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(52, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(53);
                    __builder3.AddAttribute(54, "Property", "Status");
                    __builder3.AddAttribute(55, "Title", "Status");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(57);
                    __builder3.AddAttribute(58, "Property", "TrayId");
                    __builder3.AddAttribute(59, "Title", "Tray Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(61);
                    __builder3.AddAttribute(62, "Property", "TraySequenceNumber");
                    __builder3.AddAttribute(63, "Title", "Tray Sequence Number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(65);
                    __builder3.AddAttribute(66, "Property", "TraySowingDate");
                    __builder3.AddAttribute(67, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(68, "Title", "Tray Sowing Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(70);
                    __builder3.AddAttribute(71, "Property", "TrayTypeId");
                    __builder3.AddAttribute(72, "SortProperty", "TblTrayType.TrayHandle");
                    __builder3.AddAttribute(73, "FilterProperty", "TblTrayType.TrayHandle");
                    __builder3.AddAttribute(74, "Title", "Tbl Tray Type");
                    __builder3.AddAttribute(75, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Growing.Models.Growing.TblTray>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(76, "\n              ");
                        __builder4.AddContent(77, 
#line 45 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                data.TblTrayType?.TrayHandle

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(78, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(80);
                    __builder3.AddAttribute(81, "Property", "TrayUpdateDate");
                    __builder3.AddAttribute(82, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(83, "Title", "Tray Update Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(84, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblTray>>(85);
                    __builder3.AddAttribute(86, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 50 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                 false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(87, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 50 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(88, "Width", "70px");
                    __builder3.AddAttribute(89, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 50 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                                                                 TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(90, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Growing.Models.Growing.TblTray>)((growingModelsGrowingTblTray) => (__builder4) => {
                        __builder4.AddMarkupContent(91, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(92);
                        __builder4.AddAttribute(93, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 52 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(94, "Icon", "close");
                        __builder4.AddAttribute(95, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 52 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(96, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 52 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, growingModelsGrowingTblTray)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(97, "onclick", 
#line 52 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                                                                                                                                                                                                           true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(98, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(100, (__value) => {
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblTrays.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Growing.Models.Growing.TblTray>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
