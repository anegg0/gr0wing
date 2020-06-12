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
    public partial class TblOrdersComponent : ComponentBase
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

        protected RadzenGrid<Localhost.Models.Growing.TblOrder> grid0;

        IEnumerable<Localhost.Models.Growing.TblOrder> _getTblOrdersResult;
        protected IEnumerable<Localhost.Models.Growing.TblOrder> getTblOrdersResult
        {
            get
            {
                return _getTblOrdersResult;
            }
            set
            {
                if(!object.Equals(_getTblOrdersResult, value))
                {
                    _getTblOrdersResult = value;
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
            var growingGetTblOrdersResult = await Growing.GetTblOrders();
            getTblOrdersResult = growingGetTblOrdersResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblOrder>("Add Tbl Order", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Localhost.Models.Growing.TblOrder args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblOrder>("Edit Tbl Order", new Dictionary<string, object>() { {"OrderId", args.OrderId} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var growingDeleteTblOrderResult = await Growing.DeleteTblOrder(data.OrderId);
                if (growingDeleteTblOrderResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception growingDeleteTblOrderException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblOrder");
            }
        }
    }
}
