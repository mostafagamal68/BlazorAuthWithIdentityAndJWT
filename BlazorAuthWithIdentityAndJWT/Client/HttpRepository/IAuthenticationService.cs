using BlazorAuthWithIdentityAndJWT.Shared.DTO;

namespace BlazorAuthWithIdentityAndJWT.Client.HttpRepository
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);

        Task<AuthResponseDto> VerifyEmail(string id);
        Task Logout();
        Task<string> RefreshToken();
    }
}
