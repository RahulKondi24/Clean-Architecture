using MyApp.Application.Repositories;
using MyApp.Domain.Entites;
using MyApp.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<User> GetAllUsers()
        {
            return _db.Users.ToList();
        }
    }
}
