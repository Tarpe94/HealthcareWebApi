using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.EntityModels.Users;

namespace Models.EntityModels.UserToken
{
    public class UserTokenConfiguration: IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            builder.HasIndex(t => t.Token).IsUnique();
        }
    }
}
