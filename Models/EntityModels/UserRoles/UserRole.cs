﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Roles;
using Models.EntityModels.Users;
using Shared.Interfaces;

namespace Models.EntityModels.UserRoles
{
    public class UserRole : IUserRole
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }

        IUser IUserRole.User => User;
        IRole IUserRole.Role => Role;
    }
}
