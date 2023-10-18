using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Interfaces.Common;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
