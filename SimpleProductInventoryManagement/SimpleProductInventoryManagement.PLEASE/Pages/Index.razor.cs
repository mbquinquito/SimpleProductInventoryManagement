
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using SimpleProductInventoryManagement.PLEASE.Contracts;
using SimpleProductInventoryManagement.PLEASE.Providers;

namespace SimpleProductInventoryManagement.PLEASE.Pages;

public partial class Index
{
    [Inject]
    private AuthenticationStateProvider AuthenticationStateProvider { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [Inject]
    public IAuthenticationService AuthenticationService { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await ((ApiAuthenticationStateProvider)AuthenticationStateProvider).GetAuthenticationStateAsync();
    }

    protected void GoToLogin()
    {
        NavigationManager.NavigateTo("login/");
    }


    protected async void Logout()
    {
        await AuthenticationService.Logout();
    }

    protected void GoToProducts()
    {
        NavigationManager.NavigateTo("products/");
    }
}