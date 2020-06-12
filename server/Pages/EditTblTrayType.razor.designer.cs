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
    public partial class EditTblTrayTypeComponent : ComponentBase
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
        public dynamic TrayTypeId { get; set; }

        Localhost.Models.Growing.TblTrayType _tbltraytype;
        protected Localhost.Models.Growing.TblTrayType tbltraytype
        {
            get
            {
                return _tbltraytype;
            }
            set
            {
                if(!object.Equals(_tbltraytype, value))
                {
                    _tbltraytype = value;
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
            var growingGetTblTrayTypeByTrayTypeIdResult = await Growing.GetTblTrayTypeByTrayTypeId(TrayTypeId);
            tbltraytype = growingGetTblTrayTypeByTrayTypeIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Localhost.Models.Growing.TblTrayType args)
        {
            try
            {
                var growingUpdateTblTrayTypeResult = await Growing.UpdateTblTrayType(TrayTypeId, tbltraytype);
                DialogService.Close(tbltraytype);
            }
            catch (Exception growingUpdateTblTrayTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblTrayType");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
