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
    public partial class TblSeasonsComponent : ComponentBase
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

        protected RadzenGrid<Growing.Models.Growing.TblSeason> grid0;

        IEnumerable<Growing.Models.Growing.TblSeason> _getTblSeasonsResult;
        protected IEnumerable<Growing.Models.Growing.TblSeason> getTblSeasonsResult
        {
            get
            {
                return _getTblSeasonsResult;
            }
            set
            {
                if(!object.Equals(_getTblSeasonsResult, value))
                {
                    _getTblSeasonsResult = value;
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
            var growingGetTblSeasonsResult = await Growing.GetTblSeasons();
            getTblSeasonsResult = growingGetTblSeasonsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblSeason>("Add Tbl Season", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Growing.Models.Growing.TblSeason args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblSeason>("Edit Tbl Season", new Dictionary<string, object>() { {"SeasonId", args.SeasonId} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var growingDeleteTblSeasonResult = await Growing.DeleteTblSeason(data.SeasonId);
                if (growingDeleteTblSeasonResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception growingDeleteTblSeasonException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSeason");
            }
        }
    }
}
