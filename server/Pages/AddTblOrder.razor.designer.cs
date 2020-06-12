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
    public partial class AddTblOrderComponent : ComponentBase
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

        IEnumerable<Localhost.Models.Growing.TblCustomer> _getTblCustomersForCustomerIdResult;
        protected IEnumerable<Localhost.Models.Growing.TblCustomer> getTblCustomersForCustomerIdResult
        {
            get
            {
                return _getTblCustomersForCustomerIdResult;
            }
            set
            {
                if(!object.Equals(_getTblCustomersForCustomerIdResult, value))
                {
                    _getTblCustomersForCustomerIdResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        Localhost.Models.Growing.TblOrder _tblorder;
        protected Localhost.Models.Growing.TblOrder tblorder
        {
            get
            {
                return _tblorder;
            }
            set
            {
                if(!object.Equals(_tblorder, value))
                {
                    _tblorder = value;
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
            var growingGetTblCustomersResult = await Growing.GetTblCustomers();
            getTblCustomersForCustomerIdResult = growingGetTblCustomersResult;

            tblorder = new Localhost.Models.Growing.TblOrder(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Localhost.Models.Growing.TblOrder args)
        {
            try
            {
                var growingCreateTblOrderResult = await Growing.CreateTblOrder(tblorder);
                DialogService.Close(tblorder);
            }
            catch (Exception growingCreateTblOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblOrder!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
