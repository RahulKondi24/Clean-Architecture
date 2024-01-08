using MyApp.Application.Repositories;
using MyApp.Application.Services.Interfaces;
using MyApp.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


        public List<User> GetAllUsers()
        {
            return this.userRepository.GetAllUsers();
        }
    }
}
