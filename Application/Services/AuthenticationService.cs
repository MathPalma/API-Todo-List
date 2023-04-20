using Application.Interfaces;
using Application.Mappers;
using Application.ViewModels;
using DataAccessSql;
using Domain;
using Domain.Models;

namespace Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _repository;
        public AuthenticationService(IAuthenticationRepository repository) 
        { 
            _repository = repository;
        }

        public async Task<ReturnMessage<bool>> RegisterUser(RegisterRequestViewModel requestViewModel)
        {
            try
            {
                UserRegisterModel userRegisterModel = requestViewModel.ToModel();
                await _repository.RegisterUser(userRegisterModel);

                return new ReturnMessage<bool>(201, "Successfully registered user", true);
            }
            catch (Exception ex)
            {
                return new ReturnMessage<bool>(500, "An error occurred while trying to register the user.", false);
            }
        }
    }
}
