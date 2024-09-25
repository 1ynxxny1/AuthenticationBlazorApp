using Application.DTOs;
using System.Net.Http.Json;

namespace Application.Services.Authentication
{
    public class AccountService : IAccount
    {
        private readonly HttpClient httpClient;

        public AccountService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<LoginResponse> LoginAccountAsync(LoginDTO model)
        {
            var response = await httpClient.PostAsJsonAsync("api/user/login", model);
            var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
            return result!;
        }

        public async Task<RegistrationResponse> RegisterAccountAsync(RegisterUserDTO model)
        {
            var response = await httpClient.PostAsJsonAsync("api/user/register", model);
            var result = await response.Content.ReadFromJsonAsync<RegistrationResponse>();
            return result!;
        }

    }
}
