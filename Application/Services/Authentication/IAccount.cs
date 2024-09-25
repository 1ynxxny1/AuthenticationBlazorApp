using Application.DTOs;

namespace Application.Services.Authentication
{
    public interface IAccount
    {
        Task<LoginResponse> LoginAccountAsync(LoginDTO model);
        Task<RegistrationResponse> RegisterAccountAsync(RegisterUserDTO model);
    }

}
