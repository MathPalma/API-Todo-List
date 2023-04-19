using Application.ViewModels;
using Domain.Models;

namespace Application.Mappers
{
    public static class AuthenticationMapper
    {
        public static UserRegisterModel ToModel(this RegisterRequestViewModel viewModel) => new UserRegisterModel(viewModel.FirstName, viewModel.LastName, viewModel.Username, viewModel.Email, viewModel.Password);
    }
}
