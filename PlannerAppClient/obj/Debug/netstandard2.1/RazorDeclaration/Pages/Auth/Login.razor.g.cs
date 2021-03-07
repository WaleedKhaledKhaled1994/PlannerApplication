// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PlannerApp.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using PlannerApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using PlannerApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using PlannerApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\Pages\Auth\Login.razor"
using PlannerApp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\ENG\source\repos\PlannerApp\PlannerAppClient\Pages\Auth\Login.razor"
       
    LoginRequest model = new LoginRequest();
    string message = string.Empty;
    Models.AlertMessageType messageType = Models.AlertMessageType.Success;
    bool isBusy = false;
    Dictionary<string, string> UserInfo = new Dictionary<string, string>();

    public async Task loginUser()
    {

        isBusy = true;
        var result = await authService.LoginUserAsync(model);

        if (result.IsSuccess)
        {

            var userInfo = new PlannerApp.Client.Models.LocalUserInfo()
            {
                AccessToken = result.Message,
                Email = result.UserInfo["Email"],
                FirstName = result.UserInfo["FirstName"],
                LastName = result.UserInfo["LastName"],
                Id = result.UserInfo[System.Security.Claims.ClaimTypes.NameIdentifier]
            };
            await localService.SetItemAsync("User", userInfo);
            navigationManager.NavigateTo("/");
        }
        else
        {
            message = result.Message;
            messageType = Models.AlertMessageType.Error;


        }
        isBusy = false;

    }

    void GoToRegister()
    {
        navigationManager.NavigateTo("/auth/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationService authService { get; set; }
    }
}
#pragma warning restore 1591
