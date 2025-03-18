using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.RolePermissions;
using Models.EntityModels.UserRoles;
using Shared.Interfaces;

namespace Models.EntityModels.Roles
{
    public class Role : IRole
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }

    }
}
