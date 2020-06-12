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
    public partial class TblSeedsComponent : ComponentBase
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

        protected RadzenGrid<Localhost.Models.Growing.TblSeed> grid0;

        IEnumerable<Localhost.Models.Growing.TblSeed> _getTblSeedsResult;
        protected IEnumerable<Localhost.Models.Growing.TblSeed> getTblSeedsResult
        {
            get
            {
                return _getTblSeedsResult;
            }
            set
            {
                if(!object.Equals(_getTblSeedsResult, value))
                {
                    _getTblSeedsResult = value;
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
            var growingGetTblSeedsResult = await Growing.GetTblSeeds();
            getTblSeedsResult = growingGetTblSeedsResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblSeed>("Add Tbl Seed", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Localhost.Models.Growing.TblSeed args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblSeed>("Edit Tbl Seed", new Dictionary<string, object>() { {"SeedId", args.SeedId} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var growingDeleteTblSeedResult = await Growing.DeleteTblSeed(data.SeedId);
                if (growingDeleteTblSeedResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception growingDeleteTblSeedException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSeed");
            }
        }
    }
}
