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
    public partial class TblSuppliersComponent : ComponentBase
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

        protected RadzenGrid<Growing.Models.Growing.TblSupplier> grid0;

        IEnumerable<Growing.Models.Growing.TblSupplier> _getTblSuppliersResult;
        protected IEnumerable<Growing.Models.Growing.TblSupplier> getTblSuppliersResult
        {
            get
            {
                return _getTblSuppliersResult;
            }
            set
            {
                if(!object.Equals(_getTblSuppliersResult, value))
                {
                    _getTblSuppliersResult = value;
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
            var growingGetTblSuppliersResult = await Growing.GetTblSuppliers();
            getTblSuppliersResult = growingGetTblSuppliersResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblSupplier>("Add Tbl Supplier", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Growing.Models.Growing.TblSupplier args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblSupplier>("Edit Tbl Supplier", new Dictionary<string, object>() { {"SupplierId", args.SupplierId} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var growingDeleteTblSupplierResult = await Growing.DeleteTblSupplier(data.SupplierId);
                if (growingDeleteTblSupplierResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception growingDeleteTblSupplierException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblSupplier");
            }
        }
    }
}
