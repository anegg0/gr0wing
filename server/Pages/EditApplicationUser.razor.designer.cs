﻿using System;
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
    public partial class EditApplicationUserComponent : ComponentBase
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
        public dynamic Id { get; set; }

        ApplicationUser _user;
        protected ApplicationUser user
        {
            get
            {
                return _user;
            }
            set
            {
                if(!object.Equals(_user, value))
                {
                    _user = value;
                    InvokeAsync(() => { StateHasChanged(); });
                }
            }
        }

        IEnumerable<IdentityRole> _roles;
        protected IEnumerable<IdentityRole> roles
        {
            get
            {
                return _roles;
            }
            set
            {
                if(!object.Equals(_roles, value))
                {
                    _roles = value;
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
            var securityGetUserByIdResult = await Security.GetUserById($"{Id}");
            user = securityGetUserByIdResult;

            var securityGetRolesResult = await Security.GetRoles();
            roles = securityGetRolesResult;
        }

        protected async System.Threading.Tasks.Task Form0Submit(ApplicationUser args)
        {
            try
            {
                var securityUpdateUserResult = await Security.UpdateUser($"{Id}", args);
                DialogService.Close(null);
            }
            catch (Exception securityUpdateUserException)
            {
                    NotificationService.Notify(NotificationSeverity.Error, $"Cannot update user", $"{securityUpdateUserException.Message}");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
