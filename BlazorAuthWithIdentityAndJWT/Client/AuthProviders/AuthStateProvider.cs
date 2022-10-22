﻿using BlazorAuthWithIdentityAndJWT.Client.Features;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace BlazorAuthWithIdentityAndJWT.Client.AuthProviders
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationState _anonymous;

        public AuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _anonymous = new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _localStorage.GetItemAsync<string>("authToken");
            if (string.IsNullOrWhiteSpace(token))
                return _anonymous;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);

            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType")));
        }

        public void NotifyUserAuthentication(string token)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void NotifyUserLogout()
        {
            var authState = Task.FromResult(_anonymous);
            NotifyAuthenticationStateChanged(authState);
        }
    }
    //public async override Task<AuthenticationState> GetAuthenticationStateAsync()
    //{
    //    await Task.Delay(1500);
    //    //var claims = new List<Claim>
    //    //{
    //    //    new Claim(ClaimTypes.Name, "John Doe"),
    //    //    new Claim(ClaimTypes.Role, "Administrator")
    //    //};
    //    //var anonymous = new ClaimsIdentity(claims, "testAuthType");
    //    var anonymous = new ClaimsIdentity();
    //    return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
    //}
}