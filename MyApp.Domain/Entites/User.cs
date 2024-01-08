using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ReferralId { get; set; }
        public string ReferredId { get; set; }
        public int Tokens { get; set; }
        public int RoleId { get; set; }
    }
}
