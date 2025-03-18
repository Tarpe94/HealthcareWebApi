using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface IUserRole
    {
        public long UserId { get; }
        public long RoleId { get; }
        public IUser User { get; }
        public IRole Role { get; }
    }
}
