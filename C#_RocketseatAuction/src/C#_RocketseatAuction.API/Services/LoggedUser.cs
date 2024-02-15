using C__RocketseatAuction.API.Contracts;
using C__RocketseatAuction.API.Entities;

namespace C__RocketseatAuction.API.Services
{
    public class LoggedUser : ILoggedUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;
        public LoggedUser(IHttpContextAccessor httpContext, IUserRepository repository)
        {
            _httpContextAccessor = httpContext;
            _userRepository = repository;
        }
        public User User()
        {
            var token = TokenOnRequest();
            var email = FromBase64String(token);

            return _userRepository.GetUserByEmail(email);
        }

        private string TokenOnRequest()
        {
            var authentication = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

            return authentication["Bearer ".Length..];
        }
        private string FromBase64String(string base64)
        {
            var data = Convert.FromBase64String(base64);
            return System.Text.Encoding.UTF8.GetString(data);
        }
    }
}
