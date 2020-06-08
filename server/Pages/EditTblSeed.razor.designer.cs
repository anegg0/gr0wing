using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Growing.Models.Growing;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Growing.Models;

namespace Growing.Pages
{
    public partial class EditTblSeedComponent : ComponentBase
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
        public dynamic SeedId { get; set; }

        Growing.Models.Growing.TblSeed _tblseed;
        protected Growing.Models.Growing.TblSeed tblseed
        {
            get
            {
                return _tblseed;
            }
            set
            {
                if(!object.Equals(_tblseed, value))
                {
                    _tblseed = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<Growing.Models.Growing.TblSeason> _getTblSeasonsForSeasonIdResult;
        protected IEnumerable<Growing.Models.Growing.TblSeason> getTblSeasonsForSeasonIdResult
        {
            get
            {
                return _getTblSeasonsForSeasonIdResult;
            }
            set
            {
                if(!object.Equals(_getTblSeasonsForSeasonIdResult, value))
                {
                    _getTblSeasonsForSeasonIdResult = value;
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
            var growingGetTblSeedBySeedIdResult = await Growing.GetTblSeedBySeedId(SeedId);
            tblseed = growingGetTblSeedBySeedIdResult;

            var growingGetTblSeasonsResult = await Growing.GetTblSeasons();
            getTblSeasonsForSeasonIdResult = growingGetTblSeasonsResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(Growing.Models.Growing.TblSeed args)
        {
            try
            {
                var growingUpdateTblSeedResult = await Growing.UpdateTblSeed(SeedId, tblseed);
                DialogService.Close(tblseed);
            }
            catch (Exception growingUpdateTblSeedException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update TblSeed");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
