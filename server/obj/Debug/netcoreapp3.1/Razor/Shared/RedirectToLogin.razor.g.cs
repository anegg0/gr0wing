#pragma checksum "/home/anegg0/Dev/radzen/server/Shared/RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "681690c6c92c46d44ae8155ef6ae5024752d9b3f"
// <auto-generated/>
#pragma warning disable 1591
namespace Growing.Shared
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
#line 8 "/home/anegg0/Dev/radzen/server/_Imports.razor"
using Radzen;

#line default
#line hidden
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 4 "/home/anegg0/Dev/radzen/server/Shared/RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        if (!Security.IsAuthenticated())
        {
            UriHelper.NavigateTo("Login", true);
        }
        else
        {
            UriHelper.NavigateTo("Unauthorized", true);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecurityService Security { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
