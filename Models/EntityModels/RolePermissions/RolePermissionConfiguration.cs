using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Models.EntityModels.RolePermissions
{
    internal class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {

            builder.HasKey(rp => new
            {
                rp.RoleId,
                rp.PermissionId
            });

            // Configure Role relationship
            builder.HasOne(rp => rp.Role)
                .WithMany(u => u.RolePermissions)
                .HasForeignKey(ur => ur.RoleId);

            // Configure Permission relationship
            builder.HasOne(rp => rp.Permission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(rp => rp.PermissionId);
        }

    }
}
