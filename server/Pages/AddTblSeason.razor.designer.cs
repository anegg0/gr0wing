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
    public partial class AddTblSeasonComponent : ComponentBase
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

        Growing.Models.Growing.TblSeason _tblseason;
        protected Growing.Models.Growing.TblSeason tblseason
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
            tblseason = new Growing.Models.Growing.TblSeason(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Growing.Models.Growing.TblSeason args)
        {
            try
            {
                var growingCreateTblSeasonResult = await Growing.CreateTblSeason(tblseason);
                DialogService.Close(tblseason);
            }
            catch (Exception growingCreateTblSeasonException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to create new TblSeason!");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
