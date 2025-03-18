using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EntityModels.Users;

namespace Models.EntityModels.UserToken
{
    public class UserToken
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Token { get; set; }
        public long ExpTimeTicms {get; set;}
        public bool IsUsed { get; set; }
        public long UserId { get; set; }
    }
}
