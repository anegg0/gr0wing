﻿using System;
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
    public partial class TblCustomersComponent : ComponentBase
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

        protected RadzenGrid<Growing.Models.Growing.TblCustomer> grid0;

        IEnumerable<Growing.Models.Growing.TblCustomer> _getTblCustomersResult;
        protected IEnumerable<Growing.Models.Growing.TblCustomer> getTblCustomersResult
        {
            get
            {
                return _getTblCustomersResult;
            }
            set
            {
                if(!object.Equals(_getTblCustomersResult, value))
                {
                    _getTblCustomersResult = value;
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
            var growingGetTblCustomersResult = await Growing.GetTblCustomers();
            getTblCustomersResult = growingGetTblCustomersResult;
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddTblCustomer>("Add Tbl Customer", null);
            grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(Growing.Models.Growing.TblCustomer args)
        {
            var dialogResult = await DialogService.OpenAsync<EditTblCustomer>("Edit Tbl Customer", new Dictionary<string, object>() { {"CustomerId", args.CustomerId} });
            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                var growingDeleteTblCustomerResult = await Growing.DeleteTblCustomer(data.CustomerId);
                if (growingDeleteTblCustomerResult != null) {
                    grid0.Reload();
}
            }
            catch (Exception growingDeleteTblCustomerException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete TblCustomer");
            }
        }
    }
}