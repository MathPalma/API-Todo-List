using Application.Interfaces;
using Application.Mappers;
using Application.ViewModels;
using DataAccessSql;
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

        public async Task RegisterUser(RegisterRequestViewModel requestViewModel)
        {
            UserRegisterModel userRegisterModel = requestViewModel.ToModel();
        }
    }
}
