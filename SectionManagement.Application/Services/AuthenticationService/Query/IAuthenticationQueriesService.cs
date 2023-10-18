using SectionManagement.Application.Services.AuthenticationService.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Services.AuthenticationService.Query;

public interface IAuthenticationQueryService
{
    AuthenticationResult Login(string email, string Password);
}
