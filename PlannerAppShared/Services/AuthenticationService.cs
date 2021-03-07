using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AKSoftware.WebApi.Client;
using PlannerApp.Shared.Models;

namespace PlannerApp.Shared.Services
{
   public class AuthenticationService
    {
        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public AuthenticationService(string url)
        {
            _baseUrl = url;
        }

        public async Task<UserManagerResponse> RegisterUserAsync(RegisterRequest request)
        {
            var responce = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/register", request);
           
            return responce.Result;
        }
        public async Task<UserManagerResponse> LoginUserAsync(LoginRequest request)
        {
            var responce = await client.PostAsync<UserManagerResponse>($"{_baseUrl}/api/auth/login", request);

            return responce.Result;
        }
    }
}
