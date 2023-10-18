




using SectionManagement.Application.Services.AuthenticationService.Common;

namespace SectionManagement.Application.Services.AuthenticationService.Command;

public interface IAuthenticationCommandService
{
    AuthenticationResult Register(string firstName, string lastName, string email, string Password);
}
