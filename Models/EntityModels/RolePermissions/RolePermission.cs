using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Permissions;
using Models.EntityModels.Roles;

namespace Models.EntityModels.RolePermissions
{
    public class RolePermission
    {
        public long RoleId { get; set; }
        public long PermissionId { get; set; }

        public Role Role { get; set; }
        public Permission Permission { get; set; }
    }
}
