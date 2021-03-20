using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services.Login;
using System.Threading.Tasks;

namespace Api.Service.Services.Login
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;

        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<object> FindByLoginAsync(UserEntity userEntity)
        {
            if (userEntity != null && !string.IsNullOrWhiteSpace(userEntity.Email))
                return await _userRepository.FindByLoginAsync(userEntity.Email);
            else
                return null;
        }
    }
}
