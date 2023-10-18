




using SectionManagement.Application.Interfaces.Authentication;
using SectionManagement.Application.Interfaces.Common;
using SectionManagement.Application.Services.AuthenticationService.Common;
using SectionManagement.Core.Models;

namespace SectionManagement.Application.Services.AuthenticationService.Command;

public class AuthenticationCommandService : IAuthenticationCommandService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationCommandService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public AuthenticationResult Register(string firstName, string lastName, string email, string Password)
    {
        // Check if user already exists
        // if (_userRepository.GetUserByEmail(email) is not null)
        // {
        //     throw new Exception("User with given email already exist");
        // }

        // Create user (generate unique ID)
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = Password,
            Role = "Normaler"
        };

        _userRepository.Add(user);

        // Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}