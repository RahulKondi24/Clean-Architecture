using MyApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}
