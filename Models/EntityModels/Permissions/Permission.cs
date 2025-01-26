using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.RolePermissions;

namespace Models.EntityModels.Permissions
{
    public class Permission
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }


    }
}
