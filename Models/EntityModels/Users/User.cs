using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Doctors;
using Models.EntityModels.UserRoles;
using Shared.Interfaces;

namespace Models.EntityModels.Users
{
    public class User: IUser
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Bhirtday { get; set; }
        public Doctor Doctor { get; set; }
        public List<UserRole> UserRoles { get; set; }
        List<IUserRole> IUser.UserRoles => UserRoles.ToList<IUserRole>();
    }
}
