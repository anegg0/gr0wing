using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Localhost.Models.Growing;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Localhost.Models;

namespace Localhost.Pages
{
    public partial class EditTblCustomerComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }


        [Inject]
        protected GrowingService Growing { get; set; }

        [Parameter]
        public dynamic CustomerId { get; set; }

        Localhost.Models.Growing.TblCustomer _tblcustomer;
        protected Localhost.Models.Growing.TblCustomer tblcustomer
        {
            get
            {
                return _tblcustomer;
            }
            set
            {
                if(!object.Equals(_tblcustomer, value))
                {
                    _tblcustomer = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }
        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }

        }
        protected async System.Threading.Tasks.Task Load()
        {
            var growingGetTblCustomerByCustomerIdResult = await Growing.GetTblCustomerByCustomerId(CustomerId);
            tblcustomer = growingGetTblCustomerByCustomerIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Localhost.Models.Growing.TblCustomer args)
        {
            try
            {
                var growingUpdateTblCustomerResult = await Growing.UpdateTblCustomer(CustomerId, tblcustomer);
                DialogService.Close(tblcustomer);
            }
            catch (Exception growingUpdateTblCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblCustomer");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
