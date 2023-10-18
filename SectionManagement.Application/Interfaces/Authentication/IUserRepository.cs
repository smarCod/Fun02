using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionManagement.Application.Interfaces.Authentication;

public interface IUserRepository
{
    void Add(User user);
    User? GetUserByEmail(string email);
}