using Application.ViewModels;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {
        Task RegisterUser(RegisterRequestViewModel requestViewModel);
    }
}
