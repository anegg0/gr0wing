#pragma checksum "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f059c13c24021e550521474bc8f826fbcb4aca3c"
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
#line 5 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
using Radzen;

#line default
#line hidden
#line 6 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 7 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
using Localhost.Models.Growing;

#line default
#line hidden
#line 8 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
using Localhost.Models;

#line default
#line hidden
#line 10 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 11 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-tbl-tray")]
    public partial class AddTblTray : Localhost.Pages.AddTblTrayComponent
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
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Localhost.Models.Growing.TblTray>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Localhost.Models.Growing.TblTray>(
#line 17 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                   tbltray

#line default
#line hidden
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 17 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                tbltray != null

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Localhost.Models.Growing.TblTray>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Localhost.Models.Growing.TblTray>(this, 
#line 17 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
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
                    __builder3.AddAttribute(24, "Component", "TrayTypeId");
                    __builder3.AddAttribute(25, "style", "width: 100%");
                    __builder3.AddAttribute(26, "Text", "Tbl Tray Type");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __Blazor.Localhost.Pages.AddTblTray.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 32, 33, 
#line 25 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                               getTblTrayTypesForTrayTypeIdResult

#line default
#line hidden
                    , 34, "Choose TblTrayType", 35, "width: 100%", 36, "TrayName", 37, "TrayTypeId", 38, "TrayTypeId", 39, 
#line 25 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                                                                                               tbltray.TrayTypeId

#line default
#line hidden
                    , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.TrayTypeId = __value, tbltray.TrayTypeId)), 41, () => tbltray.TrayTypeId);
                    __builder3.AddMarkupContent(42, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\n            ");
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(47, "class", "row");
                    __builder3.AddMarkupContent(48, "\n              ");
                    __builder3.OpenElement(49, "div");
                    __builder3.AddAttribute(50, "class", "col-md-3");
                    __builder3.AddMarkupContent(51, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(52);
                    __builder3.AddAttribute(53, "Component", "SeedId");
                    __builder3.AddAttribute(54, "style", "width: 100%");
                    __builder3.AddAttribute(55, "Text", "Tbl Seed");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\n              ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col-md-9");
                    __builder3.AddMarkupContent(60, "\n                ");
                    __Blazor.Localhost.Pages.AddTblTray.TypeInference.CreateRadzenDropDownDataGrid_1(__builder3, 61, 62, 
#line 35 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                               getTblSeedsForSeedIdResult

#line default
#line hidden
                    , 63, "Choose TblSeed", 64, "width: 100%", 65, "SeedName", 66, "SeedId", 67, "SeedId", 68, 
#line 35 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                                                                                   tbltray.SeedId

#line default
#line hidden
                    , 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.SeedId = __value, tbltray.SeedId)), 70, () => tbltray.SeedId);
                    __builder3.AddMarkupContent(71, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\n            ");
                    __builder3.OpenElement(74, "div");
                    __builder3.AddAttribute(75, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(76, "class", "row");
                    __builder3.AddMarkupContent(77, "\n              ");
                    __builder3.OpenElement(78, "div");
                    __builder3.AddAttribute(79, "class", "col-md-3");
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(81);
                    __builder3.AddAttribute(82, "Component", "CustomerId");
                    __builder3.AddAttribute(83, "style", "width: 100%");
                    __builder3.AddAttribute(84, "Text", "Tbl Customer");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "class", "col-md-9");
                    __builder3.AddMarkupContent(89, "\n                ");
                    __Blazor.Localhost.Pages.AddTblTray.TypeInference.CreateRadzenDropDownDataGrid_2(__builder3, 90, 91, 
#line 45 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                               getTblCustomersForCustomerIdResult

#line default
#line hidden
                    , 92, "Choose TblCustomer", 93, "width: 100%", 94, "CustomerName", 95, "CustomerId", 96, "CustomerId", 97, 
#line 45 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                                                                                                   tbltray.CustomerId

#line default
#line hidden
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.CustomerId = __value, tbltray.CustomerId)), 99, () => tbltray.CustomerId);
                    __builder3.AddMarkupContent(100, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(101, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n            ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(105, "class", "row");
                    __builder3.AddMarkupContent(106, "\n              ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "col-md-3");
                    __builder3.AddMarkupContent(109, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(110);
                    __builder3.AddAttribute(111, "Component", "TraySequenceNumber");
                    __builder3.AddAttribute(112, "style", "width: 100%");
                    __builder3.AddAttribute(113, "Text", "Tray Sequence Number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(114, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(115, "\n              ");
                    __builder3.OpenElement(116, "div");
                    __builder3.AddAttribute(117, "class", "col-md-9");
                    __builder3.AddMarkupContent(118, "\n                ");
                    __Blazor.Localhost.Pages.AddTblTray.TypeInference.CreateRadzenNumeric_3(__builder3, 119, 120, "display: block; width: 100%", 121, "TraySequenceNumber", 122, 
#line 55 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                  tbltray.TraySequenceNumber

#line default
#line hidden
                    , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.TraySequenceNumber = __value, tbltray.TraySequenceNumber)), 124, () => tbltray.TraySequenceNumber);
                    __builder3.AddMarkupContent(125, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(126);
                    __builder3.AddAttribute(127, "Component", "TraySequenceNumber");
                    __builder3.AddAttribute(128, "style", "position: absolute");
                    __builder3.AddAttribute(129, "Text", "TraySequenceNumber is required");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(130, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\n            ");
                    __builder3.OpenElement(133, "div");
                    __builder3.AddAttribute(134, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(135, "class", "row");
                    __builder3.AddMarkupContent(136, "\n              ");
                    __builder3.OpenElement(137, "div");
                    __builder3.AddAttribute(138, "class", "col-md-3");
                    __builder3.AddMarkupContent(139, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(140);
                    __builder3.AddAttribute(141, "Component", "TraySowingDate");
                    __builder3.AddAttribute(142, "style", "width: 100%");
                    __builder3.AddAttribute(143, "Text", "Tray Sowing Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(145, "\n              ");
                    __builder3.OpenElement(146, "div");
                    __builder3.AddAttribute(147, "class", "col-md-9");
                    __builder3.AddMarkupContent(148, "\n                ");
                    __Blazor.Localhost.Pages.AddTblTray.TypeInference.CreateRadzenDatePicker_4(__builder3, 149, 150, "MM/dd/yyyy", 151, "display: block; float: left; width: 203.5px", 152, "TraySowingDate", 153, 
#line 67 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                                             tbltray.TraySowingDate

#line default
#line hidden
                    , 154, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.TraySowingDate = __value, tbltray.TraySowingDate)), 155, () => tbltray.TraySowingDate);
                    __builder3.AddMarkupContent(156, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(157, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(158, "\n            ");
                    __builder3.OpenElement(159, "div");
                    __builder3.AddAttribute(160, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(161, "class", "row");
                    __builder3.AddMarkupContent(162, "\n              ");
                    __builder3.OpenElement(163, "div");
                    __builder3.AddAttribute(164, "class", "col-md-3");
                    __builder3.AddMarkupContent(165, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(166);
                    __builder3.AddAttribute(167, "Component", "TrayUpdateDate");
                    __builder3.AddAttribute(168, "style", "width: 100%");
                    __builder3.AddAttribute(169, "Text", "Tray Update Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(170, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(171, "\n              ");
                    __builder3.OpenElement(172, "div");
                    __builder3.AddAttribute(173, "class", "col-md-9");
                    __builder3.AddMarkupContent(174, "\n                ");
                    __Blazor.Localhost.Pages.AddTblTray.TypeInference.CreateRadzenDatePicker_5(__builder3, 175, 176, "MM/dd/yyyy", 177, "display: block; float: left; width: 203.5px", 178, "TrayUpdateDate", 179, 
#line 77 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                                             tbltray.TrayUpdateDate

#line default
#line hidden
                    , 180, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.TrayUpdateDate = __value, tbltray.TrayUpdateDate)), 181, () => tbltray.TrayUpdateDate);
                    __builder3.AddMarkupContent(182, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(183, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(184, "\n            ");
                    __builder3.OpenElement(185, "div");
                    __builder3.AddAttribute(186, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(187, "class", "row");
                    __builder3.AddMarkupContent(188, "\n              ");
                    __builder3.OpenElement(189, "div");
                    __builder3.AddAttribute(190, "class", "col-md-3");
                    __builder3.AddMarkupContent(191, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(192);
                    __builder3.AddAttribute(193, "Component", "ExpiryDate");
                    __builder3.AddAttribute(194, "style", "width: 100%");
                    __builder3.AddAttribute(195, "Text", "Expiry Date");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(196, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(197, "\n              ");
                    __builder3.OpenElement(198, "div");
                    __builder3.AddAttribute(199, "class", "col-md-9");
                    __builder3.AddAttribute(200, "style", "float: none; text-align: justify");
                    __builder3.AddMarkupContent(201, "\n                ");
                    __Blazor.Localhost.Pages.AddTblTray.TypeInference.CreateRadzenDatePicker_6(__builder3, 202, 203, "MM/dd/yyyy", 204, "width: 203.5px", 205, "ExpiryDate", 206, 
#line 87 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                tbltray.ExpiryDate

#line default
#line hidden
                    , 207, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.ExpiryDate = __value, tbltray.ExpiryDate)), 208, () => tbltray.ExpiryDate);
                    __builder3.AddMarkupContent(209, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(210, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(211, "\n            ");
                    __builder3.OpenElement(212, "div");
                    __builder3.AddAttribute(213, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(214, "class", "row");
                    __builder3.AddMarkupContent(215, "\n              ");
                    __builder3.OpenElement(216, "div");
                    __builder3.AddAttribute(217, "class", "col-md-3");
                    __builder3.AddMarkupContent(218, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(219);
                    __builder3.AddAttribute(220, "Component", "Status");
                    __builder3.AddAttribute(221, "style", "width: 100%");
                    __builder3.AddAttribute(222, "Text", "Status");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(223, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(224, "\n              ");
                    __builder3.OpenElement(225, "div");
                    __builder3.AddAttribute(226, "class", "col-md-9");
                    __builder3.AddMarkupContent(227, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(228);
                    __builder3.AddAttribute(229, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#line 97 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                          50

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(230, "style", "width: 100%");
                    __builder3.AddAttribute(231, "Name", "Status");
                    __builder3.AddAttribute(232, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 97 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                 tbltray.Status

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(233, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tbltray.Status = __value, tbltray.Status))));
                    __builder3.AddAttribute(234, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tbltray.Status));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(235, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(236, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(237, "\n            ");
                    __builder3.OpenElement(238, "div");
                    __builder3.AddAttribute(239, "class", "row");
                    __builder3.AddMarkupContent(240, "\n              ");
                    __builder3.OpenElement(241, "div");
                    __builder3.AddAttribute(242, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(243, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(244);
                    __builder3.AddAttribute(245, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 103 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(246, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#line 103 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(247, "Icon", "save");
                    __builder3.AddAttribute(248, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(249, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(250);
                    __builder3.AddAttribute(251, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#line 105 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                           ButtonStyle.Light

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(252, "style", "margin-top: 1px; width: 111.75px");
                    __builder3.AddAttribute(253, "Text", "Cancel");
                    __builder3.AddAttribute(254, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 105 "/home/anegg0/Dev/gr0wing/server/Pages/AddTblTray.razor"
                                                                                                                             Button2Click

#line default
#line hidden
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(255, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(256, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(257, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(258, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(259, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(260, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Localhost.Pages.AddTblTray
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
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
        public static void CreateRadzenDropDownDataGrid_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
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
        public static void CreateRadzenDropDownDataGrid_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, System.Object __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
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
        public static void CreateRadzenNumeric_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
        public static void CreateRadzenDatePicker_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
        public static void CreateRadzenDatePicker_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
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
    }
}
#pragma warning restore 1591
