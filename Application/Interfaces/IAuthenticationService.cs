using Application.ViewModels;
using Domain;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {
        Task<ReturnMessage<bool>> RegisterUser(RegisterRequestViewModel requestViewModel);
    }
}
