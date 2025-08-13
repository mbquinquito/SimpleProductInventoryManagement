using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using SimpleProductInventoryManagement.BlazorUI.Providers;
using SimpleProductInventoryManagement.BlazorUI.Contracts;
using SimpleProductInventoryManagement.BlazorUI.Models.Authentication;
using System.Net.Http.Json;

namespace SimpleProductInventoryManagement.BlazorUI.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localstorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(IHttpClientFactory factory, ILocalStorageService localstorage, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = factory.CreateClient("PublicAPI");
            _localstorage = localstorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(string email, string password)
        {
            try
            {
                var loginRequest = new AuthRequestVM
                {
                    Email = email,
                    Password = password
                };

                var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginRequest);

                if (!response.IsSuccessStatusCode)
                    return false;

                var authResponse = await response.Content.ReadFromJsonAsync<AuthResponseVM>();


                if (authResponse != null && !string.IsNullOrWhiteSpace(authResponse.Token))
                {
                    Console.WriteLine($"[DEBUG] Received token from API: {authResponse.Token}");

                    await _localstorage.SetItemAsync("token", authResponse.Token);
                    Console.WriteLine("[DEBUG] Token saved to local storage");

                    var storedToken = await _localstorage.GetItemAsync<string>("token");
                    Console.WriteLine($"[DEBUG] Token currently in local storage: {storedToken}");
                    
                    await ((ApiAuthenticationStateProvider)_authenticationStateProvider).LoggedIn();
                    return true;
                }
                else
                {
                    Console.WriteLine("[DEBUG] authResponse is null or token is empty");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Authentication failed: {ex.Message}");
                return false;
            }
        }

        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)_authenticationStateProvider).LoggedOut();
        }

       
    }
}