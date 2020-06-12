#pragma checksum "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce757dfbce5e48c2060d8602c6dd744fbc712560"
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
#line 5 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
using Localhost.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
using Localhost.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-order")]
    public partial class AddTblOrder : Localhost.Pages.AddTblOrderComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Localhost.Models.Growing.TblOrder>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Localhost.Models.Growing.TblOrder>(
#line 17 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                   tblorder

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                                                                                  tblorder != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Localhost.Models.Growing.TblOrder>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Localhost.Models.Growing.TblOrder>(this, 
#line 17 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
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
                    __builder3.AddAttribute(24, "Component", "OrderSequence");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Order Sequence");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.Localhost.Pages.AddTblOrder.TypeInference.CreateRadzenNumeric_0(__builder3, 32, 33, "display: block; width: 100%", 34, "OrderSequence", 35, 
#line 25 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                                                                  tblorder.OrderSequence

#line default
#line hidden
                    , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblorder.OrderSequence = __value, tblorder.OrderSequence)), 37, () => tblorder.OrderSequence);
                    __builder3.AddMarkupContent(38, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(39);
                    __builder3.AddAttribute(40, "Component", "OrderSequence");
                    __builder3.AddAttribute(41, "style", "position: absolute");
                    __builder3.AddAttribute(42, "Text", "OrderSequence is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.OpenElement(46, "div");
                    __builder3.AddAttribute(47, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(48, "class", "row");
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col-md-3");
                    __builder3.AddMarkupContent(52, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(53);
                    __builder3.AddAttribute(54, "Component", "OrderDeliveryDate");
                    __builder3.AddAttribute(55, "style", "width: 100%");
                    __builder3.AddAttribute(56, "Text", "Order Delivery Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\n              ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "col-md-9");
                    __builder3.AddMarkupContent(61, "\n                ");
                    __Blazor.Localhost.Pages.AddTblOrder.TypeInference.CreateRadzenDatePicker_1(__builder3, 62, 63, "MM/dd/yyyy", 64, "display: block; width: 185.5px", 65, "OrderDeliveryDate", 66, 
#line 37 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                                                                                                tblorder.OrderDeliveryDate

#line default
#line hidden
                    , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblorder.OrderDeliveryDate = __value, tblorder.OrderDeliveryDate)), 68, () => tblorder.OrderDeliveryDate);
                    __builder3.AddMarkupContent(69, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(70);
                    __builder3.AddAttribute(71, "Component", "OrderDeliveryDate");
                    __builder3.AddAttribute(72, "style", "position: absolute");
                    __builder3.AddAttribute(73, "Text", "OrderDeliveryDate is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(79, "class", "row");
                    __builder3.AddMarkupContent(80, "\n              ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-md-3");
                    __builder3.AddMarkupContent(83, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(84);
                    __builder3.AddAttribute(85, "Component", "OrderDelivered");
                    __builder3.AddAttribute(86, "style", "width: 100%");
                    __builder3.AddAttribute(87, "Text", "Order Delivered");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n              ");
                    __builder3.OpenElement(90, "div");
                    __builder3.AddAttribute(91, "class", "col-md-9");
                    __builder3.AddMarkupContent(92, "\n                ");
                    __Blazor.Localhost.Pages.AddTblOrder.TypeInference.CreateRadzenCheckBox_2(__builder3, 93, 94, "OrderDelivered", 95, 
#line 49 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                               tblorder.OrderDelivered

#line default
#line hidden
                    , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblorder.OrderDelivered = __value, tblorder.OrderDelivered)), 97, () => tblorder.OrderDelivered);
                    __builder3.AddMarkupContent(98, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(103, "class", "row");
                    __builder3.AddMarkupContent(104, "\n              ");
                    __builder3.OpenElement(105, "div");
                    __builder3.AddAttribute(106, "class", "col-md-3");
                    __builder3.AddMarkupContent(107, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(108);
                    __builder3.AddAttribute(109, "Component", "CustomerId");
                    __builder3.AddAttribute(110, "style", "width: 100%");
                    __builder3.AddAttribute(111, "Text", "Tbl Customer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(112, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\n              ");
                    __builder3.OpenElement(114, "div");
                    __builder3.AddAttribute(115, "class", "col-md-9");
                    __builder3.AddMarkupContent(116, "\n                ");
                    __Blazor.Localhost.Pages.AddTblOrder.TypeInference.CreateRadzenDropDownDataGrid_3(__builder3, 117, 118, 
#line 59 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                               getTblCustomersForCustomerIdResult

#line default
#line hidden
                    , 119, "Choose TblCustomer", 120, "width: 100%", 121, "CustomerName", 122, "CustomerId", 123, "CustomerId", 124, 
#line 59 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                                                                                                                                                                   tblorder.CustomerId

#line default
#line hidden
                    , 125, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tblorder.CustomerId = __value, tblorder.CustomerId)), 126, () => tblorder.CustomerId);
                    __builder3.AddMarkupContent(127, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(128, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\n            ");
                    __builder3.OpenElement(130, "div");
                    __builder3.AddAttribute(131, "class", "row");
                    __builder3.AddMarkupContent(132, "\n              ");
                    __builder3.OpenElement(133, "div");
                    __builder3.AddAttribute(134, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(135, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(136);
                    __builder3.AddAttribute(137, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 65 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(138, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 65 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(139, "Icon", "save");
                    __builder3.AddAttribute(140, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(141, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(142);
                    __builder3.AddAttribute(143, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 67 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(144, "Text", "Cancel");
                    __builder3.AddAttribute(145, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 67 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblOrder.razor"
                                                                                    Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(148, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(149, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Localhost.Pages.AddTblOrder
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenNumeric_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Name", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenCheckBox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDownDataGrid_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "TextProperty", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "Name", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
