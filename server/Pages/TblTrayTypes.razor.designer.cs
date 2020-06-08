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
    public partial class TblTrayTypesComponent : ComponentBase
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

        protected RadzenGrid<Growing.Models.Growing.TblTrayType> grid0;

        IEnumerable<Growing.Models.Growing.TblTrayType> _getTblTrayTypesResult;
        protected IEnumerable<Growing.Models.Growing.TblTrayType> getTblTrayTypesResult
        {
            get
            {
                return _getTblTrayTypesResult;
            }
            set
            {
                if(!object.Equals(_getTblTrayTypesResult, value))
                {
                    _getTblTrayTypesResult = value;
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
            var growingGetTblTrayTypesResult = await Growing.GetTblTrayTypes();
            getTblTrayTypesResult = growingGetTblTrayTypesResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblTrayType>("Add Tbl Tray Type", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Growing.Models.Growing.TblTrayType args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblTrayType>("Edit Tbl Tray Type", new Dictionary<string, object>() { {"TrayTypeId", args.TrayTypeId} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var growingDeleteTblTrayTypeResult = await Growing.DeleteTblTrayType(data.TrayTypeId);
                if (growingDeleteTblTrayTypeResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception growingDeleteTblTrayTypeException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblTrayType");
            }
        }
    }
}
