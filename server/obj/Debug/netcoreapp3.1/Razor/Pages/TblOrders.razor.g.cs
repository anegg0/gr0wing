#pragma checksum "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945d61900d596ca81620d87da459e74380411d86"
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
#line 5 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
using Growing.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
using Growing.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/tbl-orders")]
    public partial class TblOrders : Growing.Pages.TblOrdersComponent
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
                __builder2.AddAttribute(6, "Text", "Tbl Orders");
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
#line 19 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                               Button0Click

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<Growing.Models.Growing.TblOrder>>(20);
                __builder2.AddAttribute(21, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                 true

#line default
#line hidden
                ));
                __builder2.AddAttribute(22, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                    true

#line default
#line hidden
                ));
                __builder2.AddAttribute(23, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                        true

#line default
#line hidden
                ));
                __builder2.AddAttribute(24, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Growing.Models.Growing.TblOrder>>(
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                                     getTblOrdersResult

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "RowSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Growing.Models.Growing.TblOrder>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Growing.Models.Growing.TblOrder>(this, 
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                                                                                                             Grid0RowSelect

#line default
#line hidden
                )));
                __builder2.AddAttribute(26, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblOrder>>(28);
                    __builder3.AddAttribute(29, "Property", "CustomerId");
                    __builder3.AddAttribute(30, "SortProperty", "TblCustomer.CustomerContactName");
                    __builder3.AddAttribute(31, "FilterProperty", "TblCustomer.CustomerContactName");
                    __builder3.AddAttribute(32, "Title", "Tbl Customer");
                    __builder3.AddAttribute(33, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Growing.Models.Growing.TblOrder>)((data) => (__builder4) => {
                        __builder4.AddMarkupContent(34, "\n              ");
                        __builder4.AddContent(35, 
#line 25 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                data.TblCustomer?.CustomerContactName

#line default
#line hidden
                        );
                        __builder4.AddMarkupContent(36, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(37, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblOrder>>(38);
                    __builder3.AddAttribute(39, "Property", "OrderDelivered");
                    __builder3.AddAttribute(40, "Title", "Order Delivered");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblOrder>>(42);
                    __builder3.AddAttribute(43, "Property", "OrderDeliveryDate");
                    __builder3.AddAttribute(44, "FormatString", "{0:MM/dd/yyyy}");
                    __builder3.AddAttribute(45, "Title", "Order Delivery Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblOrder>>(47);
                    __builder3.AddAttribute(48, "Property", "OrderId");
                    __builder3.AddAttribute(49, "Title", "Order Id");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblOrder>>(51);
                    __builder3.AddAttribute(52, "Property", "OrderSequence");
                    __builder3.AddAttribute(53, "Title", "Order Sequence");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<Growing.Models.Growing.TblOrder>>(55);
                    __builder3.AddAttribute(56, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 36 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                  false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(57, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 36 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                                   false

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(58, "Width", "70px");
                    __builder3.AddAttribute(59, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#line 36 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                                                                  TextAlign.Center

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(60, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Growing.Models.Growing.TblOrder>)((growingModelsGrowingTblOrder) => (__builder4) => {
                        __builder4.AddMarkupContent(61, "\n                ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(62);
                        __builder4.AddAttribute(63, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 38 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(64, "Icon", "close");
                        __builder4.AddAttribute(65, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#line 38 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
                        ));
                        __builder4.AddAttribute(66, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 38 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                                             (args) =>GridDeleteButtonClick(args, growingModelsGrowingTblOrder)

#line default
#line hidden
                        )));
                        __builder4.AddEventStopPropagationAttribute(67, "onclick", 
#line 38 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                                                                                                                                                                                                            true

#line default
#line hidden
                        );
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(68, "\n              ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\n          ");
                }
                ));
                __builder2.AddComponentReferenceCapture(70, (__value) => {
#line 21 "/home/anegg0/Dev/radzen/server/Pages/TblOrders.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<Growing.Models.Growing.TblOrder>)__value;

#line default
#line hidden
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591