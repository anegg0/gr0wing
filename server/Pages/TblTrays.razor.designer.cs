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
    public partial class TblTraysComponent : ComponentBase
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

        protected RadzenGrid<Growing.Models.Growing.TblTray> grid0;

        IEnumerable<Growing.Models.Growing.TblTray> _getTblTraysResult;
        protected IEnumerable<Growing.Models.Growing.TblTray> getTblTraysResult
        {
            get
            {
                return _getTblTraysResult;
            }
            set
            {
                if(!object.Equals(_getTblTraysResult, value))
                {
                    _getTblTraysResult = value;
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
            var growingGetTblTraysResult = await Growing.GetTblTrays();
            getTblTraysResult = growingGetTblTraysResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblTray>("Add Tbl Tray", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Growing.Models.Growing.TblTray args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblTray>("Edit Tbl Tray", new Dictionary<string, object>() { {"TrayId", args.TrayId} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var growingDeleteTblTrayResult = await Growing.DeleteTblTray(data.TrayId);
                if (growingDeleteTblTrayResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception growingDeleteTblTrayException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblTray");
            }
        }
    }
}
