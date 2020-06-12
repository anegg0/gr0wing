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
    public partial class EditTblTrayComponent : ComponentBase
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
        public dynamic TrayId { get; set; }

        Localhost.Models.Growing.TblTray _tbltray;
        protected Localhost.Models.Growing.TblTray tbltray
        {
            get
            {
                return _tbltray;
            }
            set
            {
                if(!object.Equals(_tbltray, value))
                {
                    _tbltray = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<Localhost.Models.Growing.TblTrayType> _getTblTrayTypesForTrayTypeIdResult;
        protected IEnumerable<Localhost.Models.Growing.TblTrayType> getTblTrayTypesForTrayTypeIdResult
        {
            get
            {
                return _getTblTrayTypesForTrayTypeIdResult;
            }
            set
            {
                if(!object.Equals(_getTblTrayTypesForTrayTypeIdResult, value))
                {
                    _getTblTrayTypesForTrayTypeIdResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<Localhost.Models.Growing.TblSeed> _getTblSeedsForSeedIdResult;
        protected IEnumerable<Localhost.Models.Growing.TblSeed> getTblSeedsForSeedIdResult
        {
            get
            {
                return _getTblSeedsForSeedIdResult;
            }
            set
            {
                if(!object.Equals(_getTblSeedsForSeedIdResult, value))
                {
                    _getTblSeedsForSeedIdResult = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

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
            var growingGetTblTrayByTrayIdResult = await Growing.GetTblTrayByTrayId(TrayId);
            tbltray = growingGetTblTrayByTrayIdResult;

            var growingGetTblTrayTypesResult = await Growing.GetTblTrayTypes();
            getTblTrayTypesForTrayTypeIdResult = growingGetTblTrayTypesResult;

            var growingGetTblSeedsResult = await Growing.GetTblSeeds();
            getTblSeedsForSeedIdResult = growingGetTblSeedsResult;

            var growingGetTblCustomersResult = await Growing.GetTblCustomers();
            getTblCustomersForCustomerIdResult = growingGetTblCustomersResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Localhost.Models.Growing.TblTray args)
        {
            try
            {
                var growingUpdateTblTrayResult = await Growing.UpdateTblTray(TrayId, tbltray);
                DialogService.Close(tbltray);
            }
            catch (Exception growingUpdateTblTrayException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblTray");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
