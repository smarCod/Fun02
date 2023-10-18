
using SectionManagement.Application.Interfaces.Authentication;
using SectionManagement.Application.Interfaces.Common;
using SectionManagement.Application.Services.AuthenticationService.Common;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.AuthenticationService.Query;

public class AuthenticationQueryService : IAuthenticationQueryService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationQueryService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Login(string email, string password)
    {
        // 1. validate the user exists
        var result = _userRepository.GetUserByEmail(email);
        if (result == null)
        {
            throw new Exception("user with given email does not exist");
        }

        // 2. Validate the password is correct
        if (result.Password != password)
        {
            throw new Exception("Invalid password");
        }

        // 3. Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(result);

        return new AuthenticationResult(
            result,
            token);
    }
}
