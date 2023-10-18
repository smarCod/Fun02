using SectionManagement.Application.Interfaces.Authentication;
using SectionManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SectionManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SectionManagement.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _appDbContext;

    public UserRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    // private static List<User> _users = new List<User>();

    public void Add(User user)
    {
        _appDbContext.PostUser.Add(user);
        _appDbContext.SaveChanges();
        // _users.Add(user);
    }

    public User GetUserByEmail(string email)
    {
        var user = _appDbContext.PostUser.Where(x => x.Email == email).FirstOrDefault();
        if (user == null)
        {
            throw new Exception();
        }
        else
            return user;
        // var result = _users.SingleOrDefault(x => x.Email == email);
        // if (result == null)
        // {
        //     result = new User();
        // }
        // return result;
    }
}
