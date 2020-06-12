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
    public partial class EditTblSeasonComponent : ComponentBase
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
        public dynamic SeasonId { get; set; }

        Localhost.Models.Growing.TblSeason _tblseason;
        protected Localhost.Models.Growing.TblSeason tblseason
        {
            get
            {
                return _tblseason;
            }
            set
            {
                if(!object.Equals(_tblseason, value))
                {
                    _tblseason = value;
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
            var growingGetTblSeasonBySeasonIdResult = await Growing.GetTblSeasonBySeasonId(SeasonId);
            tblseason = growingGetTblSeasonBySeasonIdResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Localhost.Models.Growing.TblSeason args)
        {
            try
            {
                var growingUpdateTblSeasonResult = await Growing.UpdateTblSeason(SeasonId, tblseason);
                DialogService.Close(tblseason);
            }
            catch (Exception growingUpdateTblSeasonException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSeason");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
